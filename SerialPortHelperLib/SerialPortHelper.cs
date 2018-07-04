using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SerialPortHelperLib
{
    public class SerialPortHelper
    {
        #region 常量
        public const Int32 SERIAL_RECEIVED_TIME_INTERVAL = 20;  //接收数据间隔
        public const Int32 SERIAL_RECEIVED_LENGTH_MAX = 128;    //接收帧最大长度
        public const Int32 SERIAL_WRITE_TIME_INTERVAL = 100;    //发送数据帧时间间隔
        
        #endregion

        #region 内部变量
        private SerialPort serialPort;
        private Thread threadSerialCacheReceived;
        private Thread threadSerialDataReceived;
        private Thread threadSerialDataWrite;
        private Queue queueSerialCacheReceived;
        private Queue queueSerialDataReceived;
        private Queue queueSerialDataWrite;
        #endregion

        #region 字段
        private ConfigComType _configSerialPort;
        private Int32 _serialReceviedTimeInterval = SERIAL_RECEIVED_TIME_INTERVAL;
        private Int32 _serialReceviedLengthMax = SERIAL_RECEIVED_LENGTH_MAX;
        private Int32 _serialWriteTimeInterval = SERIAL_WRITE_TIME_INTERVAL;
        #endregion

        #region 属性
        public ConfigComType ConfigSerialPort { get => _configSerialPort; set => _configSerialPort = value; }
        public int SerialReceviedTimeInterval { get => _serialReceviedTimeInterval; set => _serialReceviedTimeInterval = value; }
        public int SerialReceviedLengthMax { get => _serialReceviedLengthMax; set => _serialReceviedLengthMax = value; }
        public int SerialWriteTimeInterval { get => _serialWriteTimeInterval; set => _serialWriteTimeInterval = value; }
        public bool IsOpen { get => serialPort.IsOpen; }
        #endregion

        #region 构造函数
        public SerialPortHelper()
        {
            //Control.CheckForIllegalCrossThreadCalls = false; //不检测跨线程访问
            InitQueue();
            InitSerialPort();
            InitThread();
        }

        public SerialPortHelper(ConfigComType config): this()
        {
            ConfigSerialPort = config;
        }

        public SerialPortHelper(ConfigComType config, DelegateSerialPortDataReceivedProcessEvent e): this(config)
        {
            BindSerialPortDataReceivedProcessEvent(e);
        }

        #endregion

        #region 初始化函数
        /// <summary>
        /// 初始化串口
        /// </summary>
        private void InitSerialPort()
        {
            //初始化串口
            serialPort = new SerialPort();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceivedEventFunction);
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            serialPort.Close();
        }

        /// <summary>
        /// 初始化线程
        /// </summary>
        private void InitThread()
        {
            //初始化接收缓存线程
            threadSerialCacheReceived = new Thread(new ThreadStart(ThreadSerialCacheReceivedFunction));
            threadSerialCacheReceived.IsBackground = true;

            //初始化接收数据线程
            threadSerialDataReceived = new Thread(new ThreadStart(ThreadSerialDataReceivedFunction));
            threadSerialDataReceived.IsBackground = true;

            //初始化发送数据线程
            threadSerialDataWrite = new Thread(new ThreadStart(ThreadSerialDataWriteFunction));
            threadSerialDataWrite.IsBackground = true;
        }

        /// <summary>
        /// 初始化队列（线程安全）
        /// </summary>
        private void InitQueue()
        {
            //初始化接收缓存队列
            queueSerialCacheReceived = Queue.Synchronized(new Queue());

            //初始化接收数据队列
            queueSerialDataReceived = Queue.Synchronized(new Queue());

            //初始化发送数据队列
            queueSerialDataWrite = Queue.Synchronized(new Queue());
        }

        #endregion

        #region 串口接收事件函数
        private void SerialDataReceivedEventFunction(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] readBuffer = new byte[serialPort.BytesToRead];
                int count = serialPort.Read(readBuffer, 0, readBuffer.Length);
                lock (queueSerialCacheReceived.SyncRoot)
                {
                    for (int i = 0; i < count; i++)
                    {
                        queueSerialCacheReceived.Enqueue(readBuffer[i]);
                    }
                }
            }
            catch (Exception error)
            {
                EventSerialPortError(enumSerialError.ReceivedError, error.Message);
            }

        }
        #endregion

        #region 线程处理函数
        /// <summary>
        /// 打开线程
        /// </summary>
        private void OpenThread()
        {
            InitThread();
            threadSerialCacheReceived.Start();
            threadSerialDataReceived.Start();
            threadSerialDataWrite.Start();
        }

        /// <summary>
        /// 接收缓存线程函数
        /// </summary>
        private void ThreadSerialCacheReceivedFunction()
        {
            List<byte> listData = new List<byte>();
            while (serialPort.IsOpen)
            {
                int cacheLength = queueSerialCacheReceived.Count;
                if (cacheLength > 0)
                {
                    for (int i = 0; i < cacheLength; i++)
                    {
                        listData.Add((byte)queueSerialCacheReceived.Dequeue());
                        if (listData.Count >= SerialReceviedLengthMax)
                        {
                            lock (queueSerialCacheReceived.SyncRoot)
                            {
                                queueSerialDataReceived.Enqueue(listData.ToArray()); //转为帧队列
                            }
                            listData.Clear();
                        }
                    }
                }
                else if (listData.Count > 0)
                {
                    lock (queueSerialCacheReceived.SyncRoot)
                    {
                        queueSerialDataReceived.Enqueue(listData.ToArray()); //转为帧队列
                    }
                    listData.Clear();
                }
                Thread.Sleep(SerialReceviedTimeInterval);
            }
            EventSerialPortError(enumSerialError.LinkError, "端口连接断开或未开启端口！");
            queueSerialCacheReceived.Clear();

        }

        /// <summary>
        /// 接收数据线程函数
        /// </summary>
        private void ThreadSerialDataReceivedFunction()
        {
            while (serialPort.IsOpen)
            {
                lock (queueSerialDataReceived.SyncRoot)
                {
                    if (queueSerialDataReceived.Count > 0)
                    {
                        byte[] byteData = (byte[])queueSerialDataReceived.Dequeue();
                        EventSerialPortDataReceivedProcess(byteData); //触发事件
                        continue;
                    }
                }
                Thread.Sleep(SerialReceviedTimeInterval);
            }
            lock (queueSerialDataReceived.SyncRoot)
            {
                queueSerialDataReceived.Clear();
            }
        }

        /// <summary>
        /// 发送数据线程函数
        /// </summary>
        private void ThreadSerialDataWriteFunction()
        {
            while (serialPort.IsOpen)
            {
                lock (queueSerialDataWrite.SyncRoot)
                {
                    if (queueSerialDataWrite.Count > 0)
                    {
                        byte[] byteData = (byte[])queueSerialDataWrite.Dequeue();
                        try
                        {
                            serialPort.Write(byteData, 0, byteData.Length);
                        }
                        catch (Exception e)
                        {
                            EventSerialPortError(enumSerialError.WriteError, e.Message);
                            return;
                        }
                    }
                }
                Thread.Sleep(SerialWriteTimeInterval);
            }

            lock (queueSerialDataWrite.SyncRoot)
            {
                queueSerialDataWrite.Clear();
            }
        }
        #endregion

        #region 数据接收处理事件
        /// <summary>
        /// 定义委托
        /// </summary>
        /// <param name="arrDataReceived">接收到的数据帧</param>
        public delegate void DelegateSerialPortDataReceivedProcessEvent(byte[] arrDataReceived);

        /// <summary>
        /// 定义事件
        /// </summary>
        public event DelegateSerialPortDataReceivedProcessEvent EventSerialPortDataReceivedProcess;

        /// <summary>
        /// 绑定接收事件
        /// </summary>
        /// <param name="e">接收处理函数</param>
        public void BindSerialPortDataReceivedProcessEvent(DelegateSerialPortDataReceivedProcessEvent e)
        {
            EventSerialPortDataReceivedProcess = e;
        }

        #endregion

        #region 串口异常事件
        /// <summary>
        /// 定义委托
        /// </summary>
        /// <param name="numError">错误代号</param>
        /// <param name="strError">错误信息</param>
        public delegate void DelegateSerialPortErrorEvent(enumSerialError enumError, string strError);

        /// <summary>
        /// 定义事件
        /// </summary>
        public event DelegateSerialPortErrorEvent EventSerialPortError;

        /// <summary>
        /// 绑定串口错误事件
        /// </summary>
        /// <param name="e">事件处理函数</param>
        public void BindSerialPortErrorEvent(DelegateSerialPortErrorEvent e)
        {
            EventSerialPortError = e;
        }
        #endregion

        #region 数据发送处理
        /// <summary>
        /// 串口发送数据
        /// </summary>
        /// <param name="arrData">数据内容</param>
        public void Write(byte[] arrData)
        {
            if (arrData.Length > 0)
            {
                if (serialPort.IsOpen)
                {
                    lock (queueSerialDataWrite.SyncRoot)
                    {
                        queueSerialDataWrite.Enqueue(arrData);
                    }
                }
                else
                {
                    EventSerialPortError(enumSerialError.LinkError, "端口未开启！");
                }
            }

        }

        /// <summary>
        /// 串口发送数据
        /// </summary>
        /// <param name="strData">数据内容</param>
        public void Write(string strData)
        {
            if (strData.Length > 0)
            {
                Write(SerialData.ToByteArray(strData));
            }
        }

        /// <summary>
        /// 串口发送Byte数据
        /// </summary>
        /// <param name="arrData">Byte数组数据</param>
        public void WriteByte(byte[] arrData)
        {
            Write(arrData);
        }

        /// <summary>
        /// 串口发送Char数据
        /// </summary>
        /// <param name="arrData">字符数组数据</param>
        public void WriteChar(char[] arrData)
        {
            Write(Encoding.Default.GetBytes(arrData));
        }

        /// <summary>
        /// 串口发送字符串数据
        /// </summary>
        /// <param name="strData">字符串数据</param>
        public void WriteString(string strData)
        {
            Write(strData);
        }

        /// <summary>
        /// 串口发送16进制字符串数据
        /// </summary>
        /// <param name="hexData">16进制字符串数据</param>
        public void WriteHexString(string hexData)
        {
            if (hexData.Length > 0)
            {
                Write(SerialData.ToHexByteArray(hexData));
            }
        }
        #endregion

        #region 公共函数
        /// <summary>
        /// 开启端口
        /// </summary>
        /// <param name="strError">错误信息</param>
        /// <returns>是否开启成功</returns>
        public bool OpenCom(out string strError)
        {
            //检测端口合法性
            if (DetectCom.IsCom(ConfigSerialPort.PortName) == false)
            {
                strError = "端口号不存在，无法开启端口。";
                return false;
            }
            else if (EventSerialPortDataReceivedProcess == null)
            {
                strError = "没有绑定接收数据事件";
                return false;
            }
            else
            {
                //写入串口配置
                serialPort.PortName = ConfigSerialPort.PortName;
                serialPort.BaudRate = ConfigSerialPort.BaudRate;
                serialPort.DataBits = ConfigSerialPort.DataBits;
                serialPort.StopBits = (System.IO.Ports.StopBits)ConfigSerialPort.StopBits;
                serialPort.Parity = (System.IO.Ports.Parity)ConfigSerialPort.Parity;

                //尝试关闭串口
                this.CloseCom(out strError);

                //开启端口
                try
                {
                    serialPort.Open();
                    OpenThread();
                    strError = "null";
                    return serialPort.IsOpen;
                }
                catch(Exception e)
                {
                    strError = e.Message;
                    return false;
                }
            }
        }

        /// <summary>
        /// 开启指定配置的端口
        /// </summary>
        /// <param name="config">配置</param>
        /// <param name="strError">错误信息</param>
        /// <returns>是否开启成功</returns>
        public bool OpenCom(ConfigComType config, out string strError)
        {
            ConfigSerialPort = config;
            bool ret = OpenCom(out string str);
            strError = str;
            return ret;
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <param name="strError">错误信息</param>
        public void CloseCom(out string strError)
        {
            try
            {
                serialPort.Close();
                strError = "null";
            }
            catch(Exception e)
            {
                strError = e.Message;
            }
            
        }

        #endregion

    }

    #region 枚举
    /// <summary>
    /// 串口错误枚举
    /// </summary>
    public enum enumSerialError
    {
        LinkError,
        WriteError,
        ReceivedError
    }
    #endregion
}

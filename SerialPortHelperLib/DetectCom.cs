using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SerialPortHelperLib
{
    /// <summary>
    /// 检测串口端口
    /// </summary>
    public class DetectCom
    {
        #region 常量
        //默认检测COM口时间间隔
        private const int DETECT_COM_INTERVAL = 300;
        #endregion

        #region 字段

        /// <summary>
        /// 检测模式字段
        /// </summary>
        private DetectComModeEnum _detectComMode;

        /// <summary>
        /// 检测串口列表的线程
        /// </summary>
        private Thread _threadDetectSerialPortList;

        /// <summary>
        /// 检测串口列表的定时器
        /// </summary>
        private System.Windows.Forms.Timer _timerDetectSerialPortList;

        /// <summary>
        /// 检测COM口时间间隔
        /// </summary>
        private double _intDetectComInterval = DETECT_COM_INTERVAL;

        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public DetectCom()
        {
            DetectComMode = DetectComModeEnum.None;
            DetectComInterval = DETECT_COM_INTERVAL;
            //Control.CheckForIllegalCrossThreadCalls = false; //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
        }

        /// <summary>
        /// 构造函数并绑定事件
        /// </summary>
        /// <param name="e">DelegateSerialPortListEvent事件函数</param>
        public DetectCom(DelegateSerialPortListEvent e) : this()
        {
            DetectComMode = DetectComModeEnum.Timer;
            this.EventSerialPortList += e;
        }
        #endregion

        #region 静态方法
        /// <summary>
        /// 获取串口列表
        /// </summary>
        public static string[] GetSerialProtNames
        {
            get
            {
                return SerialPort.GetPortNames();
            }
        }

        /// <summary>
        /// 判断端口号是否存在
        /// </summary>
        /// <param name="strPotrName">待检测的端口号</param>
        /// <returns></returns>
        public static bool IsCom(string strPotrName)
        {
            string[] arrPortNames = GetSerialProtNames;
            if (Array.IndexOf(arrPortNames, strPotrName) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 属性
        /// <summary>
        /// 检测COM模式
        /// </summary>
        public DetectComModeEnum DetectComMode
        {
            get
            {
                return _detectComMode;
            }
            set
            {
                if(_detectComMode != value)
                {
                    _detectComMode = value;
                }
            }
        }

        /// <summary>
        /// 检测COM口时间间隔（毫秒）
        /// 建议100-500，过短消耗资源，过长响应慢。
        /// </summary>
        public double DetectComInterval
        {
            get
            {
                return _intDetectComInterval;
            }
            set
            {
                _intDetectComInterval = value > 0 ? value : DETECT_COM_INTERVAL;
            }
        }

        /// <summary>
        /// 串口信息（串口名，信息内容）
        /// </summary>
        public Dictionary<string, string> DicSerialPortInfo { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// 默认串口信息
        /// </summary>
        public string[] StrSerialPortDefaultInfo { get; set; } = new string[] { };

        #endregion

        #region 公共函数
        /// <summary>
        /// 开启检测
        /// </summary>
        /// <returns>返回是否开启成功</returns>
        public bool Open()
        {
            //判断事件是否为空
            if(this.EventSerialPortList != null)
            {
                bool ret = false;
                //根据检测模式开启检测
                switch (DetectComMode)
                {
                    case DetectComModeEnum.None:
                        ret = false;
                        break;
                    case DetectComModeEnum.Thread:
                        this.InitDetectThread();
                        ret = true;
                        break;
                    case DetectComModeEnum.Timer:
                        this.InitDetectTimer();
                        ret = true;
                        break;
                    default:
                        ret = false;
                        break;
                }
                return ret;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 关闭检测
        /// </summary>
        public void Close()
        {
            switch (DetectComMode)
            {
                case DetectComModeEnum.None:
                    break;
                case DetectComModeEnum.Thread:
                    this.StopDetectThread();
                    break;
                case DetectComModeEnum.Timer:
                    this.StopDetctTimer();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 获取检测状态
        /// </summary>
        /// <returns></returns>
        public bool GetDetectComStatus()
        {
            bool ret = false;
            switch (DetectComMode)
            {
                case DetectComModeEnum.None:
                    break;
                case DetectComModeEnum.Thread:
                    switch (this._threadDetectSerialPortList.ThreadState)
                    {
                        case ThreadState.Running:
                        case ThreadState.Background:
                        case ThreadState.WaitSleepJoin:
                            ret = true;
                            break;
                        default:
                            ret = false;
                            break;
                    }
                    break;
                case DetectComModeEnum.Timer:
                    ret = this._timerDetectSerialPortList.Enabled;
                    break;
                default:
                    break;
            }
            return ret;
        }
        #endregion

        #region 串口列表变化事件
        /// <summary>
        /// 定义委托
        /// </summary>
        public delegate void DelegateSerialPortListEvent(string[] list);

        /// <summary>
        /// 定义事件
        /// </summary>
        public event DelegateSerialPortListEvent EventSerialPortList;

        #endregion

        #region 串口列表线程
        /// <summary>
        /// 初始化检测线程并开启
        /// </summary>
        private void InitDetectThread()
        {
            _threadDetectSerialPortList = new Thread(new ThreadStart(ThreadDetectSerialPortList));
            _threadDetectSerialPortList.IsBackground = true;
            _threadDetectSerialPortList.Start();
        }

        /// <summary>
        /// 初始化检测线程并开启
        /// </summary>
        /// <param name="interval">检测间隔</param>
        private void InitDetectThread(Int32 interval)
        {
            this.DetectComInterval = interval;
            InitDetectThread();
        }

        /// <summary>
        /// 关闭检测线程
        /// </summary>
        private void StopDetectThread()
        {
            _threadDetectSerialPortList.Abort();
        }

        /// <summary>
        /// 检测线程函数
        /// </summary>
        private void ThreadDetectSerialPortList()
        {
            while (true)
            {
                //线程休息300ms
                System.Threading.Thread.Sleep(Convert.ToInt32(this.DetectComInterval));

                //检测串口列表并处理
                DetectSerialPortListProcess();
            }
        }

        /// <summary>
        /// 判断两数组是否相同
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private bool CompareArray(string[] arr1, string[] arr2)
        {
            var q = from a in arr1 join b in arr2 on a equals b select a;
            bool flag = arr1.Length == arr2.Length && q.Count() == arr1.Length;
            return flag;//内容相同返回true,反之返回false。
        }
        #endregion

        #region 串口列表定时器
        /// <summary>
        /// 初始化定时器
        /// </summary>
        /// <param name="interval">时间间隔</param>
        private void InitDetectTimer(double interval)
        {
            this.DetectComInterval = interval;
            _timerDetectSerialPortList = new System.Windows.Forms.Timer();  // new System.Timers.Timer(this.DetectComInterval);
            _timerDetectSerialPortList.Tick += TimerDetectSerialPortList;
            _timerDetectSerialPortList.Interval = Convert.ToInt32(interval);
            _timerDetectSerialPortList.Enabled = true;
        }

        /// <summary>
        /// 初始化定时器
        /// </summary>
        private void InitDetectTimer()
        {
            InitDetectTimer(DETECT_COM_INTERVAL);
        }

        private void SetDetectTimerInterval(int interval)
        {
            if(_timerDetectSerialPortList != null)
            {
                _timerDetectSerialPortList.Interval = interval > 0 ? interval : DETECT_COM_INTERVAL;
            }
        }

        /// <summary>
        /// 停止定时器
        /// </summary>
        private void StopDetctTimer()
        {
            _timerDetectSerialPortList.Enabled = false;
        }

        /// <summary>
        /// 定时器中断函数
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void TimerDetectSerialPortList(object sender, EventArgs e)
        {
            //检测串口列表并处理
            DetectSerialPortListProcess();
        }
        #endregion

        #region 动态检测串口列表

        /// <summary>
        /// 当前串口列表
        /// </summary>
        private List<string> nowSerialPortList = new List<string>();

        /// <summary>
        /// 备份串口列表
        /// </summary>
        private List<string> bakSerialPortList = new List<string>();

        /// <summary>
        /// 检测串口列表并处理
        /// </summary>
        private void DetectSerialPortListProcess()
        {
            //获取当前串口列表
            nowSerialPortList.Clear();
            foreach (string item in SerialPort.GetPortNames())
            {
                nowSerialPortList.Add(item.ToString());
            }

            //串口列表比对
            if (CompareArray(nowSerialPortList.ToArray(), bakSerialPortList.ToArray()) == false)
            {
                //获取串口信息
                GetSerialPortInfo(DicSerialPortInfo);

                //更新备份列表
                bakSerialPortList.Clear();
                foreach (string item in nowSerialPortList)
                {
                    int index = StrSerialPortDefaultInfo.ToList().IndexOf(DicSerialPortInfo[item]);
                    if (DicSerialPortInfo.ContainsKey(item) && (index >= 0))
                    {
                        bakSerialPortList.Insert(0, item);
                    }
                    else
                    {
                        bakSerialPortList.Add(item);
                    }
                }

                //触发事件
                EventSerialPortList(bakSerialPortList.ToArray());
            }
        }

        /// <summary>
        /// 获取串口信息
        /// </summary>
        /// <param name="dicData">输出字典</param>
        /// <returns>返回信息数组</returns>
        private string[] GetSerialPortInfo(Dictionary<string,string> dicData = null)
        {
            string[] arrInfo = HardwareInfo.GetHardwareInfo(HardwareEnum.Win32_PnPEntity, "Name");
            if (dicData != null)
            {
                foreach (string item in arrInfo)
                {
                    MatchCollection matchCollection =  Regex.Matches(item, @"\(COM\d+\)");
                    if (matchCollection.Count > 0)
                    {
                        string strSerialPortName = matchCollection[matchCollection.Count - 1].Value;
                        string strSerialPortInfo = Regex.Replace(item, Regex.Escape(strSerialPortName) , "").Trim();
                        strSerialPortName = Regex.Replace(strSerialPortName, @"[\(\)]", "").Trim();
                        dicData[strSerialPortName] = strSerialPortInfo;
                        Console.WriteLine("Name：" + strSerialPortName + "\tInfo：" + strSerialPortInfo);
                    }
                }
            }
            return arrInfo;
        }

        #endregion

    }

    #region 枚举类型
    /// <summary>
    /// 检测模式定义
    /// </summary>
    public enum DetectComModeEnum
    {
        None,       //手动检测
        Thread,     //多线程检测（触发事件）
        Timer       //定时器检测（触发事件）
    }

    #endregion

}

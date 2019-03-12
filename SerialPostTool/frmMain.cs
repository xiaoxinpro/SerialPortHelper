using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SerialPortHelperLib;

namespace SerialPostTool
{
    public partial class frmMain : Form
    {
        #region 字段
        //串口配置类
        private ConfigCom configCom1;
        private ConfigCom configCom2;

        //串口助手类
        private SerialPortHelper serialPort1;
        private SerialPortHelper serialPort2;
        #endregion

        #region 初始化函数
        /// <summary>
        /// 初始化函数
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载完成事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //初始化串口
            InitSerialPort();

            //初始化UI
            InitUI();
        }

        /// <summary>
        /// 界面UI初始化
        /// </summary>
        private void InitUI()
        {
            //发送界面初始化
            cbWriteFormat1.SelectedIndex = 0;
            cbWriteFormat2.SelectedIndex = 0;
        }

        /// <summary>
        /// 串口对手初始化
        /// </summary>
        private void InitSerialPort()
        {
            //初始化串口配置类
            configCom1 = new ConfigCom(this.cbSerial1, this.cbBaudRate1, this.cbDataBits1, this.cbStop1, this.cbParity1);
            configCom2 = new ConfigCom(this.cbSerial2, this.cbBaudRate2, this.cbDataBits2, this.cbStop2, this.cbParity2);

            //初始化串口助手类
            serialPort1 = new SerialPortHelper();
            serialPort1.ConfigSerialPort = configCom1.GetConfigComData();
            serialPort1.BindSerialPortDataReceivedProcessEvent(new SerialPortHelper.DelegateSerialPortDataReceivedProcessEvent(SerialPortDataReceivedProcess));
            serialPort1.BindSerialPortErrorEvent(new SerialPortHelper.DelegateSerialPortErrorEvent(SerialPortErrorProcess));
            serialPort1.SerialReceviedTimeInterval = 40;
            serialPort1.SerialWriteTimeInterval = 1;
            serialPort1.SerialReceviedLengthMax = 1024;
            serialPort1.SerialMark = "串口1";

            serialPort2 = new SerialPortHelper();
            serialPort2.ConfigSerialPort = configCom1.GetConfigComData();
            serialPort2.BindSerialPortDataReceivedProcessEvent(new SerialPortHelper.DelegateSerialPortDataReceivedProcessEvent(SerialPortDataReceivedProcess));
            serialPort2.BindSerialPortErrorEvent(new SerialPortHelper.DelegateSerialPortErrorEvent(SerialPortErrorProcess));
            serialPort2.SerialReceviedTimeInterval = 40;
            serialPort2.SerialWriteTimeInterval = 1;
            serialPort2.SerialReceviedLengthMax = 1024;
            serialPort2.SerialMark = "串口2";
        }
        #endregion

        #region 串口数据函数
        /// <summary>
        /// 串口接收数据处理
        /// </summary>
        /// <param name="arrData">接收数据数组</param>
        private void SerialPortDataReceivedProcess(object sender, byte[] arrData)
        {
            this.Invoke(new Action(() =>
            {
                SerialPortHelper spb = (SerialPortHelper)sender;
                if (SerialData.IsBytesToString(arrData))
                {
                    Console.WriteLine(spb.SerialMark + "接收数据：" + SerialData.ToHexString(arrData));
                    Console.WriteLine(spb.SerialMark + "接收数据：" + SerialData.ToString(arrData));
                    txtDataReceived.AppendText(SerialData.ToString(arrData) + "\r\n");
                }
                else
                {
                    Console.WriteLine(spb.SerialMark + "接收数据：" + SerialData.ToHexString(arrData));
                    txtDataReceived.AppendText(SerialData.ToHexString(arrData) + "\r\n");
                }
            }));
        }

        /// <summary>
        /// 串口错误事件
        /// </summary>
        /// <param name="enumError">错误枚举</param>
        /// <param name="strError">错误内容</param>
        private void SerialPortErrorProcess(object sender, enumSerialError enumError, string strError)
        {
            this.Invoke(new Action(() =>
            {
                SerialPortHelper spb = (SerialPortHelper)sender;
                switch (enumError)
                {
                    case enumSerialError.LinkError:
                        spb.CloseCom(out string str);
                        Console.WriteLine(spb.SerialMark + "串口错误：" + strError);
                        //MessageBox.Show(strError, "串口错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case enumSerialError.WriteError:
                        Console.WriteLine(spb.SerialMark + "发送错误：" + strError);
                        break;
                    case enumSerialError.ReceivedError:
                        Console.WriteLine(spb.SerialMark + "接收错误：" + strError);
                        break;
                    default:
                        break;
                }
            }));
        }

        /// <summary>
        /// 串口发送数据处理函数
        /// </summary>
        /// <param name="spb">串口助手对象</param>
        /// <param name="data">发送数据</param>
        /// <param name="format">发送数据格式</param>
        private void SerialPortDataWriteProcess(SerialPortHelper spb, string data, SerialFormat format = SerialFormat.None)
        {
            if (data == "" || !spb.IsOpen)
            {
                return;
            }
            if (format == SerialFormat.None) 
            {
                format = SerialData.IsStringHex(data) ? SerialFormat.Hex : SerialFormat.String;
            }
            byte[] arrData;
            switch (format)
            {
                case SerialFormat.Hex:
                    arrData = SerialData.ToHexByteArray(data);
                    Console.WriteLine("发送数据：" + SerialData.ToHexString(arrData));
                    break;
                case SerialFormat.String:
                    arrData = SerialData.ToByteArray(data);
                    Console.WriteLine("发送数据：" + data);
                    break;
                case SerialFormat.None:
                default:
                    return;
            }
            spb.Write(arrData);
        }
        #endregion

        #region 串口UI操作事件
        /// <summary>
        /// 串口开关按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialPortSwitch_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ConfigCom cc = (btn.Tag.ToString() == "1") ? configCom1 : configCom2;
            SerialPortHelper spb = (btn.Tag.ToString() == "1") ? serialPort1 : serialPort2;
            if (btn.Text == "打开串口")
            {
                spb.OpenCom(cc.GetConfigComData(), out string strError);
                if (strError != "null")
                {
                    MessageBox.Show(strError);
                }
                else
                {
                    Console.WriteLine("开启{0}端口成功。", cc.PortName);
                    btn.Text = "关闭串口";
                }
            }
            else
            {
                spb.CloseCom(out string strError);
                if (strError != "null")
                {
                    MessageBox.Show(strError);
                }
                else
                {
                    Console.WriteLine("关闭端口成功。");
                    btn.Text = "打开串口";
                }
            }
        }

        /// <summary>
        /// 发送按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialWrite_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SerialPortHelper spb = (btn.Tag.ToString() == "1") ? serialPort1 : serialPort2;
            TextBox txt = (btn.Tag.ToString() == "1") ? txtSerialWrite1 : txtSerialWrite2;
            ComboBox cb = (btn.Tag.ToString() == "1") ? cbWriteFormat1 : cbWriteFormat2;
            if (!spb.IsOpen)
            {
                MessageBox.Show("串口" + btn.Tag.ToString() + "未开启，数据无法发送。", "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SerialFormat format;
                switch (cb.SelectedIndex)
                {
                    case 1:
                        format = SerialFormat.String;
                        break;
                    case 2:
                        format = SerialFormat.Hex;
                        break;
                    case 0:
                    default:
                        format = SerialFormat.None;
                        break;
                }
                SerialPortDataWriteProcess(spb, txt.Text, format);
            }
        }
        #endregion

    }
}

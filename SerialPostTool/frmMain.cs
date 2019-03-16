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
            cbWriteFormat1.SelectedIndex = 0;
            cbWriteFormat2.SelectedIndex = 0;
            cbReceiveFormat1.SelectedIndex = 0;
            cbReceiveFormat2.SelectedIndex = 0;
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
                    //Console.WriteLine(spb.SerialMark + "接收数据：" + SerialData.ToHexString(arrData));
                    //Console.WriteLine(spb.SerialMark + "接收数据：" + SerialData.ToString(arrData));
                    OutputInfo(SerialData.ToString(arrData), "接收", spb.SerialMark);
                    //txtDataReceived.AppendText(SerialData.ToString(arrData) + "\r\n");
                }
                else
                {
                    //Console.WriteLine(spb.SerialMark + "接收数据：" + SerialData.ToHexString(arrData));
                    OutputInfo(SerialData.ToHexString(arrData), "接收", spb.SerialMark);
                    //txtDataReceived.AppendText(SerialData.ToHexString(arrData) + "\r\n");
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
            GroupBox grp = btn.Parent as GroupBox;
            if (btn.Text == "打开串口")
            {
                spb.OpenCom(cc.GetConfigComData(), out string strError);
                if (strError != "null")
                {
                    MessageBox.Show(strError);
                }
                else
                {
                    cc.GetDetectCom().Close();
                    Console.WriteLine("开启{0}端口成功。", cc.PortName);
                    btn.Text = "关闭串口";
                    GroupBoxEnable(grp, false);
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
                    cc.GetDetectCom().Open();
                    Console.WriteLine("关闭端口成功。");
                    btn.Text = "打开串口";
                    GroupBoxEnable(grp, true);
                }
            }
        }

        /// <summary>
        /// GroupBox开关
        /// </summary>
        /// <param name="grp">GroupBox控件</param>
        /// <param name="enable">开关量</param>
        private void GroupBoxEnable(GroupBox grp, bool enable)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is ComboBox)
                {
                    item.Enabled = enable;
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
                SerialPortDataWriteProcess(spb, txt.Text, ComboToSerialFormat(cb));
                OutputInfo(txt.Text, "发送", spb.SerialMark);
            }
        }

        /// <summary>
        /// ComboBox转SerialFormat
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        private SerialFormat ComboToSerialFormat(ComboBox cb)
        {
            SerialFormat format = SerialFormat.None;
            if (cb.Items.Count == 3)
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
            return format;
        }
        #endregion

        #region 输出显示
        /// <summary>
        /// 输出显示信息
        /// </summary>
        /// <param name="strData">显示数据</param>
        /// <param name="strTitle">显示标题</param>
        /// <param name="strMark">显示备注</param>
        private void OutputInfo(string strData, string strTitle = "提示", string strMark = "串口1")
        {
            Color color = Color.Black;
            switch (strTitle)
            {
                case " ":
                    richTextInfo.AppendTextColorful(strData + " ", Color.Green, false);
                    return;
                case "提示":
                    color = Color.Black;
                    break;
                case "发送":
                    color = Color.Blue;
                    break;
                case "接收":
                    color = Color.Green;
                    break;
                case "错误":
                    color = Color.Red;
                    break;
                case "警告":
                    color = Color.Orange;
                    break;
                default:
                    return;
            }
            string strHead = "";
            if (chkShowSerial.Checked)
            {
                strHead += "[" + strMark + "]";
            }
            if (chkShowSend.Checked)
            {
                strHead += "[" + strTitle + "]";
            }
            if (chkShowTime.Checked)
            {
                strHead += "[" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") + "]";
            }
            richTextInfo.AppendTextColorful(strHead + strData, color);
        }

        /// <summary>
        /// 滚动条是否跟随标志位
        /// </summary>
        private bool IsSrollFollow = true;

        /// <summary>
        /// 输出文本框数据变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextInfo_TextChanged(object sender, EventArgs e)
        {
            if (IsSrollFollow)
            {
                richTextInfo.SelectionStart = richTextInfo.Text.Length;
                richTextInfo.SelectionLength = 0;
                richTextInfo.ScrollToCaret();
            }
        }

        /// <summary>
        /// 文本框滚动条最大位置
        /// </summary>
        private int MaxScrollPos = 0;

        /// <summary>
        /// 文本框滚动条改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetScrollPos")]
        public static extern int GetScrollPos(IntPtr hwnd, int nBar);
        private void richTextInfo_VScroll(object sender, EventArgs e)
        {
            RichTextBox richText = (RichTextBox)sender;
            int nowScroll = GetScrollPos(richText.Handle, 1);
            if (nowScroll > MaxScrollPos)
            {
                MaxScrollPos = nowScroll;
                IsSrollFollow = true;
            }
            else if (nowScroll < MaxScrollPos - 10)
            {
                IsSrollFollow = false;
            }
            else
            {
                IsSrollFollow = true;
            }
        }

        /// <summary>
        /// 消息文本框大小改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextInfo_SizeChanged(object sender, EventArgs e)
        {
            MaxScrollPos = 0;
        }

        /// <summary>
        /// 清空信息文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoClear_Click(object sender, EventArgs e)
        {
            richTextInfo.Clear();
            IsSrollFollow = true;
            MaxScrollPos = 0;
        }
        #endregion
    }
}

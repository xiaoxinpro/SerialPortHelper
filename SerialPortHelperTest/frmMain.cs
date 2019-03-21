using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SerialPortHelperLib;

namespace SerialPortHelperTest
{
    public partial class frmMain : Form
    {
        //定义DetectCom类
        private DetectCom dc;

        //定义ConfigCom类
        private ConfigCom cc;

        //定义SerialPortHelper类
        private SerialPortHelper spb;

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载入口函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //检测串口列表测试
            DetectComTest();

            //串口配置控件绑定
            ConfigComTest();

            //初始化串口类
            InitSerialPortHelper();
        }

        #region DetectCom函数
        private void DetectComTest()
        {
            //手动刷新(不推荐)
            ReflashSerialPortList();

            //实例化自动刷新（简单实例）
            //dc = new DetectCom(new DetectCom.DelegateSerialPortListEvent(AutoReflashSericalPortList));

            //可以强制使用线程或定时器刷新
            dc = new DetectCom(new DetectCom.DelegateSerialPortListEvent(AutoReflashSericalPortList));
            dc.DetectComMode = DetectComModeEnum.Thread;    //线程刷新
            dc.DetectComMode = DetectComModeEnum.Timer;     //定时器刷新

            //可以自定义刷新间隔事件
            //dc = new DetectCom(new DetectCom.DelegateSerialPortListEvent(AutoReflashSericalPortList));
            dc.DetectComInterval = 100; //设置刷新间隔100ms

            //设定默认串口设备名称
            dc.StrSerialPortDefaultInfo = new string[] { "TI CC2540 USB CDC Serial Port" };

            //打开自动刷新
            dc.Open();

            //关闭自动刷新
            //dc.Close();

        }

        /// <summary>
        /// 刷新串口列表
        /// </summary>
        private void ReflashSerialPortList()
        {
            string[] arrSerialPortNames = DetectCom.GetSerialProtNames;
            listSerialPort.Items.Clear();
            foreach (string item in arrSerialPortNames)
            {
                listSerialPort.Items.Add(item);
            }
        }

        /// <summary>
        /// 手动刷新列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReflashList_Click(object sender, EventArgs e)
        {
            ReflashSerialPortList();
        }

        /// <summary>
        /// 自动刷新列表开关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAutoReflash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoReflash.Checked)
            {
                dc.Open();
            }
            else
            {
                dc.Close();
            }
        }

        /// <summary>
        /// 自动刷新串口列表处理函数，串口发生变化时触发。
        /// </summary>
        /// <param name="list">串口列表</param>
        private void AutoReflashSericalPortList(string[] list)
        {
            this.Invoke(new Action(() =>
            {
                listSerialPort.Items.Clear();
                foreach (string item in list)
                {
                    listSerialPort.Items.Add(item);
                }
            }));
        }
        #endregion

        #region ConfigCom函数
        /// <summary>
        /// ConfigCom测试函数
        /// </summary>
        private void ConfigComTest()
        {
            //一次性绑定所有配置
            //cc = new ConfigCom(cbSerial, cbBaudRate, cbDataBits, cbStop, cbParity);

            //常用绑定配置
            //cc = new ConfigCom(cbSerial, cbBaudRate);

            //选择绑定配置
            cc = new ConfigCom(cbSerial);
            cc.BindBaudRateObj(cbBaudRate);
            cc.BindDataBitsObj(cbDataBits);
            cc.BindStopBitsObj(cbStop);
            cc.BindParityObj(cbParity);

            //设置默认搜索串口信息（覆盖已存在的）
            cc.SetSerialPortDefaultInfo("TI CC2540 USB CDC Serial Port");

            //添加默认搜索串口信息（追加）
            cc.AddSerialPortDefaultInfo("通用USB串口设备");
        }

        /// <summary>
        /// 获取串口配信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetConfigComData_Click(object sender, EventArgs e)
        {
            ConfigComType configComType = cc.GetConfigComData();
            string strMessage = string.Format("端口号：{0} \n\r波特率：{1} \n\r数据位：{2} \n\r停止位：{3} \n\r检验位：{4} ",configComType.PortName,configComType.BaudRate,configComType.DataBits,configComType.StopBits,configComType.Parity);
            MessageBox.Show(strMessage,"串口配置 ConfigCom",MessageBoxButtons.OK);
        }

        /// <summary>
        /// 设置串口配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetConfigComData_Click(object sender, EventArgs e)
        {
            if (listSerialPort.SelectedIndices.Count == 1)
            {
                cc.PortName = listSerialPort.SelectedItems[0].ToString();
            }
            cc.BaudRate = 14400;
            cc.DataBits = 7;
            cc.StopBits = StopBits.OnePointFive;
            cc.Parity = Parity.Even;
        }

        #endregion

        #region SerialPortHelper函数
        /// <summary>
        /// SerialPortHelper初始化
        /// </summary>
        private void InitSerialPortHelper()
        {
            spb = new SerialPortHelper();
            spb.ConfigSerialPort = cc.GetConfigComData();
            spb.BindSerialPortDataReceivedProcessEvent(new SerialPortHelper.DelegateSerialPortDataReceivedProcessEvent(SerialPortDataReceivedProcess));
            spb.BindSerialPortErrorEvent(new SerialPortHelper.DelegateSerialPortErrorEvent(SerialPortErrorProcess));
            spb.SerialReceviedTimeInterval = 40;
            spb.SerialWriteTimeInterval = 1;
            spb.SerialReceviedLengthMax = 1024;
        }



        /// <summary>
        /// 串口接收数据处理
        /// </summary>
        /// <param name="sender">串口助手类对象</param>
        /// <param name="arrData">接收数据数组</param>
        private void SerialPortDataReceivedProcess(object sender, byte[] arrData)
        {
            this.Invoke(new Action(() =>
            {
                if (SerialData.IsBytesToString(arrData))
                {
                    Console.WriteLine("接收数据：" + SerialData.ToHexString(arrData));
                    Console.WriteLine("接收数据：" + SerialData.ToString(arrData));
                    txtDataReceived.AppendText(SerialData.ToString(arrData) + "\r\n");
                }
                else
                {
                    Console.WriteLine("接收数据：" + SerialData.ToHexString(arrData));
                    txtDataReceived.AppendText(SerialData.ToHexString(arrData) + "\r\n");
                }
            }));
        }

        /// <summary>
        /// 串口错误事件
        /// </summary>
        /// <param name="sender">串口助手类对象</param>
        /// <param name="enumError">错误枚举</param>
        /// <param name="strError">错误内容</param>
        private void SerialPortErrorProcess(object sender, enumSerialError enumError, string strError)
        {
            this.Invoke(new Action(() =>
            {
                switch (enumError)
                {
                    case enumSerialError.LinkError:
                        spb.CloseCom(out string str);
                        Console.WriteLine("串口错误：" + strError);
                        //MessageBox.Show(strError, "串口错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case enumSerialError.WriteError:
                        Console.WriteLine("发送错误：" + strError);
                        break;
                    case enumSerialError.ReceivedError:
                        Console.WriteLine("接收错误：" + strError);
                        break;
                    default:
                        break;
                }
            }));
        }

        /// <summary>
        /// 串口开关控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialPortSwitch_Click(object sender, EventArgs e)
        {
            if (btnSerialPortSwitch.Text == "打开串口")
            {
                spb.OpenCom(cc.GetConfigComData(), out string strError);
                if(strError != "null")
                {
                    MessageBox.Show(strError);
                }
                else
                {
                    Console.WriteLine("开启{0}端口成功。", cc.PortName);
                    btnSerialPortSwitch.Text = "关闭串口";
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
                    btnSerialPortSwitch.Text = "打开串口";
                }
            }
        }
        #endregion

        #region 发送数据处理
        /// <summary>
        /// 添加发送数据
        /// </summary>
        private void AddSerialWrite()
        {
            if (txtSerialWrite.Text == "" || !spb.IsOpen)
            {
                return;
            }
            byte[] arrData;
            switch (GetWriteFormat())
            {
                case SerialFormat.Hex:
                    arrData = SerialData.ToHexByteArray(txtSerialWrite.Text);
                    Console.WriteLine("发送数据：" + SerialData.ToHexString(arrData));
                    break;
                case SerialFormat.String:
                    arrData = SerialData.ToByteArray(txtSerialWrite.Text);
                    Console.WriteLine("发送数据：" + txtSerialWrite.Text);
                    break;
                case SerialFormat.None:
                default:
                    return;
            }
            spb.Write(arrData);
        }

        /// <summary>
        /// 发送按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialWrite_Click(object sender, EventArgs e)
        {
            if (!spb.IsOpen)
            {
                MessageBox.Show("端口未开启。", "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                AddSerialWrite();
            }
        }

        /// <summary>
        /// 发送定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timSerialWrite_Tick(object sender, EventArgs e)
        {
            if (spb.IsOpen)
            {
                AddSerialWrite();
            }
        }

        /// <summary>
        /// 定时发送串口开关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSerialWriteLoop_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox that = (CheckBox)sender;
            if (txtSerialWriteInterval.Text.Length <= 0)
            {
                txtSerialWriteInterval.Text = "100";
            }
            timSerialWrite.Interval = Convert.ToInt32(txtSerialWriteInterval.Text);
            timSerialWrite.Enabled = that.Checked;
            txtSerialWriteInterval.Enabled = !that.Checked;
        }

        /// <summary>
        /// 定时输入框限制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSerialWriteInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 获取发送数据格式
        /// </summary>
        /// <returns></returns>
        private SerialFormat GetWriteFormat()
        {
            if (rioHex.Checked)
            {
                return SerialFormat.Hex;
            }
            else if (rioString.Checked)
            {
                return SerialFormat.String;
            }
            else
            {
                return SerialFormat.None;
            }
        }
        #endregion

    }
}

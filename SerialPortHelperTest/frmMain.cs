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
        }

        #region DetectCom函数
        private void DetectComTest()
        {
            //手动刷新(不推荐)
            ReflashSerialPortList();

            //实例化自动刷新（简单实例）
            dc = new DetectCom(new DetectCom.DelegateSerialPortListEvent(AutoReflashSericalPortList));

            //可以强制使用线程或定时器刷新
            dc = new DetectCom(new DetectCom.DelegateSerialPortListEvent(AutoReflashSericalPortList));
            dc.DetectComMode = DetectComModeEnum.Thread;    //线程刷新
            dc.DetectComMode = DetectComModeEnum.Timer;     //定时器刷新

            //可以自定义刷新间隔事件
            dc = new DetectCom(new DetectCom.DelegateSerialPortListEvent(AutoReflashSericalPortList));
            dc.DetectComInterval = 100; //设置刷新间隔100ms

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
        private void AutoReflashSericalPortList(List<string> list)
        {
            listSerialPort.Items.Clear();
            foreach (string item in list)
            {
                listSerialPort.Items.Add(item);
            }
        }
        #endregion

        #region ConfigCom函数
        /// <summary>
        /// ConfigCom测试函数
        /// </summary>
        private void ConfigComTest()
        {
            //一次性绑定所有配置
            cc = new ConfigCom(cbSerial, cbBaudRate, cbDataBits, cbStop, cbParity);

            //常用绑定配置
            cc = new ConfigCom(cbSerial, cbBaudRate);

            //选择绑定配置
            cc = new ConfigCom(cbSerial);
            cc.BindBaudRateObj(cbBaudRate);
            cc.BindDataBitsObj(cbDataBits);
            cc.BindStopBitsObj(cbStop);
            cc.BindParityObj(cbParity);
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


    }
}

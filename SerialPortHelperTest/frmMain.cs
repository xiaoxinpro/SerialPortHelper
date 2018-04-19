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
        private DetectCom dc;

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
            //手动刷新
            ReflashSerialPortList();

            //实例化自动刷新
            dc = new DetectCom(new DetectCom.DelegateSerialPortListEvent(AutoReflashSericalPortList));
            dc.Open();
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
            if (chkAutoReflash.Enabled)
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
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SerialPostTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string strError;
            if (CheckInit(out strError))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            else
            {
                if (MessageBox.Show(strError, "无法启动程序", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://github.com/xiaoxinpro/SerialPortHelper/releases");
                }
                Application.Exit();
            }
        }

        static bool CheckInit(out string message)
        {
            message = "";

            //获取运行目录
            string strPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

            //判断SerialPortHelperLib.dll是否有效
            string strPathSerialPortHelperLib = strPath + @"SerialPortHelperLib.dll";
            if (!File.Exists(strPathSerialPortHelperLib))
            {
                message = "缺少SerialPortHelperLib.dll文件，请安装最新版本。";
                return false;
            }

            //判断SerialPortHelperLib.dll版本号
            Version verSerialPortHelperLib = new Version(FileVersionInfo.GetVersionInfo(strPathSerialPortHelperLib).FileVersion);
            if (verSerialPortHelperLib < new Version("19.10.19.0"))
            {
                message = "类库文件SerialPortHelperLib.dll版本过低，请安装最新版本。";
                return false;
            }

            return true;
        }
    }
}

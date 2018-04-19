using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SerialPortHelperLib
{
    /// <summary>
    /// 检测串口端口
    /// </summary>
    public class DetectCom
    {
        #region 字段
        /// <summary>
        /// 检测串口列表的线程
        /// </summary>
        private Thread _threadDetectSerialPortList;

        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public DetectCom()
        {
            
        }

        public DetectCom(DelegateSerialPortListEvent e)
        {
            this.EventSerialPortList += e;
        }
        #endregion

        #region 静态方法
        public static string[] GetSerialProtNames
        {
            get
            {
                return SerialPort.GetPortNames();
            }
        }
        #endregion

        #region 属性
        /// <summary>
        /// 开启检测
        /// </summary>
        /// <returns>返回是否开启成功</returns>
        public bool Open()
        {
            if(this.EventSerialPortList != null)
            {
                this.InitDetectThread();
                return true;
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
            this.StopDetectThread();
        }
        #endregion

        #region 串口列表变化事件
        /// <summary>
        /// 定义委托
        /// </summary>
        public delegate void DelegateSerialPortListEvent(List<string> list);

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
            Control.CheckForIllegalCrossThreadCalls = false; //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
            _threadDetectSerialPortList = new Thread(new ThreadStart(ThreadDetectSerialPortList));
            _threadDetectSerialPortList.IsBackground = true;
            _threadDetectSerialPortList.Start();
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
            //当前串口列表
            List<string> nowSerialPortList = new List<string>();

            //备份串口列表
            List<string> bakSerialPortList = new List<string>();

            while (true)
            {
                //线程休息300ms
                System.Threading.Thread.Sleep(300);

                //获取当前串口列表
                nowSerialPortList.Clear();
                foreach (string item in SerialPort.GetPortNames())
                {
                    nowSerialPortList.Add(item.ToString());
                }

                //串口列表比对
                if(CompareArray(nowSerialPortList.ToArray(),bakSerialPortList.ToArray()) == false)
                {
                    //更新备份列表
                    bakSerialPortList.Clear();
                    foreach (string item in nowSerialPortList)
                    {
                        bakSerialPortList.Add(item);
                    }

                    //触发事件
                    EventSerialPortList(bakSerialPortList);
                }
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

    }
}

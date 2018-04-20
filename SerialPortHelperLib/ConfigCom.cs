using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialPortHelperLib
{
    public class ConfigCom
    {
        #region 常量
        private const int BAUD_RATE = 9600;
        private const int DATA_BITS = 8;
        private const StopBits STOP_BITS = StopBits.One;
        private const Parity PARITY = Parity.None;

        private int[] ARRAY_BAUD_RATE = { 1200, 2400, 4800, 7200, 9600, 14400, 19200, 38400, 115200, 128000 };
        private int[] ARRAY_DATA_BITS = { 5, 6, 7, 8 };
        #endregion

        #region 内部变量
        private DetectCom detectCom;
        private ComboBox cbPortName;
        #endregion

        #region 字段
        private string _PortName = null;
        private int _BaudRate = BAUD_RATE;
        private int _DataBits = DATA_BITS;
        private StopBits _StopBits = STOP_BITS;
        private Parity _Parity = PARITY;
        #endregion

        #region 属性
        public string PortName { get => _PortName; set => _PortName = value; }
        public int BaudRate
        {
            get
            {
                return _BaudRate;
            }
            set
            {
                if (Array.IndexOf(ARRAY_BAUD_RATE, value) >= 0)
                {
                    _BaudRate = value;
                }
            }
        }
        public int DataBits
        {
            get
            {
                return _DataBits;
            }
            set
            {
                if(value >= 5 && value <= 8)
                {
                    _DataBits = value;
                }
            }
        }
        public StopBits StopBits { get => _StopBits; set => _StopBits = value; }
        public Parity Parity { get => _Parity; set => _Parity = value; }
        #endregion

        #region 构造函数
        public ConfigCom(ComboBox cbPortName)
        {
            BindPortNameObj(cbPortName);
            detectCom = new DetectCom(new DetectCom.DelegateSerialPortListEvent(ReflashSerialPortList));
            detectCom.Open();
        }
        #endregion

        #region 公共函数
        public void BindPortNameObj(ComboBox cb)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.Clear();
            cbPortName = cb;
        }

        public void BindBaudRateObj(ComboBox cb)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.Clear();
            foreach (int item in ARRAY_BAUD_RATE)
            {
                cb.Items.Add(item);
                if (item == BAUD_RATE)
                {
                    cb.SelectedIndex = cb.Items.Count - 1;
                }
            }
        }

        public void BindDataBitsObj(ComboBox cb)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.Clear();
            foreach (int item in ARRAY_DATA_BITS)
            {
                cb.Items.Add(item);
                if (item == DATA_BITS)
                {
                    cb.SelectedIndex = cb.Items.Count - 1;
                }
            }
        }

        public void BindStopBitsObj(ComboBox cb)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.Clear();
            foreach (int item in Enum.GetValues(typeof(StopBits)))
            {
                switch ((StopBits)item)
                {
                    case StopBits.None:
                        cb.Items.Add(0);
                        break;
                    case StopBits.One:
                        cb.Items.Add(1);
                        break;
                    case StopBits.Two:
                        cb.Items.Add(2);
                        break;
                    case StopBits.OnePointFive:
                        cb.Items.Add(1.5);
                        break;
                    default:
                        break;
                }
                if (STOP_BITS == (StopBits)item)
                {
                    cb.SelectedIndex = cb.Items.Count - 1;
                }
            }
        }

        public void BindParityObj(ComboBox cb)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.Clear();
            foreach (int item in Enum.GetValues(typeof(Parity)))
            {
                switch ((Parity)item)
                {
                    case Parity.None:
                        cb.Items.Add("无校验");
                        break;
                    case Parity.Odd:
                        cb.Items.Add("奇校验");
                        break;
                    case Parity.Even:
                        cb.Items.Add("偶校验");
                        break;
                    case Parity.Mark:
                        cb.Items.Add("强制为1");
                        break;
                    case Parity.Space:
                        cb.Items.Add("强制为0");
                        break;
                    default:
                        break;
                }
                if (PARITY == (Parity)item)
                {
                    cb.SelectedIndex = cb.Items.Count - 1;
                }
            }
        }
        #endregion

        #region 刷新串口列表
        private void ReflashSerialPortList(List<string> list)
        {
            cbPortName.Items.Clear();
            foreach (string item in list)
            {
                cbPortName.Items.Add(item);
            }
        }
        #endregion
    }

    #region 枚举类型
    /// <summary>
    /// 停止位
    /// </summary>
    public enum StopBits
    {
        None = 0,
        One = 1,
        Two = 2,
        OnePointFive = 3
    }

    /// <summary>
    /// 校验位
    /// </summary>
    public enum Parity
    {
        None = 0,
        Odd = 1,
        Even = 2,
        Mark = 3,
        Space = 4
    }
    #endregion
}

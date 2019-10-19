using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPostTool
{
    public class SerialMainConfig
    {
        public static string Path { get; set; }

        public SerialMainConfig()
        {
            ResetConfig();
        }

        public Boolean IsSaveConfig1;
        public Boolean IsSaveConfig2;
        public Boolean IsAutoLink1;
        public Boolean IsAutoLink2;
        public int SerialEncode1;
        public int SerialEncode2;
        public SerialPortHelperLib.ConfigComType ConfigCom1;
        public SerialPortHelperLib.ConfigComType ConfigCom2;

        /// <summary>
        /// 默认配置
        /// </summary>
        public void ResetConfig()
        {
            IsSaveConfig1 = false;
            IsSaveConfig2 = false;
            IsAutoLink1 = false;
            IsAutoLink2 = false;
            SerialEncode1 = 0;
            SerialEncode2 = 0;
            SerialPortHelperLib.ConfigCom.GetDefaultConfigCom(ref ConfigCom1);
            SerialPortHelperLib.ConfigCom.GetDefaultConfigCom(ref ConfigCom2);
        }
    }
}

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

        }

        public Boolean IsSaveConfig1;
        public Boolean IsSaveConfig2;
        public Boolean IsAutoLink1;
        public Boolean IsAutoLink2;
        public Encoder SerialEncode1;
        public Encoder SerialEncode2;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPostTool
{
    public class SerialWriteConfig
    {
        public SerialWriteConfig()
        {

        }

        public string Name { get; set; }
        public string Data { get; set; }
        public SerialPortHelperLib.SerialFormat Format { get; set; }
        public bool IsTimer { get; set; }
        public int Timer { get; set; }

    }
}

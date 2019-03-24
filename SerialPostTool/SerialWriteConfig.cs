using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPostTool
{
    public class SerialWriteConfig
    {
        public static string Path { get; set; }
        public SerialWriteConfig()
        {

        }
        public string Name { get; set; }
        public string Data { get; set; }
        public SerialPortHelperLib.SerialFormat Format { get; set; }
        public bool IsTimer { get; set; }
        public int Timer { get; set; }

        public static int GetIndex(SerialWriteConfig[] arr, string name)
        {
            int ret = -1;
            if (arr != null && arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Name == name)
                    {
                        return i;
                    }
                }
            }
            return ret;
        }
    }
}

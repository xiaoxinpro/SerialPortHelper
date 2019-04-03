using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SerialPostTool
{
    public class SerialInfoConfig
    {
        public static string Path { get; set; }
        public SerialInfoConfig()
        {

        }

        public Font Font;
        public Color Color1Write;
        public Color Color1Receive;
        public Color Color2Write;
        public Color Color2Receive;

        /// <summary>
        /// 默认配置
        /// </summary>
        public void ResetConfig()
        {
            Font = new Font("宋体", 9);
            Color1Write = Color.Blue;
            Color2Write = Color.Blue;
            Color1Receive = Color.Green;
            Color2Receive = Color.Green;
        }
    }
}

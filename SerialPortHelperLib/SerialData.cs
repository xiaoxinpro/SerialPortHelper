using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SerialPortHelperLib
{
    public class SerialData
    {
        /// <summary>
        /// byte[]转成string
        /// </summary>
        /// <param name="byteData"></param>
        /// <returns></returns>
        public static string ToString(byte[] byteData)
        {
            return System.Text.Encoding.Default.GetString(byteData);
        }

        /// <summary>
        /// string类型转成byte[]
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(string strData)
        {
            return System.Text.Encoding.Default.GetBytes(strData);
        }

        /// <summary>
        /// string类型转成ASCII byte[]：
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        public static byte[] ToAsciiByteArray(string strData)
        {
            return System.Text.Encoding.ASCII.GetBytes(strData);
        }

        /// <summary>
        /// ASCIIbyte[]转成string
        /// </summary>
        /// <param name="byteData"></param>
        /// <returns></returns>
        public static string ToAsciiString(byte[] byteData)
        {
            return System.Text.Encoding.ASCII.GetString(byteData);
        }

        /// <summary>
        /// byte[]转16进制格式string
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ToHexString(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (i > 0)
                    {
                        returnStr += " ";
                    }
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }

        /// <summary>
        /// 字符串转16进制字节数组 
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] ToHexByteArray(string hexString)
        {
            hexString = CheakHexString(hexString);
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString = "0" + hexString;
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        /// <summary>
        /// 校验16进制字符串
        /// </summary>
        /// <param name="strBuffHex"></param>
        /// <returns></returns>
        private static string CheakHexString(string strBuffHex)
        {
            strBuffHex = strBuffHex.Trim();     //去除前后空字符
            strBuffHex = strBuffHex.Replace(',', ' ');  //去掉英文逗号
            strBuffHex = strBuffHex.Replace('，', ' '); //去掉中文逗号
            strBuffHex = strBuffHex.Replace("0x", "");  //去掉0x
            strBuffHex = strBuffHex.Replace("0X", "");  //去掉0X
            strBuffHex = Regex.Replace(Regex.Replace(strBuffHex, @"(?i)[^a-f\d\s]+", ""), "\\w{3,}", m => string.Join(" ", Regex.Split(m.Value, @"(?<=\G\w{2})(?!$)").Select(x => x.PadLeft(2, '0')).ToArray())).ToUpper();
            return strBuffHex;
        }
    }

    public enum SerialFormat
    {
        None,
        Hex,
        String
    }
}

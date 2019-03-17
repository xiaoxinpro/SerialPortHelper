using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization; //需要引用：System.Web.Extensions.dll

namespace SerialPostTool
{
    public static class Json
    {
        /// <summary>
        /// 内存对象转换为json字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToString(object obj)
        {
            StringBuilder sb = new StringBuilder();
            JavaScriptSerializer json = new JavaScriptSerializer();
            json.Serialize(obj, sb);
            return sb.ToString();
        }
        /// <summary>
        /// Json字符串转内存对象
        /// </summary>
        /// <param name="jsonString"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T ToObject<T>(string jsonString)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            return json.Deserialize<T>(jsonString);
        }

        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="dic">数据</param>
        public static void WriteFile(string path, object obj)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.Write(ToString(obj));
            }
        }

        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="dic">数据</param>
        public static T ReadFile<T>(string path)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            if (!File.Exists(path))
            {
                return json.Deserialize<T>("");
            }
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                try
                {
                    return ToObject<T>(sr.ReadLine().Trim().ToString());
                }
                catch (Exception)
                {
                    return json.Deserialize<T>("");
                }
            }
        }
    }
}

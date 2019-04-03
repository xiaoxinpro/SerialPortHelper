using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Script.Serialization; //需要引用：System.Web.Extensions.dll
using Newtonsoft.Json;

namespace SerialPostTool
{
    public static class Json
    {
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
        /// 从一个对象信息生成Json串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ObjectToJson(object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// 从一个Json串生成对象信息
        /// </summary>
        /// <param name="jsonString"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object JsonToObject(string jsonString, object obj)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString, obj.GetType());
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
                sw.Write(ObjectToJson(obj));
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

        public static object ReadFile(string path, object obj)
        {
            if (!File.Exists(path))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                return JsonToObject(sr.ReadLine().Trim().ToString(), obj);
            }
        }
    }
}

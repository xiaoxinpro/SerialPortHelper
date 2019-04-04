using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace SerialPostTool
{
    public static class Json
    {
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
        /// 从一个Json串生成对象信息(包含DataTable和List<>集合对象)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strJson"></param>
        /// <returns></returns>
        public static T JsonToObject<T>(string strJson)
        {
            T oRes = default(T);
            try
            {
                oRes = JsonConvert.DeserializeObject<T>(strJson);
            }
            catch
            { }
            return oRes;
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
        public static T ReadFile<T>(string path)
        {
            if (!File.Exists(path))
            {
                return JsonToObject<T>("");
            }
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                try
                {
                    return JsonToObject<T>(sr.ReadLine().Trim().ToString());
                }
                catch (Exception)
                {
                    return JsonToObject<T>("");
                }
            }
        }

        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="obj">对象原型</param>
        /// <returns></returns>
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

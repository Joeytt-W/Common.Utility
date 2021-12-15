using System;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Commom.Utility
{
    public class XMLTool
    {
        /// <summary>
        /// 类序列化XMl
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string Serialize<T>(T t)
        {
            try
            {
                string result = string.Empty;
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, t);
                    stream.Position = 0;
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        result = reader.ReadToEnd();
                    }
                }
                XmlDocument newxml = new XmlDocument();
                newxml.LoadXml(result);
                newxml.RemoveChild(newxml.FirstChild);
                newxml.FirstChild.Attributes.RemoveAll();
                return newxml.InnerXml;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// XMl序列化类（反序列化）
        /// </summary>
        /// <typeparam name="T">序列化输出对象类型</typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T DeSerialize<T>(string str)
        {
            try
            {
                T result = default(T);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                string xml = HttpUtility.HtmlDecode(str);
                using (MemoryStream stream = new MemoryStream())
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(xml);
                        writer.Flush();
                        stream.Position = 0;
                        result = (T)serializer.Deserialize(stream);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}

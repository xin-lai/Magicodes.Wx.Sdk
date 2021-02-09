using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Magicodes.Wx.PublicAccount.Sdk.Helper
{
    public class XmlHelper
    {
        /// <summary>
        /// XML序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeObject<T>(T obj)
        {
            using (var stream = new MemoryStream())
            {
                var xmlSerial = new XmlSerializer(obj.GetType());
                //序列化对象
                xmlSerial.Serialize(stream, obj);
                stream.Position = 0;
                using (var sr = new StreamReader(stream))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// 序列化XML不带命名空间和定义
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeObjectWithoutNamespace<T>(T obj)
        {
            var sb = new StringBuilder();
            var settings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                Indent = false,
                OmitXmlDeclaration = true
            };
            using (var xmlWriter = XmlWriter.Create(sb, settings))
            {
                //去除默认命名空间xmlns:xsd和xmlns:xsi
                var xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add(string.Empty, string.Empty);
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(xmlWriter, obj, xmlSerializerNamespaces);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static T DeserializeObject<T>(Stream stream)
        {
            var xmlSerial = new XmlSerializer(typeof(T));
            return (T)xmlSerial.Deserialize(stream);
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static T DeserializeObject<T>(string input) where T : class
        {
            if (!input.StartsWith("<?xml"))
                input = @"<?xml version=""1.0"" encoding=""utf-8""?>" + input;
            using (var memoryStream = new MemoryStream(Encoding.Default.GetBytes(input)))
            {
                return DeserializeObject<T>(memoryStream);
            }
        }
    }
}
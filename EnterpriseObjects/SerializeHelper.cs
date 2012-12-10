using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.296
     * Class   Name       SerializeHelper
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          SerializeHelper
     * Created Time       2012/12/10 10:12:24
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 提供序列化和反序列化对象的相关静态方法
    /// </summary>
    /// 
    public class SerializeHelper
    {

        #region 序列化方法

        /// <summary>
        /// 序列化指定对象
        /// </summary>
        /// <param name="type">序列化类型</param>
        /// <param name="obj">需要序列化的对象</param>
        /// <param name="path">序列文件保存的路径</param>
        /// <returns>返回执行状态</returns>
        public static bool Serialize(SerializeType type, Object obj, string path)
        {
            bool flag = false;

            switch (type)
            {
                case SerializeType.Xml:
                    flag = XmlSerialize(obj, path);
                    break;
                case SerializeType.Soap:
                    flag = SoapSerialize(obj, path);
                    break;
                case SerializeType.Binary:
                    flag = BinarySerialize(obj, path);
                    break;
                default:
                    flag = BinarySerialize(obj, path);
                    break;
            }

            return flag;
        }

        /// <summary>
        /// BinaryFormatter
        /// </summary>
        /// <param name="obj">需要序列化的对象</param>
        /// <param name="path">序列文件保存的路径</param>
        /// <returns>返回执行状态</returns>
        private static bool BinarySerialize(Object obj, string path)
        {
            bool flag = false;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, obj);
                flag = true;
            }

            return flag;
        }


        /// <summary>
        /// SoapFormatter
        /// </summary>
        /// <param name="obj">需要序列化的对象</param>
        /// <param name="path">序列文件保存的路径</param>
        /// <returns>返回执行状态</returns>
        private static bool SoapSerialize(Object obj, string path)
        {
            return true;
        }

        /// <summary>
        /// XmlFormatter
        /// </summary>
        /// <param name="obj">需要序列化的对象</param>
        /// <param name="path">序列文件保存的路径</param>
        /// <returns>返回执行状态</returns>
        private static bool XmlSerialize(Object obj, string path)
        {
            bool flag = false;

            XmlSerializer serializer = new XmlSerializer(obj.GetType());

            using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                XmlSerializerNamespaces n = new XmlSerializerNamespaces();
                n.Add("MonoBook", "http://www.cmono.net");
                serializer.Serialize(writer, obj, n);
                flag = true;
            }

            return flag;
        }


        #endregion

        #region 反序列化方法

        public static object Deserialize(SerializeType serType, Type type, string path)
        {
            object obj = null;

            switch (serType)
            {
                case SerializeType.Xml:
                    break;
                case SerializeType.Soap:
                    break;
                case SerializeType.Binary:
                    obj = BinaryDeserialize(type, path);
                    break;
                default:
                    obj = BinaryDeserialize(type, path);
                    break;
            }

            return obj;
        }

        private static object BinaryDeserialize(Type type, string path)
        {
            object obj = null;

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                obj = formatter.Deserialize(stream);
            }

            return obj;
        }

        #endregion

    }

    /// <summary>
    /// 序列化类型枚举类
    /// </summary>
    public enum SerializeType
    {
        [Description("XML序列化")]
        Xml,
        [Description("SoapFormatter序列化")]
        Soap,
        [Description("BinaryFormatter序列化")]
        Binary
    }

}

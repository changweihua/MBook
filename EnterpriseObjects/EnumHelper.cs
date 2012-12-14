using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Reflection;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       EnumHelper
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          EnumHelper
     * Created Time       2012/12/14 12:42:07
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 枚举类型帮助类
    /// </summary>
    /// 
    public class EnumHelper
    {
        /// <summary>
        /// 遍历Enum枚举项，判断是否存在，如果存在，返回，否则，返回默认值
        /// </summary>
        /// <typeparam name="T">枚举类类型</typeparam>
        /// <param name="str">查询字符串</param>
        /// <returns>结果</returns>
        public static T Contains<T>(string str)
        {
            T t = default(T);

            if (!string.IsNullOrEmpty(str))
            {
                foreach (string name in Enum.GetNames(typeof(T)))
                {
                    if (string.Compare(name, str, true) == 0)
                    {
                        t = (T)Enum.Parse(typeof(T), name, false);
                    }
                }
            }

            return t;
        }


        /// <summary>
        /// Enum转换成List
        /// </summary>
        /// <typeparam name="T">Enum类型</typeparam>
        /// <returns></returns>
        public static List<string> EnumToList<T>()
        {
            List<string> list = new List<string>();
            foreach (string name in Enum.GetNames(typeof(T)))
            {
                list.Add(name);
            }

            return list;
        }



        public static List<EnumDescription> EnumToDescriptionList<T>()
        {
            List<EnumDescription> list = new List<EnumDescription>();
            EnumDescription ed = null;
            foreach (string name in Enum.GetNames(typeof(T)))
            {
                T t = Contains<T>(name);
                string desc = GetEnumDescription<T>(t);
                ed = new EnumDescription { Name = name, Description = desc };
                list.Add(ed);
            }

            return list;
        }


        /// <summary>
        /// 过滤Enum项
        /// </summary>
        /// <typeparam name="T">Enum类型</typeparam>
        /// <param name="filters">需要过滤的枚举项的名称</param>
        /// <returns></returns>
        public static List<string> EnumFilter<T>(string[] filters)
        {
            List<string> list = new List<string>();
            foreach (string name in Enum.GetNames(typeof(T)))
            {
                foreach (string filter in filters)
                {
                    if (string.Compare(name, filter, false) == 0)
                    {
                        continue;
                    }
                    list.Add(name);
                }

            }

            return list;
        }

        static StringDictionary enumDescriptions = new StringDictionary();

        public static string GetEnumDescription<EnumType>(EnumType @enum)
        {
            string descriptionContent = string.Empty;

            Type enumType = @enum.GetType();

            string key = enumType.ToString() + "__" + @enum.ToString();

            if (enumDescriptions[key] == null)
            {
                FieldInfo fieldInfo = enumType.GetField(@enum.ToString());
                if (fieldInfo != null)
                {
                    EnumDescriptionAttribute[] attributes = (EnumDescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(EnumDescriptionAttribute), false);
                    if (attributes != null && attributes.Length > 0)
                    {

                        enumDescriptions[key] = attributes[0].Text;

                        return enumDescriptions[key];

                    }
                }

                enumDescriptions[key] = @enum.ToString();
            }

            return enumDescriptions[key];
        }

    }


    public class EnumDescription
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

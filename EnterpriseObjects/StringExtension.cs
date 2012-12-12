using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       StringExtension
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          StringExtension
     * Created Time       2012/12/12 14:12:52
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 添加类描述
    /// </summary>
    /// 
    public static class StringExtension
    {
        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="str">需要截取的字符串</param>
        /// <param name="length">截取长度</param>
        /// <param name="defValue">长度不够，默认添加的值</param>
        /// <returns></returns>
        public static string GetSubString(this string str, int length, string defValue)
        {
            int strLength = str.Length;
            StringBuilder sb = new StringBuilder(str);

            if (length >= strLength)
            {

                for (int i = 0; i < length - strLength; i++)
                {
                    sb.Append(defValue);
                }
            }

            return sb.ToString();
        }
    }
}

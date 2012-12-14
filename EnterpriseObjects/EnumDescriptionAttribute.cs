using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       EnumDescriptionAttribute
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          EnumDescriptionAttribute
     * Created Time       2012/12/14 12:46:10
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 自定义枚举属性类
    /// </summary>
    /// 
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumDescriptionAttribute : Attribute
    {
        private string text;

        public string Text
        {
            get
            {
                return this.text;
            }
        }

        public EnumDescriptionAttribute(string t)
        {
            this.text = t;
        }

    }
}

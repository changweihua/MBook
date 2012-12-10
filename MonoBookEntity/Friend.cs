using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.296
     * Class   Name       Friend
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          Friend
     * Created Time       2012/12/10 18:00:15
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 联系人类
    /// </summary>
    /// 
    [XmlRoot(ElementName="friend")]
    public class Friend
    {
        /// <summary>
        /// 序列化为节点属性
        /// </summary>
        [XmlAttribute("guid")]
        public string Guid { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("department")]
        public string Department { get; set; }
        [XmlElement("telephone")]
        public string Telephone { get; set; }
        [XmlElement("email")]
        public string Email { get; set; }
        [XmlElement("address")]
        public string Address { get; set; }
        [XmlElement("website")]
        public string Website { get; set; }
        [XmlElement("birthday")]
        public string Birthday { get; set; }
        [XmlElement("qq")]
        public string QQ { get; set; }
        [XmlElement("msn")]
        public string MSN { get; set; }
        [XmlElement("rank")]
        public string Rank { get; set; }
        [XmlElement("remark")]
        public string Remark { get; set; }
        [XmlIgnore]//忽略
        public string Picture { get; set; }

    }
}

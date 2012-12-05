using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       Contact
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       Contact
     * 创建时间:       2012/12/5  17:32:24
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    /// <summary>
    /// 联系人实体类
    /// </summary>
    
    [Table(Name="tbContact")]
    public class Contact
    {
        [Id]
        public string Guid;
        [Column]
        public string Name;
        [Column]
        public string Department;
        [Column]
        public string Telephone;
        [Column]
        public string Email;
        [Column]
        public string Address;
        [Column]
        public string Website;
        [Column]
        public string Birthday;
        [Column]
        public string QQ;
        [Column]
        public string Msn;
        [Column]
        public string Remark;
        [Column]
        public string Rank;
        [Column]
        public byte[] UserImage;
    }
}

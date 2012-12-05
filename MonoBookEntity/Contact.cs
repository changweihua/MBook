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
        /// <summary>
        /// Guid标识符
        /// </summary>
        [Id(Name = "c_guid")]
        public string Guid;

        /// <summary>
        /// 姓名
        /// </summary>
        [Column(Name = "c_name")]
        public string Name;

        /// <summary>
        /// 部门
        /// </summary>
        [Column(Name = "c_department")]
        public string Department;

        /// <summary>
        /// 电话
        /// </summary>
        [Column(Name = "c_telephone")]
        public string Telephone;

        /// <summary>
        /// 邮箱
        /// </summary>
        [Column(Name = "c_email")]
        public string Email;

        /// <summary>
        /// 地址
        /// </summary>
        [Column(Name = "c_address")]
        public string Address;

        /// <summary>
        /// 网站
        /// </summary>
        [Column(Name = "c_website")]
        public string Website;

        /// <summary>
        /// 生日
        /// </summary>
        [Column(Name = "c_birthday")]
        public string Birthday;

        /// <summary>
        /// QQ
        /// </summary>
        [Column(Name = "c_qq")]
        public string QQ;

        /// <summary>
        /// MSN
        /// </summary>
        [Column(Name = "c_msn")]
        public string Msn;

        /// <summary>
        /// 备注
        /// </summary>
        [Column(Name = "c_remark")]
        public string Remark;

        /// <summary>
        /// 头衔
        /// </summary>
        [Column(Name = "c_rank")]
        public string Rank;

        /// <summary>
        /// 照片
        /// </summary>
        [Column(Name = "c_image")]
        public byte[] UserImage;
    }
}

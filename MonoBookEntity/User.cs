using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       User
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       User
     * 创建时间:       2012/12/5  13:08:00
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
    /// 用户类
    /// </summary>
    [Table(Name = "tbUser")]
    public class User
    {
        /// <summary>
        /// Guid唯一标识符
        /// </summary>
        [Id(Name = "u_guid")]
        public string Guid;

        /// <summary>
        /// 电子邮件
        /// </summary>
        [Column(Name = "u_email")]
        public string UserEmail;

        /// <summary>
        /// 用户名
        /// </summary>
        [Column(Name = "u_name")]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [Column(Name = "u_password")]
        public string UserPassword;

        /// <summary>
        /// 出生日期
        /// </summary>
        [Column(Name = "u_birthday")]
        public DateTime UserBirthday;

        /// <summary>
        /// QQ
        /// </summary>
        [Column(Name = "u_qq")]
        public string UserQQ;

        /// <summary>
        /// VIP级别
        /// </summary>
        [Column(Name = "u_vip_type_id")]
        public int UserVipTypeId;

        /// <summary>
        /// 会员积分
        /// </summary>
        [Column(Name = "u_member_count")]
        public int UserMemberCount;

        /// <summary>
        /// 头像
        /// </summary>
        [Column(Name = "u_image")]
        public byte[] UserImage;

        /// <summary>
        /// 用户流量
        /// </summary>
        [Column(Name = "u_flow")]
        public int UserFlow;

        /// <summary>
        /// 用户已用流量
        /// </summary>
        [Column(Name = "u_used_flow")]
        public int UserUsedFlow;

        /// <summary>
        /// 用户个人网站
        /// </summary>
        [Column(Name = "u_website")]
        public string UserWebsite;

        /// <summary>
        /// 腾讯微博
        /// </summary>
        [Column(Name = "u_tencent")]
        public string UserTencent;

        /// <summary>
        /// 新浪微博
        /// </summary>
        [Column(Name = "u_sina")]
        public string UserSina;

        /// <summary>
        /// 账号创建日期
        /// </summary>
        [Column(Name = "u_create_date")]
        public string UserSina;

        /// <summary>
        /// 密保邮箱
        /// </summary>
        [Column(Name = "u_secret_email")]
        public string UserSina;

        /// <summary>
        /// 等级编号
        /// </summary>
        [Column(Name = "u_grade_id")]
        public string UserSina;
    }
}

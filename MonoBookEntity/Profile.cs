using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       Profile
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          Profile
     * Created Time       2012/12/14 19:18:11
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 用户资料类
    /// </summary>
    /// 
    [Table(Name="tbUser")]
    public class Profile
    {
        [Id(Name="u_guid")]
        public string Guid { get; set; }
        [Column(Name="u_email")]
        public string Email { get; set; }
        [Column(Name = "u_name")]
        public string Name { get; set; }
        [Column(Name = "u_password")]
        public string Password { get; set; }
        [Column(Name = "u_birthday")]
        public string Birthday { get; set; }
        [Column(Name = "u_qq")]
        public string QQ { get; set; }
        [Column(Name = "u_viptype_name")]
        public string VipTypeName { get; set; }
        [Column(Name = "u_member_count")]
        public int MemberCount { get; set; }
        [Column(Name = "u_image")]
        public byte[] Image { get; set; }
        [Column(Name = "u_flow")]
        public int Flow { get; set; }
        [Column(Name = "u_used_flow")]
        public int UsedFlow { get; set; }
        [Column(Name = "u_website")]
        public string Website { get; set; }
        [Column(Name = "u_tencent")]
        public string Tencent { get; set; }
        [Column(Name = "u_sina")]
        public string Sina { get; set; }
        [Column(Name = "u_create_date")]
        public string CreateDate { get; set; }
        [Column(Name = "u_grade_name")]
        public string GradeName { get; set; }
    }
}

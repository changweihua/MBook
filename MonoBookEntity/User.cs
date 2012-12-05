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
        [Id]
        public string Guid;
        [Column]
        public string UserEmail;
        [Column]
        public string UserName;
        [Column]
        public string UserPassword;
        [Column]
        public DateTime UserBirthday;
        [Column]
        public string UserQQ;
        [Column]
        public int UserVipTypeId;
        [Column]
        public int UserMemberCount;
        [Column]
        public byte[] UserImage;
        [Column]
        public int UserFlow;
        [Column]
        public int UserUsedFlow;
        [Column]
        public string UserWebsite;
        [Column]
        public string UserTencent;
        [Column]
        public string UserSina;
    }
}

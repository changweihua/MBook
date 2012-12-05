using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       Mail
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       Mail
     * 创建时间:       2012/12/5  17:36:32
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
    /// 邮件实体类
    /// </summary>
    
    [Table(Name="")]
    public class Mail
    {
        [Id]
        public string Guid;
        [Column]
        public string FromName;
        [Column]
        public string FromEmail;
        [Column]
        public string FromPassword;
        [Column]
        public string ToName;
        [Column]
        public string ToEmail;
        [Column]
        public string EmailTitle;
        [Column]
        public string EmailSubject;
        [Column]
        public string EmailContent;
    }
}

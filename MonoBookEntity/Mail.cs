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
    
    [Table(Name="tbMail")]
    public class Mail
    {
        /// <summary>
        /// Guid标识符
        /// </summary>
        [Id(Name = "m_guid")]
        public string Guid;

        /// <summary>
        /// 发件人姓名
        /// </summary>
        [Column(Name = "m_from_name")]
        public string FromName;

        /// <summary>
        /// 发件人邮箱
        /// </summary>
        [Column(Name = "m_from_email")]
        public string FromEmail;

        /// <summary>
        /// 发件人邮箱密码
        /// </summary>
        [Column(Name = "m_from_password")]
        public string FromPassword;

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [Column(Name = "m_to_name")]
        public string ToName;

        /// <summary>
        /// 收件人邮箱
        /// </summary>
        [Column(Name = "m_to_email")]
        public string ToEmail;

        /// <summary>
        /// 邮件标题
        /// </summary>
        [Column(Name = "m_title")]
        public string EmailTitle;

        /// <summary>
        /// 邮件主题
        /// </summary>
        [Column(Name = "m_subject")]
        public string EmailSubject;

        /// <summary>
        /// 邮件正文
        /// </summary>
        [Column(Name = "M_content")]
        public string EmailContent;
    }
}

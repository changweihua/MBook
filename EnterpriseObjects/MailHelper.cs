﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.IO;
using System.Net;
using System.ComponentModel;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       MailHelper
     * 机器名称:       HSERVER
     * 命名空间:       EnterpriseObjects
     * 文 件 名:       MailHelper
     * 创建时间:       2012/12/7  10:21:11
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
    /// 添加类描述
    /// </summary>
    public class MailHelper
    {
        SmtpClient smtpClient = null;//设置SMTP协议
        MailAddress mailFrom = null;//设置发信人地址
        MailAddress mailTo = null;//设置收信人地址
        MailMessage mailMessage = null;
        FileStream fStream = null;//附件文件流

        private bool result = false;//发送结果

        public bool Result
        {
            get
            {
                return result;
            }
        }

        private string msg;

        public string Msg
        {
            get
            {
                return this.msg;
            }
        }

        #region SMTP服务器信息设置

        /// <summary>
        /// 设置SMTP服务器信息
        /// </summary>
        /// <param name="serverHost">服务名</param>
        /// <param name="port">端口</param>
        private void SetSmtpClient(string serverHost, int port)
        {
            smtpClient = new SmtpClient();
            //指定SMTP服务面，QQ邮箱为smtp.qq.com
            smtpClient.Host = serverHost;
            smtpClient.Port = port;
            smtpClient.Timeout = 0;
        }

        #endregion

        #region 验证发件人信息

        /// <summary>
        /// 验证发件人信息
        /// </summary>
        /// <param name="mailAddress">发件邮箱地址</param>
        /// <param name="mailPwd">邮箱密码</param>
        private void SetAddressFrom(string mailAddress, string mailPwd, string mailFromName)
        {
            //创建服务器认证
            NetworkCredential ncFrom = new NetworkCredential(mailAddress, mailPwd);
            //实例化发件人地址
            mailFrom = new MailAddress(mailAddress, mailFromName);
            //指定发件人信息，包括邮箱地址和密码
            smtpClient.Credentials = new NetworkCredential(mailFrom.Address, mailPwd);
        }

        #endregion

        #region 添加附件

        private bool Attachment_MainInit(string path)
        {
            try
            {
                fStream = new FileStream(path, FileMode.Open);
                string name = fStream.Name;
                int size = (int)(fStream.Length / 1024 / 1024);
                fStream.Close();
                //附加大小不能超过10M
                if (size > 10)
                {
                    return false;
                }
            }
            catch (IOException ex)
            {
                return false;
            }
            return true;
        }

        #endregion

        #region 正式发送邮件


        public void SendMail(string serverHost, int port, string mailAddress, string mailPwd, string mailFromName, string subject, string mailMessageBody, string mailTo, string mailToName)
        {
            mailMessage = new MailMessage();
            SetSmtpClient(serverHost, port);
            SetAddressFrom(mailAddress, mailPwd, mailFromName);
            //清空历史发送信息
            if (mailMessage.To.Count > 0)
            {
                mailMessage.To.Clear();
            }
            //添加发件人，可添加多个
            mailMessage.To.Add(new MailAddress(mailTo, mailToName, Encoding.UTF8));
            //发件人邮箱
            mailMessage.From = mailFrom;
            //邮件主题
            mailMessage.Subject = subject;
            mailMessage.SubjectEncoding = Encoding.UTF8;
            //邮件正文
            mailMessage.Body = mailMessageBody;
            mailMessage.BodyEncoding = Encoding.UTF8;
            //清空历史附件
            if (mailMessage.Attachments.Count > 0)
            {
                mailMessage.Attachments.Clear();
            }
            //添加附件
            //注册邮件发送完毕后的处理事件
            smtpClient.SendCompleted += new SendCompletedEventHandler(smtpClient_SendCompleted);
            //开始发送
            smtpClient.Send(mailMessage);
        }

        #endregion

        #region 发送邮件后所处理的函数

        private void smtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    msg = "发送已取消！";
                    result = false;
                }
                if (e.Error != null)
                {
                    result = false;
                    msg = "邮件发送失败！" + "\n" + "技术信息:\n" + e.ToString();
                }
                else
                {
                    result = true;
                    msg = "邮件成功发出!";
                }
            }
            catch (Exception Ex)
            {
                result = false;
                msg = "邮件发送失败！" + "\n" + "技术信息:\n" + Ex.Message;
            }

        }

        #endregion
    }
}

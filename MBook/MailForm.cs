using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using System.Threading;
using EnterpriseObjects;


namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       MailForm
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       MailForm
     * 创建时间:       2012/12/2  21:57:23
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class MailForm : XtraForm
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void llBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Process p = Process.Start("iexplore.exe",(sender as LinkLabel).Text);
        }

        private void buttonEditAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = e.Button.Index;


            switch (index)
            {
                case 0:
                    SendMail();
                    break;
                case 1:
                    break;
                case 2:
                    this.Close();
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// 设置输入框为只读
        /// </summary>
        /// <returns></returns>
        private void SetControlStatus()
        {
            var groupControls = this.Controls.Find("groupControl2", true);

            if (groupControls.Length > 0)
            {
                var collection = groupControls[0].Controls;

                for (int i = 0; i < collection.Count; i++)
                {
                    if (collection[i].GetType().Name == "ButtonEdit")
                    {
                        (collection[i] as ButtonEdit).Properties.ReadOnly = !(collection[i] as ButtonEdit).Properties.ReadOnly;
                    }
                    else if (collection[i].GetType().Name == "MemoEdit")
                    {
                        (collection[i] as MemoEdit).Properties.ReadOnly = !(collection[i] as MemoEdit).Properties.ReadOnly;
                    }
                }

            }
            radioGroup1.Enabled = !radioGroup1.Enabled;
            mpbcSendStatus.Visible = !mpbcSendStatus.Visible;
            buttonEditAction.Enabled = !buttonEditAction.Enabled;

        }


        /// <summary>
        /// 发送邮件
        /// </summary>
        private void SendMail()
        {

            if (CheckForm())
            {
                SetControlStatus();

                string server = this.radioGroup1.Properties.Items[this.radioGroup1.SelectedIndex].Value.ToString();
                string mailFrom = buttonEditMailFrom.EditValue.ToString();
                string mailFromName = buttonEditMailFromName.EditValue.ToString();
                string mailFromPassword = buttonEditMailFromPassword.EditValue.ToString();
                string mailTo = buttonEditMailTo.EditValue.ToString();
                string mailToName = buttonEditMailToName.EditValue.ToString();
                string mailTitle = buttonEditMailTitle.EditValue.ToString();
                string mailSubject = memoEditMailSubject.EditValue.ToString();
                string mailContent = memoEditMailContent.EditValue.ToString();


                Thread thread = new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        MailHelper mailHelper = Singleton<MailHelper>.Instance;
                        //  mailHelper.SendMail("smtp.yeah.net", 25, "dyelcwh@yeah.net", "danyang%%huazai", "monobook", "ceshi", "ceshineirong", "dyelcwh@163.com", "mamager");
                        //mailHelper.SendMailAsync("smtp.yeah.net", 25, "dyelcwh@yeah.net", "************", "monobook", "ceshi", "ceshineirong", "dyelcwh@163.com", "mamager", (sender, e) =>
                        mailHelper.SendMailAsync(server, 25, mailFrom, mailFromPassword, mailFromName, mailTitle, mailSubject + mailContent, mailTo, mailToName, (sender, e) =>
                        {
                            string msg = mailHelper.Message;
                            MailResult result = mailHelper.Result;

                            try
                            {
                                if (e.Cancelled)
                                {
                                    msg = "发送已取消！";
                                    result = MailResult.Cancel;
                                }
                                if (e.Error != null)
                                {
                                    result = MailResult.Fail;
                                    msg = "邮件发送失败！" + "\n" + "技术信息:\n" + e.ToString();
                                }
                                else
                                {
                                    result = MailResult.Success;
                                    msg = "邮件成功发出!";
                                }
                            }
                            catch (Exception Ex)
                            {
                                result = MailResult.Fail;
                                msg = "邮件发送失败！" + "\n" + "技术信息:\n" + Ex.Message;
                            }

                            SendComplete(result, msg);
                        });

                    }
                    catch (Exception ex)
                    {
                        SendComplete(MailResult.Unknow, ex.Message);
                    }

                }));
                thread.Start();
            }
        }


        /// <summary>
        /// 检查是否输入完整
        /// </summary>
        /// <returns></returns>
        private bool CheckForm()
        {
            var groupControls = this.Controls.Find("groupControl2", true);

            if (groupControls.Length > 0)
            {
                var collection = groupControls[0].Controls;
                
                for (int i = 0; i < collection.Count; i++)
                {
                    if (collection[i].GetType().Name == "ButtonEdit")
                    {
                        if ((collection[i] as ButtonEdit).EditValue == null)
                        {
                            XtraMessageBox.Show(this.LookAndFeel, "不能为空", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else if (collection[i].GetType().Name == "MemoEdit")
                    {
                        if ((collection[i] as MemoEdit).EditValue == null)
                        {
                            XtraMessageBox.Show(this.LookAndFeel, "不能为空", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
                if (radioGroup1.SelectedIndex < 0)
                {
                    XtraMessageBox.Show(this.LookAndFeel, "必须选择", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            return true;
        }


        /// <summary>
        /// 发送完毕
        /// </summary>
        private void SendComplete(MailResult success, string msg)
        {
            if (mpbcSendStatus.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    SendComplete(success, msg);
                }));
            }
            else
            {
                //mpbcSendStatus.Visible = false;
                SetControlStatus();
                if (success == MailResult.Success)
                {
                    XtraMessageBox.Show(this.LookAndFeel, msg, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show(this.LookAndFeel, msg, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void MailForm_Load(object sender, EventArgs e)
        {
            //检测本地是否已经存在文件夹，不存在，就创建
            EnterpriseObjects.DirectoryHelper directoryHelper = new EnterpriseObjects.DirectoryHelper();
            directoryHelper.CreateDirOperate(Properties.Settings.Default.savePath + @"\My Mails", EnterpriseObjects.OperateOption.ExistReturn);
        }

    }


}

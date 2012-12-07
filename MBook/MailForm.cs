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

            mpbcSendStatus.Visible = !mpbcSendStatus.Visible;
            buttonEditAction.Enabled = !buttonEditAction.Enabled;

        }


        /// <summary>
        /// 发送邮件
        /// </summary>
        private void SendMail()
        {
            //if (CheckForm())
            //{
                SetControlStatus();
                //mpbcSendStatus.Visible = true;
                //buttonEditAction.Enabled = false;
                Thread thread = new Thread(new ThreadStart(() => {
                    try
                    {
                        MailHelper mailHelper = Singleton<MailHelper>.Instance;
                        mailHelper.SendMail("smtp.yeah.net", 25, "dyelcwh@yeah.com", "danyang%%huazai", "monobook", "ceshi", "ceshineirong", "dyelcwh@163.com", "mamager");

                        string msg = mailHelper.Msg;
                        bool result = mailHelper.Result;

                        if (result)
                        {
                            SendComplete(result, msg);
                        }
                        else
                        {
                            SendComplete(result, msg);
                        }
                    }
                    catch (Exception ex)
                    {
                        SendComplete(false, ex.Message);
                    }
                   

                }));
                thread.Start();

            //}
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
                SetControlStatus();
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

            }

            return true;
        }


        /// <summary>
        /// 发送完毕
        /// </summary>
        private void SendComplete(bool success, string msg)
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
                XtraMessageBox.Show(this.LookAndFeel, msg, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }


}

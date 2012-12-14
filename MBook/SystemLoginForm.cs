using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Collections;
using NLite.Data;
using MonoBookEntity;

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       SystemLoginForm
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       SystemLoginForm
     * 创建时间:       2012/12/5 9:26:29
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class SystemLoginForm : XtraForm
    {
        public SystemLoginForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 按钮的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = e.Button.Index;

            switch (index)
            {
                case 0:
                    Login();
                    break;
                case 1:
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
                default:
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                    break;
            }

        }


        /// <summary>
        /// 登录时，将控件设为只读
        /// </summary>
        private void SetControlReadonly()
        {
            this.buttonEditPassport.Enabled = !this.buttonEditPassport.Enabled;
            this.buttonEditPassword.Enabled = !this.buttonEditPassword.Enabled;
            this.checkEditRemember.Enabled = !this.checkEditRemember.Enabled;
            this.buttonEditAction.Enabled = !this.buttonEditAction.Enabled;
        }

        /// <summary>
        /// 登录操作
        /// </summary>
        private void Login()
        {
            if (!CheckInput())
            {
                return;
            }

            SetControlReadonly();
            loginProgress.Visible = true;
            string passport = this.buttonEditPassport.EditValue.ToString();
            string password = this.buttonEditPassword.EditValue.ToString();

            bool isRemeber = this.checkEditRemember.Checked;

            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                var profile = ctx.Set<Profile>().SingleOrDefault(p => p.Email == passport && p.Password == password);

                if (profile != null)
                {
                    if (isRemeber)
                    {
                        Properties.Settings.Default.UserEmail = passport;
                        Properties.Settings.Default.UserPassword = password;
                        Properties.Settings.Default.Save();
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    loginProgress.Visible = false;
                    this.DialogResult = DialogResult.No;
                }

            }

            //新建一个线程进行登录
            //Thread threadLogin = new Thread(new ThreadStart(() =>
            //{
            //    try
            //    {
            //        //bool result = oauth.ClientLogin(passport, password);
            //        //NetDimension.Weibo.TokenResult tokenResult = oauth.VerifierAccessToken();
            //        bool result = oa.ClientLogin(passport, password);
            //        NetDimension.Weibo.TokenResult tokenResult = oa.VerifierAccessToken();

            //        if (tokenResult == NetDimension.Weibo.TokenResult.Success)
            //        {
            //            UILoginComplete(result, "登录成功");
            //        }
            //        else
            //        {
            //            UILoginComplete(result, tokenResult.ToString());
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        UILoginComplete(false, ex.Message);
            //    }
            //}));

            //threadLogin.Start();

           
            
        }

        /// <summary>
        /// 检查输入是否合法
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            string passport = this.buttonEditPassport.EditValue == null ? "" : this.buttonEditPassport.EditValue.ToString();
            if (string.IsNullOrEmpty(passport))
            {
                XtraMessageBox.Show(this.LookAndFeel, "用户名必须填写", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            string password = this.buttonEditPassword.EditValue == null ? "" : this.buttonEditPassword.EditValue.ToString();

            if (string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show(this.LookAndFeel, "密码必须填写", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

    }
}

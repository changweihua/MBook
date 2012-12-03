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

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       LoginForm
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       LoginForm
     * 创建时间:       2012/12/3  17:11:05
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class LoginForm : XtraForm
    {

        #region 全局变量

        private NetDimension.Weibo.OAuth oauth;

        public NetDimension.Weibo.OAuth OOAuth 
        {
            get
            {
                return this.oauth;
            }
        }

        #endregion 全局变量

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(WeiboType weiboType)
            : this()
        {
            string text = string.Empty;

            switch (weiboType)
            {
                case WeiboType.Sina:
                    text = "新浪微博";
                    oauth = new NetDimension.Weibo.OAuth(Properties.Settings.Default.AppKey, Properties.Settings.Default.AppSecret, Properties.Settings.Default.CallbackUrl);
                    break;
                case WeiboType.Tencent:
                    break;
                case WeiboType.Sohu:
                    break;
                case WeiboType.Netease:
                    break;
                default:
                    break;
            }

            InitForm(text);

        }

        public LoginForm(WeiboType weiboType, ref NetDimension.Weibo.OAuth oa)
            : this()
        {
            string text = string.Empty;

            switch (weiboType)
            {
                case WeiboType.Sina:
                    text = "新浪微博";
                    oa = new NetDimension.Weibo.OAuth(Properties.Settings.Default.AppKey, Properties.Settings.Default.AppSecret, Properties.Settings.Default.CallbackUrl);
                    oauth = new NetDimension.Weibo.OAuth(Properties.Settings.Default.AppKey, Properties.Settings.Default.AppSecret, Properties.Settings.Default.CallbackUrl);
                    break;
                case WeiboType.Tencent:
                    break;
                case WeiboType.Sohu:
                    break;
                case WeiboType.Netease:
                    break;
                default:
                    break;
            }

            InitForm(text);

        }


        /// <summary>
        /// 根据不同的微博，显示不同的窗体信息
        /// </summary>
        /// <param name="formText"></param>
        private void InitForm(string formText)
        {
            this.Text = string.Format("{0} ---- 登录", formText);
        }


        /// <summary>
        /// 判断是否已经保存过用户的信息，如果有，读取出来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Passport))
            {
                bePassport.EditValue = Properties.Settings.Default.Passport;
                bePassword.EditValue = Properties.Settings.Default.Password;
                chkRemember.Checked = true;
            }
        }


        /// <summary>
        /// 判断用户操作：登录，重置文本框，关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    //(sender as ButtonEdit).EditValue = "";
                    Login();
                    break;
                case 1:
                    bePassport.EditValue = Properties.Settings.Default.Passport;
                    bePassword.EditValue = Properties.Settings.Default.Password;
                    break;
                case 2:
                    this.Close();
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// 清空输入框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bePassport_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    (sender as ButtonEdit).EditValue = "";
                    break;
                default:
                    break;
            }
        }

        private void Login()
        {
            string passport = bePassport.EditValue == null ? "" : bePassport.EditValue.ToString();
            if (string.IsNullOrEmpty(passport))
            {
                MessageBox.Show(this, "请输入登录密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //acError.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.FadeIn;
                //acError.Show(this, "Error", "请输入登录账号");
                return;
            }

            string password = bePassword.EditValue == null ? "" : bePassword.EditValue.ToString();
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(this, "请输入登录密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            mpbcLoginStatus.Visible = true;

            //新建一个线程进行登录
            Thread threadLogin = new Thread(new ThreadStart(() =>
            {
                try
                {
                    bool result = oauth.ClientLogin(passport, password);
                    NetDimension.Weibo.TokenResult tokenResult = oauth.VerifierAccessToken();

                    if (tokenResult == NetDimension.Weibo.TokenResult.Success)
                    {
                        UILoginComplete(result, "登录成功");
                    }
                    else
                    {
                        UILoginComplete(result, tokenResult.ToString());
                    }

                }
                catch (Exception ex)
                {
                    UILoginComplete(false, ex.Message);
                }
            }));

            threadLogin.Start();

        }

        private void Login(NetDimension.Weibo.OAuth oa)
        {
            string passport = bePassport.EditValue == null ? "" : bePassport.EditValue.ToString();
            if (string.IsNullOrEmpty(passport))
            {
                MessageBox.Show(this, "请输入登录密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //acError.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.FadeIn;
                //acError.Show(this, "Error", "请输入登录账号");
                return;
            }

            string password = bePassword.EditValue == null ? "" : bePassword.EditValue.ToString();
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(this, "请输入登录密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            mpbcLoginStatus.Visible = true;

            //新建一个线程进行登录
            Thread threadLogin = new Thread(new ThreadStart(() =>
            {
                try
                {
                    //bool result = oauth.ClientLogin(passport, password);
                    //NetDimension.Weibo.TokenResult tokenResult = oauth.VerifierAccessToken();
                    bool result = oa.ClientLogin(passport, password);
                    NetDimension.Weibo.TokenResult tokenResult = oa.VerifierAccessToken();

                    if (tokenResult == NetDimension.Weibo.TokenResult.Success)
                    {
                        UILoginComplete(result, "登录成功");
                    }
                    else
                    {
                        UILoginComplete(result, tokenResult.ToString());
                    }

                }
                catch (Exception ex)
                {
                    UILoginComplete(false, ex.Message);
                }
            }));

            threadLogin.Start();

        }


        private void UILoginComplete(bool success, string msg)
        {
            if (mpbcLoginStatus.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    UILoginComplete(success, msg);
                }));
            }
            else
            {
                mpbcLoginStatus.Visible = false;
                if (success)
                {
                    if (chkRemember.Checked)
                    {
                        Properties.Settings.Default.Passport = bePassport.EditValue.ToString();
                        Properties.Settings.Default.Password = bePassword.EditValue.ToString();
                    }
                    else
                    {
                        Properties.Settings.Default.Passport = "";
                        Properties.Settings.Default.Password = "";
                    }

                    Properties.Settings.Default.Save();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    //SinaForm sinaForm = new SinaForm();
                    //sinaForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "没有登录成功，请确保账号密码正确。\r\n错误提示：" + msg + "\r\n\r\n当然还要确定Settings里你的AppKey和回调地址是对的。不懂看视频去，不解释。如果出现未审核应用人数达到上限那就去新浪后台把测试账号的UID填到网站测试账号栏目里。", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


    }
}

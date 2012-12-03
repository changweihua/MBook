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
using System.IO;

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       SinaForm
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       SinaForm
     * 创建时间:       2012/12/2  21:58:20
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class SinaForm : XtraForm
    {
        private SinaForm()
        {
            InitializeComponent();
        }

        #region 微博列表的模板
        const string htmlPattern = @"<!DOCTYPE html>
<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">
<head>
	<title></title>
	<style type=""text/css"">
		html, body {
			font-size: 12px;
			cursor: default;
			padding: 5px;
			margin: 0;
			font-family:微软雅黑,Tahoma;
		}

		div.status {
			padding-left: 60px;
			position: relative;
			margin-bottom: 10px;
			min-height:80px;
			_height:80px;
		}

			div.status p {
				margin: 0 0 5px 0;
				line-height: 1.5;
				padding: 0;
			}

				div.status p span.name {
					color: #369;
				}

				div.status p.status-content {
					color: #333;
				}

				div.status p.status-count {
					color:#999;
				}

			div.status .face {
				position: absolute;
				left: 0;
				top: 0;
			}

			div.status div.repost {
				border: solid 1px #ACD;
				background: #F0FAFF;
				padding: 10px 10px 0 10px;
			}

		div.repost p.repost-content {
			color: #666 !important;
		}
	</style>
</head>
<body>
<!--StatusesList-->
</body>
</html>";
        const string imageParttern = @"<img src=""{0}"" alt=""图片"" class=""inner-pic"" />";
        const string statusPattern = @"	<div class=""status"">
		<img src=""{0}"" alt=""{1}"" class=""face"" />
		<p class=""status-content""><span class=""name"">{1}</span>：{2}</p>
		{3}
		<p class=""status-count"">转发({4}) 评论({5})</p>
	</div>
";
        const string repostPattern = @"	<div class=""status"">
		<img src=""{0}"" alt=""{1}"" class=""face"" />
		<p class=""status-content""><span class=""name"">{1}</span>：{2}</p>
		<div class=""repost"">
			<p class=""repost-cotent""><span class=""name"">@{3}</span>：{4}</p>
			{5}
			<p class=""status-count"">转发({6}) 评论({7})</p>
		</div>
		<p class=""status-count"">转发({8}) 评论({9})</p>
	</div>
";
        #endregion 微博列表的模板

        #region 全局变量

        private NetDimension.Weibo.OAuth oauth;
        private NetDimension.Weibo.Client Sina;
        private string UserId = string.Empty;

        private byte[] imageBuffer = null;

        #endregion 全局变量

        public SinaForm(WeiboType weiboType)
            : this()
        {
            if (oauth == null)
            {
                LoginForm loginForm = new LoginForm(weiboType,ref oauth);//貌似ref传引用不是深复制
                if (loginForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    Sina = new NetDimension.Weibo.Client(loginForm.OOAuth);
                    
                }
            }
            
        }


        /// <summary>
        /// 加载用户信息
        /// </summary>
        private void LoadUserInformation()
        {
            Thread threadUserInfo = new Thread(new ThreadStart(() => {
                string userId = Sina.API.Account.GetUID();
                NetDimension.Weibo.Entities.user.Entity userInfo = Sina.API.Users.Show(userId, null);
                UIUpdateUserInfo(userInfo);
            }));

            threadUserInfo.IsBackground = true;
            threadUserInfo.Start();

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int remainCount = 140 - txtSomething.TextLength;
            lcLeftCount.Text = string.Format("您还可以输入 {0} 个字", remainCount);
        }

        private void sbtnSend_Click(object sender, EventArgs e)
        {
            if (txtSomething.TextLength == 0)
            {
                MessageBox.Show(this, "说点什么新鲜事儿呗。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string something = txtSomething.Text;
            PublishStatus(something);

        }

        /// <summary>
        /// 线程方法：发微博
        /// </summary>
        /// <param name="status"></param>
        private void PublishStatus(string status)
        {
            sbtnSend.Enabled = false;
            sbtnSend.Text = "请稍等..";
            txtSomething.ReadOnly = true;

            Thread t = new Thread(new ThreadStart(delegate()
            {
                if (imageBuffer == null)
                {
                    try
                    {
                        Sina.API.Statuses.Update(status, 0, 0, null);
                    }
                    catch (Exception ex)
                    {
                        UIShowInfoMsgBox("哟？！出错了!", ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        Sina.API.Statuses.Upload(status, imageBuffer, 0, 0, null);
                    }
                    catch (Exception ex)
                    {
                        UIShowInfoMsgBox("哟？！出错了!", ex.Message);
                    }
                    finally
                    {
                        imageBuffer = null;

                    }
                }

                UIUpdateOperationInterface();

            }));
            t.IsBackground = true;
            t.Start();
        }

        /// <summary>
        /// 线程方法：加载用户微博
        /// </summary>
        private void LoadFriendTimeline()
        {
            Thread thLoad = new Thread(new ThreadStart(delegate()
            {
                StringBuilder statusBuilder = new StringBuilder();
                NetDimension.Weibo.Entities.status.Collection json = Sina.API.Statuses.FriendsTimeline("0", "0", 20, 1, false, 0);
                if (json.Statuses != null)
                {
                    foreach (NetDimension.Weibo.Entities.status.Entity status in json.Statuses)
                    {
                        if (status.User == null)
                            continue;

                        if (status.RetweetedStatus != null && status.RetweetedStatus.User != null)
                        {
                            statusBuilder.AppendFormat(repostPattern,
                                status.User.ProfileImageUrl,
                                status.User.ScreenName,
                                status.Text,
                                status.RetweetedStatus.User.ScreenName,
                                status.RetweetedStatus.Text,
                                string.IsNullOrEmpty(status.RetweetedStatus.ThumbnailPictureUrl) ? "" :
                                string.Format(imageParttern, status.RetweetedStatus.ThumbnailPictureUrl),
                                status.RetweetedStatus.RepostsCount,
                                status.RetweetedStatus.CommentsCount,
                                status.RepostsCount, status.CommentsCount);

                        }
                        else
                        {
                            statusBuilder.AppendFormat(statusPattern,
                                status.User.ProfileImageUrl,
                                status.User.ScreenName,
                                status.Text,
                                string.IsNullOrEmpty(status.ThumbnailPictureUrl) ? "" :
                                string.Format(imageParttern, status.ThumbnailPictureUrl),
                                status.RepostsCount, status.CommentsCount);
                        }

                    }
                }

                string html = htmlPattern.Replace("<!--StatusesList-->", statusBuilder.ToString());

                UIUpdateContent(html);
            }));

            thLoad.IsBackground = true;
            thLoad.Start();

        }



        #region 界面线程方法
        /// <summary>
        /// 刷新微博列表
        /// </summary>
        /// <param name="html"></param>
        private void UIUpdateContent(string html)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    UIUpdateContent(html);
                }));
            }
            else
            {
                webBrowser1.DocumentText = html;
            }
        }

        /// <summary>
        /// 刷新用户信息界面
        /// </summary>
        /// <param name="userInfo"></param>
        private void UIUpdateUserInfo(NetDimension.Weibo.Entities.user.Entity userInfo)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    UIUpdateUserInfo(userInfo);
                }));
            }
            else
            {

                lcNickName.Text = userInfo.ScreenName;
                lcDescription.Text = userInfo.Description;
                imgProfile.ImageLocation = userInfo.ProfileImageUrl;
                lcOther.Text = string.Format("关注({0}) 粉丝({1}) 微博({2})", userInfo.FriendsCount, userInfo.FollowersCount, userInfo.StatusesCount);
            }
        }

        /// <summary>
        /// 显示个MsgBox
        /// </summary>
        /// <param name="title"></param>
        /// <param name="txt"></param>
        private void UIShowInfoMsgBox(string title, string txt)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    UIShowInfoMsgBox(title, txt);
                }));
            }
            else
            {
                MessageBox.Show(this, txt, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 刷新操作界面
        /// </summary>
        private void UIUpdateOperationInterface()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    UIUpdateOperationInterface();
                }));
            }
            else
            {
                sbtnSend.Enabled = true;
                sbtnSend.Text = "发表";
                txtSomething.ReadOnly = false;
                txtSomething.Text = string.Empty;
                simpleButton1.Enabled = true;
                LoadFriendTimeline();
            }
        }
        #endregion

        private void SinaForm_Load(object sender, EventArgs e)
        {
            LoadUserInformation();
            LoadFriendTimeline();
        }

        private void btnInsertPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "支持的图片文件|*.jpg;*.jpeg;*.png;*.gif";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                FileInfo imageFile = new FileInfo(dlg.FileName);
                if (imageFile.Exists)
                {
                    using (FileStream stream = imageFile.OpenRead())
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        try
                        {
                            stream.Seek(0, SeekOrigin.Begin);
                            imageBuffer = reader.ReadBytes((int)stream.Length);
                        }
                        finally
                        {
                            reader.Close();
                            stream.Close();
                        }
                    }

                    simpleButton1.Enabled = false;

                    MessageBox.Show(this, "图片已附加，发条微博看看吧～", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}

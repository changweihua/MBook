using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetDimension.Weibo;
using System.Threading;

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


        #region 全局变量

        private NetDimension.Weibo.OAuth oauth;
        private NetDimension.Weibo.Client Sina;
        private string UserId = string.Empty;

        private byte[] imageBuffer = null;

        #endregion 全局变量

        public SinaForm(OAuth oauth):this()
        {

        }

        private void LoadUserInformation()
        {
            Thread threadUserInfo = new Thread(new ThreadStart(() => {
                string userId = Sina.API.Account.GetUID();
                NetDimension.Weibo.Entities.user.Entity userInfo = Sina.API.Users.Show(userId, null);

            }));

            threadUserInfo.IsBackground = true;
            threadUserInfo.Start();

        }

    }
}

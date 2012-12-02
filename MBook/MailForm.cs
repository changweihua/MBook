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
    }
}

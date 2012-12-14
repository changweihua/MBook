﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       ProfileForm
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       ProfileForm
     * 创建时间:       2012/12/4 21:18:05
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class ProfileForm : XtraForm
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void barButtonItemCloseWindow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            //检测本地是否已经存在文件夹，不存在，就创建
            //EnterpriseObjects.DirectoryHelper directoryHelper = new EnterpriseObjects.DirectoryHelper();
            //directoryHelper.CreateDirOperate(Properties.Settings.Default.savePath, EnterpriseObjects.OperateOption.ExistReturn);
        }
    }
}

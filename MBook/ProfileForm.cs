using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NLite.Data;
using MonoBookEntity;

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

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemCloseWindow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            //检测本地是否已经存在文件夹，不存在，就创建
            //EnterpriseObjects.DirectoryHelper directoryHelper = new EnterpriseObjects.DirectoryHelper();
            //directoryHelper.CreateDirOperate(Properties.Settings.Default.savePath, EnterpriseObjects.OperateOption.ExistReturn);
            ShowProfile();
        }

        /// <summary>
        /// 显示个人资料
        /// </summary>
        void ShowProfile()
        {
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                Profile profile = ctx.Set<Profile>().SingleOrDefault(p => p.Email == Properties.Settings.Default.UserEmail);

                if (profile == null)
                {
                    XtraMessageBox.Show(this.LookAndFeel, "没有找到“" + Properties.Settings.Default.UserEmail + "”该用户", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    buttonEditEmail.EditValue = profile.Email;
                    buttonEditPassword.EditValue = profile.Password;
                    buttonEditQQ.EditValue = profile.QQ;
                    buttonEditUserName.EditValue = profile.Name;
                    buttonEditVipTypeName.EditValue = profile.VipTypeName;
                    dateEditBirthday.EditValue = profile.Birthday;
                    labelControlWebsite.Text = profile.Website;
                    labelControlSina.Text = profile.Sina;
                    labelControlTencent.Text = profile.Tencent;
                    labelControlFlowUsage.Text = string.Format("{0}/{1} MB ({2:P1})", profile.UsedFlow, profile.Flow, (double)profile.UsedFlow / (double)profile.Flow);
                    labelControlUsedFlow.Location = labelControlFlow.Location;
                    labelControlUsedFlow.Width = Convert.ToInt32(((double)profile.UsedFlow / (double)profile.Flow) * (double)labelControlFlow.Width);
                    labelControlUsedFlow.BackColor = Color.Aqua;
                }

            }
        }

        /// <summary>
        /// 保存个人资料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace MBook
{
    public partial class RichEditTabPage : XtraUserControl
    {
        #region 窗体自身的方法

        public RichEditTabPage()
        {
            InitializeComponent();
        }
        #endregion

        #region 窗体加载

        private void RichEditTabPage_Load(object sender, EventArgs e)
        {
            //if (!CheckNetworkStatus())
            //{
            //    if (XtraMessageBox.Show(this.LookAndFeel, "貌似您没有连接上网络，是否读取本地数据", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            //    {
            //        return;
            //    }
            //}
        }

        #endregion
        
        #region 检测网络状况，决定是读取本地还是网络数据

        /// <summary>
        /// 检测网络状况，决定是读取本地还是网络数据
        /// </summary>
        /// <returns></returns>
        private bool CheckNetworkStatus()
        {
            EnterpriseObjects.NetStatus netStatus = EnterpriseObjects.NetworkHelper.GetConnectionStatus("cmono.net");

            if (netStatus == EnterpriseObjects.NetStatus.None)
            {
                //XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (netStatus == EnterpriseObjects.NetStatus.ModemUnlink)
            {
                //XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (netStatus == EnterpriseObjects.NetStatus.LanCardUnlink)
            {
                //XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        #endregion

    }
}

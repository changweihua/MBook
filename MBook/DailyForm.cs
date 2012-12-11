using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using NLite.Data;
using MonoBookEntity;

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       DailyForm
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       DailyForm
     * 创建时间:       2012/12/2  19:38:03
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class DailyForm : XtraForm
    {

        /// <summary>
        /// Guid标识符
        /// </summary>
        private string guid;
        private Daily daily;

        #region 初始化窗体

        public DailyForm()
        {
            InitializeComponent();
        }

        public DailyForm(string g)
        {
            InitializeComponent();
            guid = g;
        }


        /// <summary>
        /// 判断guid是否为空，如为空，则打开新的，否则加载选中的日记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailyForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guid))
            {
                //读取本地文件
                string filePath = string.Format(@"{0}\My Dailies\{1}.mono", Properties.Settings.Default.savePath, guid);

                if (!EnterpriseObjects.FileHelper.CheckFile(filePath))
                {
                    XtraMessageBox.Show(this.LookAndFeel, "可能出现了点小意外，文件找不到了", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                object obj = EnterpriseObjects.SerializeHelper.Deserialize(EnterpriseObjects.SerializeType.Binary, null, filePath);
                string content = obj == null ? "" : obj.ToString();
                this.richEditControl1.HtmlText = content;
                using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                {
                    daily = ctx.Set<Daily>().Where(d => d.Guid == guid).ElementAt(0);
                }
                barEditIsSecret.EditValue = daily.IsSecret;
                barEditSecret.EditValue = daily.Password;

            }

        }

        #endregion

        #region 工具栏按钮操作

        private void barButtonClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.richEditControl1.ResetText();
        }

        private void barButtonUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.richEditControl1.CanUndo)
            {
                this.richEditControl1.Undo();
            }
        }

        private void barButtonRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.richEditControl1.CanRedo)
            {
                this.richEditControl1.Redo();
            }
        }

        private void barButtonCut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.richEditControl1.Cut();
        }

        private void barButtonCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.richEditControl1.Copy();
        }

        private void barButtonPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.richEditControl1.Paste();
        }

        
        private void barButtonHighlight_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barEditIsSecret_EditValueChanged(object sender, EventArgs e)
        {
            barEditSecret.Enabled = Convert.ToBoolean(this.barEditIsSecret.EditValue);
            if (barEditSecret.Enabled == false)
            {
                barEditSecret.EditValue = "";
            }
        }


        #endregion

        #region 保存日记

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string content = richEditControl1.HtmlText;

            bool isNew = false;

            if (string.IsNullOrEmpty(guid))
            {
                isNew = true;
                guid = Guid.NewGuid().ToString();
            }
            string filePath = string.Format(@"{0}\My Dailies\{1}.mono", Properties.Settings.Default.savePath, guid);
            bool flag = EnterpriseObjects.SerializeHelper.Serialize(EnterpriseObjects.SerializeType.Binary, content, filePath);
            int count=0;
            if (flag)
            {
                using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                {
                    if (isNew)
                    {
                        daily = new MonoBookEntity.Daily
                        {
                            CreateDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:sss"),
                            UpdateDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:sss"),
                            Guid = guid,
                            RecordType = 2,
                            IsSecret = Convert.ToBoolean(this.barEditIsSecret.EditValue),
                            Password = barEditSecret.EditValue == null ? "" : barEditSecret.EditValue.ToString()
                        };
                        count = ctx.Set<MonoBookEntity.Daily>().Insert(daily);
                    }
                    else
                    {
                        daily.UpdateDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:sss");
                        daily.IsSecret = Convert.ToBoolean(this.barEditIsSecret.EditValue);
                        daily.Password = barEditSecret.EditValue == null ? "" : barEditSecret.EditValue.ToString();
                        count = ctx.Set<MonoBookEntity.Daily>().Update(daily);
                    }
                }
                if (count == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }


        #endregion

    }
}

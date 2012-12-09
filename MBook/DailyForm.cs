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
        public DailyForm()
        {
            InitializeComponent();
        }

        private void DailyForm_Load(object sender, EventArgs e)
        {
        }

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

        private void richEditControl1_TextChanged(object sender, EventArgs e)
        {
           
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

    }
}

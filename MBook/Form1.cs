using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars;


namespace MBook
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Form2> forms = new List<Form2>();
        int index = 0;

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.WindowState = FormWindowState.Maximized;
            //f2.MdiParent = this;
            //f2.Show();
            //将所有的MdiChild窗体的状态设为非最大化，否则会抛出异常
            forms.ForEach((form) => { form.WindowState = FormWindowState.Normal; });
            index++;
            string formName = string.Format("Form{0}", index);
            forms.Add(new Form2 { Name = formName, Text = "未命名", WindowState = FormWindowState.Maximized, MdiParent = this });
            forms[forms.Count - 1].Show();
            //MessageBox.Show(forms.Count.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevExpress.Accessibility.AccLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressUtilsLocalizationCHS();
            InitSkinGallary();
            InitSchemaCombo();
            InitStyleCombo();
        }


        #region 初始化窗体信息

        /// <summary>
        /// 初始化皮肤Gallary
        /// </summary>
        void InitSkinGallary()
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        /// <summary>
        /// 初始化所有皮肤
        /// </summary>
        void InitStyleCombo()
        {
            biStyleRepository.Items.Add(new ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1));
            biStyleRepository.Items.Add(new ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1));
            biStyleRepository.Items.Add(new ImageComboBoxItem("MacOffice", RibbonControlStyle.MacOffice, -1));
            biStyle.EditValue = ribbonControl1.RibbonStyle;
        }


        /// <summary>
        /// 初始化结构
        /// </summary>
        private void InitSchemaCombo()
        {
            foreach (object obj in Enum.GetValues(typeof(RibbonControlColorScheme)))
            {
                biSchemaRepository.Items.Add(obj);
            }
            biSchema.EditValue = RibbonControlColorScheme.Blue;
        }

        #endregion 初始化窗体信息
        /// <summary>
        /// 窗体风格下拉框改变时候触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void biStyle_EditValueChanged(object sender, EventArgs e)
        {
            RibbonControlStyle style = (RibbonControlStyle)biStyle.EditValue;
            ribbonControl1.RibbonStyle = style;
            if (style == RibbonControlStyle.Office2010 ||
                style == RibbonControlStyle.MacOffice)
            {
                //ribbonControl1.ApplicationButtonDropDownControl = this.bac
            }
            else
            {
                ribbonControl1.ApplicationButtonDropDownControl = mBookMenu;
            }
            UpdateSchemeCombo();
        }


        /// <summary>
        /// 更新schema
        /// </summary>
        void UpdateSchemeCombo()
        {
            if (ribbonControl1.RibbonStyle == RibbonControlStyle.MacOffice ||
                ribbonControl1.RibbonStyle == RibbonControlStyle.Office2010)
            {
                biSchema.Visibility = this.LookAndFeel.ActiveSkinName.Contains("Office 2010") ? BarItemVisibility.Always : BarItemVisibility.Never;
            }
            else
            {
                biSchema.Visibility = BarItemVisibility.Never;
            }
        }

    }
}

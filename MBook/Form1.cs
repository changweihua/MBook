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
using System.Xml.Linq;
using MonoBookEntity;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraNavBar;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;


namespace MBook
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 全局变量

        List<Form2> forms = new List<Form2>();
        int index = 0;

        #endregion 全局变量

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
            #region 分支3中的方法
            //InitFolderTreeList();
            //folderTreeList.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(folderTreeList_BeforeExpand);
            //folderTreeList.OptionsView.ShowCheckBoxes = false;
            //folderTreeList.OptionsView.ShowButtons = true;
            //folderTreeList.OptionsView.ShowVertLines = true;
            //folderTreeList.OptionsView.ShowHorzLines = true;
            //FillFolderTreeList("folder", "id", "0");

            #endregion 分支3中的方法
            this.ribbonControl1.SelectedPage = ribbonPage1;
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

        #endregion

        #region 分支3中的方法

        /// <summary>
        /// 通过LINQ to XML 动态生成并填充树形菜单
        /// </summary>
        //private void FillFolderTreeList(string nodeName, string attrName,string attrValue)
        //{

        //    string rootPath = System.AppDomain.CurrentDomain.BaseDirectory;
        //    string filePath = rootPath + "Folder.xml";
        //    XElement root = XElement.Load(filePath);
        //    var query = from elem in root.Elements(nodeName)
        //                where (from attr in elem.Attributes()
        //                       where attr.Name.LocalName == attrName
        //                       select attr
        //                        ).Any(id => id.Value == attrValue)
        //                select new Folder { FolderName = elem.Attribute("folderName").Value, FolderPath = elem.Attribute("folderPath").Value, Id = elem.Attribute("id").Value };

        //    IList<Folder> folders = query.ToList();

        //    folderTreeList.Columns.AddRange(new TreeListColumn[] { 
        //        new TreeListColumn{ FieldName="FolderName",VisibleIndex=1, Caption="文件夹列表"}
        //    });

        //    TreeListNode node = null;
        //    foreach (var item in folders)
        //    {
        //        node = folderTreeList.AppendNode(new object[] { item.FolderName }, 0);
        //    }

        //    query = from elem in root.Elements("folder").Elements("folder")
        //            where (from attr in elem.Attributes()
        //                   where attr.Name.LocalName == "id"
        //                   select attr
        //                    ).Any(id => id.Value != "0")
        //            select new Folder { FolderName = elem.Attribute("folderName").Value, FolderPath = elem.Attribute("folderPath").Value, Id = elem.Attribute("id").Value };

        //    folders = query.ToList();
        //    int i = 0, j = 0, k = 0;
        //    foreach (var item in folders)
        //    {
        //        node = folderTreeList.AppendNode(new object[] { item.FolderName }, 0, i++, j++, k++);
        //    }
        //}


        //void folderTreeList_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e)
        //{
        //    MessageBox.Show(e.Node.GetDisplayText(0));
        //}



        #endregion 分支3中的方法

        #region 风格切换下拉框事件

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

        #endregion 风格切换下拉框事件
        

        private void btnAddStickyNote_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        /// <summary>
        /// 搜索按钮的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditSearch_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            ButtonEdit edit = sender as ButtonEdit;
            switch (edit.Properties.Buttons.IndexOf(e.Button))
            {
                case 0:
                    MessageBox.Show("搜索");
                    break;
                case 1:
                    edit.EditValue = "";
                    break;
            }
        }

        private void btnDailyReview_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnGridDaily_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void btnNewContact_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();
        }

        private void btnNewDaily_ItemClick(object sender, ItemClickEventArgs e)
        {
            DailyForm dailyForm = new DailyForm();
            dailyForm.ShowDialog();
        }

        /// <summary>
        /// 退出应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApplicationExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void rgbiSocial_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            //MessageBox.Show(e.Item.Caption + e.Item.Description);
            string desc = e.Item.Description;
            switch (desc)
            {
                case "sina":
                    //SinaForm sinaForm = new SinaForm(WeiboType.Sina);
                    //if (sinaForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    //{
                    //    sinaForm.ShowDialog();
                    //}

                    //MonoBook5 中登录功能的实现
                    LoginForm loginForm = new LoginForm(WeiboType.Sina);
                    if (loginForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        new SinaForm(WeiboType.Sina, loginForm.OOAuth).ShowDialog();
                    }
                    break;
                default:
                    break;
            }
        }

        private void rgbiTools_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            string desc = e.Item.Description;
            switch (desc)
            {
                case "email":
                    new MailForm().ShowDialog();
                    break;
                case "calendar":
                    new MCalendar().ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void btnApplicationAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void barEditItemChooseFolder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnUserProfile_ItemClick(object sender, ItemClickEventArgs e)
        {
            new ProfileForm().ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                this.barEditItemSavePath.EditValue = fdb.SelectedPath;
            }
            fdb = null;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                this.barEditItemBackupPath.EditValue = fdb.SelectedPath;
            }
            fdb = null;
        }

        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            RibbonPage page = (sender as RibbonControl).SelectedPage;
            switch (page.Name)
            {
                case "ribbonPageSetting":
                    InitSettingPage();
                    break;
                default:
                    break;
            }
        }


        private void InitSettingPage()
        {
           this.barEditItemSavePath.EditValue = Properties.Settings.Default.savePath ;
           this.barEditItemBackupPath.EditValue= Properties.Settings.Default.backupPath ;
           this.barEditItemAllowAutoUpdate.EditValue = Properties.Settings.Default.allowUpdate ;
           this.barEditItemAllowUpdateToDevelop.EditValue = Properties.Settings.Default.allowUpdateToBeta ;
        }

        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitSettingPage();
        }

        private void barButtonItemCheckUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(this.LookAndFeel, "已经是最新了，无需更新", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.barEditItemSavePath.EditValue == null || this.barEditItemBackupPath.EditValue == null)
            {
                XtraMessageBox.Show(this.LookAndFeel, "必须要选择文件夹", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Properties.Settings.Default.savePath = this.barEditItemSavePath.EditValue.ToString();
                Properties.Settings.Default.backupPath = this.barEditItemBackupPath.EditValue.ToString();
                Properties.Settings.Default.allowUpdate = (bool)this.barEditItemAllowAutoUpdate.EditValue;
                Properties.Settings.Default.allowUpdateToBeta = (bool)this.barEditItemAllowUpdateToDevelop.EditValue;

                XtraMessageBox.Show(this.LookAndFeel, "保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitSettingPage();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this.LookAndFeel, "保存失败，错误信息\r\n" + ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

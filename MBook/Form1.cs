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
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraNavBar;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using Updater;
using NLite.Data;
using MonoBookEntity;
using System.IO;
using NLite.Dynamic;
using Microsoft.Win32;



namespace MBook
{

    public partial class Form1 : XtraForm
    {
        #region 构造函数

        public Form1()
        {
            InitializeComponent();
        }

        #endregion
       
        #region 全局变量

        List<Form2> forms = new List<Form2>();
        int index = 0;

        #endregion 全局变量

        #region 操作区标签 --> 笔记区

        /// <summary>
        /// 新建桌面便笺
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStickyNote_ItemClick(object sender, ItemClickEventArgs e)
        {
            new StickyNoteForm().Show();
        }


        /// <summary>
        /// 新建笔记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 新建每日回顾
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDailyReview_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        /// <summary>
        /// 新建九宫格日记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGridDaily_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form4 form = new Form4();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FillTreeViewWithGridDaily(new TreeNode { Tag = 3 });
            }
        }

        /// <summary>
        /// 新建联系人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewContact_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            if (contactForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FillTreeViewWithContact(new TreeNode { Tag = 4 });
            }
        }

        /// <summary>
        /// 添加日记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewDaily_ItemClick(object sender, ItemClickEventArgs e)
        {
            DailyForm dailyForm = new DailyForm();
            if (dailyForm.ShowDialog() == DialogResult.OK)
            {
                FillTreeViewWithDaily(new TreeNode { Tag = 6 });
            }
        }

        


        #endregion

        #region 窗体Load事件

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            FillFolderTreeView(null, 0);
           
        }


        #endregion

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
        
        #region 退出程序

        /// <summary>
        /// 退出应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApplicationExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        #endregion

        #region 操作区标签 --> 工具区

        /// <summary>
        /// 工具选择，例如发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rgbiTools_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            string desc = e.Item.Description;
            switch (desc)
            {
                case "email":
                    SendMail();
                    break;
                case "calendar":
                    new MCalendar().ShowDialog();
                    break;
                case "rss":
                    new RssForm().ShowDialog();
                    break;
                default:
                    break;
            }
        }

        void SendMail()
        {
            MailForm mf = new MailForm();
            mf.ShowDialog();
        }


        #endregion

        #region 个人信息区 --> 第三方共享


        /// <summary>
        ///  第三方共享
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rgbiSocial_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {

           EnterpriseObjects.NetStatus netStatus = EnterpriseObjects.NetworkHelper.GetConnectionStatus("weibo.com");
           bool isLinked = true;
            if(netStatus== EnterpriseObjects.NetStatus.None)
            {
                //XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription < EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isLinked = false;
            }
            else if (netStatus == EnterpriseObjects.NetStatus.ModemUnlink)
            {
                //XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isLinked = false;
            }
            else if (netStatus == EnterpriseObjects.NetStatus.LanCardUnlink) 
            {
                //XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isLinked = false;
            }

            if (!isLinked)
            {
                if (XtraMessageBox.Show(this.LookAndFeel, "您没有连接到任何网络，仍然要尝试登录吗", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }

            string desc = e.Item.Description;
            switch (desc)
            {
                case "sina":
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


        #endregion

        #region 左上角菜单按钮

        private void btnApplicationAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void btnUserProfile_ItemClick(object sender, ItemClickEventArgs e)
        {
            new ProfileForm().ShowDialog();
        }


        #endregion

        #region 标签页切换

        /// <summary>
        /// 标签页切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #endregion

        #region 程序设置页操作

        /// <summary>
        /// 切换到设置页的时候，读取配置信息，信息量少， 不使用多线程异步
        /// </summary>
        private void InitSettingPage()
        {
            this.barEditItemSavePath.EditValue = Properties.Settings.Default.SavePath;
            this.barEditItemBackupPath.EditValue = Properties.Settings.Default.BackupPath;
            this.barEditItemAllowAutoUpdate.EditValue = Properties.Settings.Default.AllowUpdate;
            this.barEditItemAllowUpdateToDevelop.EditValue = Properties.Settings.Default.AllowUpdateToBeta;
            //this.barEditItemRunWithSystem.EditValue = Properties.Settings.Default.AutoRun;
            RegistryKey R_local = Registry.LocalMachine;
            RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (R_run.GetValue("MonoBook") == null)
            {
               barEditItemRunWithSystem.EditValue = false;
            }
            else
            {
                barEditItemRunWithSystem.EditValue = true;
            }
            R_run.Close();
            R_local.Close();
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitSettingPage();
        }

        /// <summary>
        /// 保存开机启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemSaveRunWithSystem_ItemClick(object sender, ItemClickEventArgs e)
        {
            string startPath = System.Windows.Forms.Application.ExecutablePath;

            if ((bool)barEditItemRunWithSystem.EditValue)
            {
                RegistryKey r_local = Registry.LocalMachine;
                RegistryKey r_run = r_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                r_run.SetValue("MonoBook", startPath);
                r_run.Close();
                r_local.Close();
            }
            else
            {
                try
                {
                    RegistryKey R_local = Registry.LocalMachine;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.DeleteValue("MonoBook", false);
                    R_run.Close();
                    R_local.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            
        }
       

        /// <summary>
        /// 检查程序更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemCheckUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            //UpdateClass updater = new UpdateClass();
            //bool isComplete = true;
            //List<Updater.Manifest> maniFests = new List<Updater.Manifest>();
            //int mLength = 0;

            XtraMessageBox.Show(this.LookAndFeel, "已经是最新了，无需更新", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 保存程序配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.barEditItemSavePath.EditValue == null || this.barEditItemBackupPath.EditValue == null)
            {
                XtraMessageBox.Show(this.LookAndFeel, "必须要选择文件夹", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Properties.Settings.Default.SavePath = this.barEditItemSavePath.EditValue.ToString();
                Properties.Settings.Default.BackupPath = this.barEditItemBackupPath.EditValue.ToString();
                Properties.Settings.Default.AllowUpdate = (bool)this.barEditItemAllowAutoUpdate.EditValue;
                Properties.Settings.Default.AllowUpdateToBeta = (bool)this.barEditItemAllowUpdateToDevelop.EditValue;
                //Properties.Settings.Default.AutoRun = (bool)this.barEditItemRunWithSystem.EditValue;
                //保存配置
                Properties.Settings.Default.Save();

                XtraMessageBox.Show(this.LookAndFeel, "保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitSettingPage();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this.LookAndFeel, "保存失败，错误信息\r\n" + ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 选择保存途径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                this.barEditItemSavePath.EditValue = fdb.SelectedPath;
            }
            fdb = null;
        }

        /// <summary>
        /// 选择保存途径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                this.barEditItemBackupPath.EditValue = fdb.SelectedPath;
            }
            fdb = null;
        }


        /// <summary>
        /// 同步按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemSync_ItemClick(object sender, ItemClickEventArgs e)
        {
            SyncForm syncForm = new SyncForm();
            syncForm.Show();
        }


        /// <summary>
        /// 备份按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItemBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            BackupForm backupForm = new BackupForm();
            backupForm.Show();
        }

        #endregion

        #region 实现程序托盘功能

        
        /// <summary>
        /// 窗体大小调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "提示";
                notifyIcon1.BalloonTipText = "程序仍在运行,双击图标显示主窗体";
                notifyIcon1.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                this.Hide();
            }

        }

        /// <summary>
        /// 双击托盘图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Maximized;

            // Activate the form.
            this.Show();
            this.ShowInTaskbar = true;
            this.notifyIcon1.Visible = false;
            this.Activate();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm aboutForm = new AboutForm())
            {
                aboutForm.ShowInTaskbar = true;
                aboutForm.ShowDialog();
            }
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEmail_Click(object sender, EventArgs e)
        {
            using (MailForm mailForm = new MailForm())
            {
                mailForm.ShowInTaskbar = true;
                mailForm.ShowDialog();
            }
        }

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiShow_Click(object sender, EventArgs e)
        {
            notifyIcon1_DoubleClick(sender, e);
            //if (this.WindowState == FormWindowState.Minimized)
            //    this.WindowState = FormWindowState.Maximized;

            //// Activate the form.
            //this.Show();
            //this.ShowInTaskbar = true;
            //this.notifyIcon1.Visible = false;
            //this.Activate();
        }


        #endregion

        #region 加载树形列表 == 左上

        /// <summary>
        /// 详细信息列表的右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvResult_MouseClick(object sender, MouseEventArgs e)
        {
            if (tvResult.SelectedNode != null)
            {
                tsmiDelete.Enabled = true;
            }
        }

        /// <summary>
        /// 加载文件夹树形菜单
        /// </summary>
        /// <param name="id">菜单编号</param>
        private void FillFolderTreeView(TreeNode parentNode,int id)
        {
            //MonoBookDBUtil mbd = new MonoBookDBUtil();

            //var query = mbd.Folders.Select(folder => folder.Id == id);

            //XtraMessageBox.Show(query.ToList<Folder>);

            //DbConfiguration cfg = DbConfiguration
            //    .Configure("Mono")//通过connectionStringName对象创建DbConfiguration对象（可以用于配置文件中有多个数据库连接字符串配置）
            //    .AddClass<MonoBookEntity.Index>()//注册实体到数据表的映射关系
            //    ;
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                var query = ctx.Set<Folder>().Where(p => p.parentId == id);

                TreeNode node = null;
                foreach (Folder folder in query.ToList())
                {
                    node = new TreeNode
                    {
                        Text = folder.FolderName,
                        ToolTipText = folder.FolderName,
                        Tag = folder.Id
                    };
                    if (parentNode == null)
                    {
                        tvFolders.Nodes.Add(node);
                        tvFolders.AfterSelect += new TreeViewEventHandler(tvFolders_AfterSelect);
                    }
                    else
                    {
                        parentNode.Nodes.Add(node);
                    }
                    tvResult.ExpandAll();
                }

            }

        }

        /// <summary>
        /// 节点选择之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode parentNode = e.Node;
            if (!string.IsNullOrEmpty(parentNode.Tag.ToString()))
            {
                int index = Convert.ToInt32(parentNode.Tag);
                if (index == 1)
                {
                    FillFolderTreeView(parentNode, Convert.ToInt32(parentNode.Tag));
                }
                else
                {
                    switch (index)
                    {
                        case 2:
                            FillTreeViewWithNote(parentNode);
                            break;
                        case 3:
                            FillTreeViewWithGridDaily(parentNode);
                            break;
                        case 4:
                            FillTreeViewWithContact(parentNode);
                            break;
                        case 6:
                            FillTreeViewWithDaily(parentNode);
                            break;
                        case 7:
                            FillTreeViewWithDailyReview(parentNode);
                            break;
                        case 8:
                            FillTreeViewWithStickyNote(parentNode);
                            break;
                        default:
                            FillTreeViewWithNote(parentNode);
                            break;
                    }

                }
            }
        }

        #endregion

        #region 左侧树形菜单的具体信息 == 左下
        //tvResult.Tag 为左上文件夹的编号
        TreeNode treeNode;

        /// <summary>
        /// 加载日记详细列表
        /// </summary>
        /// <param name="node"></param>
        private void FillTreeViewWithDaily(TreeNode node)
        {
            tvResult.Nodes.Clear();
            tvResult.Tag = node.Tag;
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                var folders = ctx.Set<Folder>().Where(f => f.Id == Convert.ToInt32(node.Tag));

                Folder folder = folders.ElementAt<Folder>(0);

                if (folder != null)
                {
                    var query = ctx.Set<Daily>().Where(d => d.RecordType == folder.RecordTypeId);
                    var dailies = query.ToList();

                    TreeNode n = null;
                    int index = 0;
                    foreach (var item in dailies)
                    {
                        n = new TreeNode
                        {
                            Text = string.Format("{0} ({1})", Convert.ToDateTime(item.CreateDate).ToShortDateString(), (++index).ToString()),
                            Tag = item.Guid,
                            ImageIndex = 0
                        };
                        tvResult.Nodes.Add(n);
                    }
                }

            }
            

        }

        /// <summary>
        /// 加载九宫格日记详细列表
        /// </summary>
        /// <param name="node"></param>
        private void FillTreeViewWithGridDaily(TreeNode node)
        {
            tvResult.Nodes.Clear();
            tvResult.Tag = node.Tag;
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                var folders = ctx.Set<Folder>().Where(f => f.Id == Convert.ToInt32(node.Tag));

                Folder folder = folders.ElementAt<Folder>(0);

                if (folder != null)
                {
                    var query = ctx.Set<GridDaily>().Where(g => g.RecordType == folder.RecordTypeId);
                    var dailies = query.ToList();

                    TreeNode n = null;
                    int index = 0;
                    foreach (var item in dailies)
                    {
                        n = new TreeNode
                        {
                            Text = string.Format("{0} ({1})", Convert.ToDateTime(item.CreateDate).ToShortDateString(), (++index).ToString()),
                            Tag = item.Guid,
                            ImageIndex = 0
                        };
                        tvResult.Nodes.Add(n);
                    }
                }

            }


        }

        /// <summary>
        /// 加载联系人详细列表
        /// </summary>
        /// <param name="node"></param>
        private void FillTreeViewWithContact(TreeNode node)
        {
            tvResult.Nodes.Clear();
            tvResult.Tag = node.Tag;
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                var folders = ctx.Set<Folder>().Where(f => f.Id == Convert.ToInt32(node.Tag));

                Folder folder = folders.ElementAt<Folder>(0);

                if (folder != null)
                {
                    var query = ctx.Set<Contact>().Where(c => c.RecordType == folder.RecordTypeId);
                    var contacts = query.ToList();

                    TreeNode n = null;
                    foreach (var item in contacts)
                    {
                        n = new TreeNode
                        {
                            Text = string.Format("< {0} > 的名片", item.Name),
                            Tag = item.Guid,
                            ImageIndex = 1
                        };
                        tvResult.Nodes.Add(n);
                    }
                }

            }
        }

        /// <summary>
        /// 加载每日回顾详细列表
        /// </summary>
        /// <param name="node"></param>
        private void FillTreeViewWithDailyReview(TreeNode node)
        {
            tvResult.Nodes.Clear();
            tvResult.Tag = node.Tag;
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                var folders = ctx.Set<Folder>().Where(f => f.Id == Convert.ToInt32(node.Tag));

                Folder folder = folders.ElementAt<Folder>(0);

                if (folder != null)
                {
                    var query = ctx.Set<DailyReview>().Where(d => d.RecordType == folder.RecordTypeId);
                    var dailyReviews = query.ToList();

                    TreeNode n = null;
                    int index = 0;
                    foreach (var item in dailyReviews)
                    {
                        n = new TreeNode
                        {
                            Text = string.Format("< {0} > ({1})", item.CreateDate, ++index),
                            Tag = item.Guid,
                            ImageIndex = 2
                        };
                        tvResult.Nodes.Add(n);
                    }
                }

            }
        }

        /// <summary>
        /// 加载桌面便笺详细列表
        /// </summary>
        /// <param name="node"></param>
        private void FillTreeViewWithStickyNote(TreeNode node)
        {
            tvResult.Nodes.Clear();
            tvResult.Tag = node.Tag;
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                var folders = ctx.Set<Folder>().Where(f => f.Id == Convert.ToInt32(node.Tag));

                Folder folder = folders.ElementAt<Folder>(0);

                if (folder != null)
                {
                    var query = ctx.Set<StickyNote>().Where(s => s.RecordType == folder.RecordTypeId);
                    var dailyReviews = query.ToList();

                    TreeNode n = null;
                    int index = 0;
                    foreach (var item in dailyReviews)
                    {
                        n = new TreeNode
                        {
                            Text = string.Format("< {0} > ({1})", Convert.ToDateTime(item.UpdateDate).ToShortDateString(), ++index),
                            Tag = item.Guid,
                            ImageIndex = 4
                        };
                        tvResult.Nodes.Add(n);
                    }
                }

            }
        }

        /// <summary>
        /// 加载笔记详细列表
        /// </summary>
        /// <param name="node"></param>
        private void FillTreeViewWithNote(TreeNode node)
        {
            tvResult.Nodes.Clear();
            tvResult.Tag = node.Tag;
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                var folders = ctx.Set<Folder>().Where(f => f.Id == Convert.ToInt32(node.Tag));

                Folder folder = folders.ElementAt<Folder>(0);

                if (folder != null)
                {
                    var query = ctx.Set<Note>().Where(n => n.RecordType == folder.RecordTypeId);
                    var notes = query.ToList();

                    TreeNode tn = null;
                    foreach (var item in notes)
                    {
                        tn = new TreeNode
                        {
                            Text = string.Format("< {0} > ", item.Title),
                            Tag = item.Guid,
                            ImageIndex = 5
                        };
                        tvResult.Nodes.Add(tn);
                    }
                }

            }
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            treeNode = tvResult.SelectedNode;
            if (treeNode != null)
            {
                using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                {
                    string type = tvResult.Tag.ToString();//Folder Id
                    string targetFolder = string.Empty;
                    string sourceFolder=string.Empty;
                    switch (type)
                    {
                        case "2":
                            sourceFolder = string.Format(@"{0}\My Notes", Properties.Settings.Default.SavePath);
                            targetFolder = string.Format(@"{0}\Deleted Items", Properties.Settings.Default.SavePath);
                            if (RemoveFile(treeNode.Tag.ToString(), sourceFolder, targetFolder))
                            {
                                ctx.Set<Note>().Delete(n => n.Guid == treeNode.Tag.ToString());
                                ctx.Set<Index>().Delete(i => i.Guid == treeNode.Tag.ToString());
                                FillTreeViewWithNote(new TreeNode { Tag = type });
                                this.btnEditSearch.EditValue = "";
                            }
                            break;
                        case "3":
                            sourceFolder = string.Format(@"{0}\My GridDailies", Properties.Settings.Default.SavePath);
                            targetFolder = string.Format(@"{0}\Deleted Items", Properties.Settings.Default.SavePath);
                            if (RemoveFile(treeNode.Tag.ToString(), sourceFolder, targetFolder))
                            {
                                ctx.Set<GridDaily>().Delete(g => g.Guid == treeNode.Tag.ToString());
                                FillTreeViewWithGridDaily(new TreeNode { Tag = type });
                            }
                            break;
                        case "4":
                            sourceFolder = string.Format(@"{0}\My Contacts", Properties.Settings.Default.SavePath);
                            targetFolder = string.Format(@"{0}\Deleted Items", Properties.Settings.Default.SavePath);
                            if (RemoveFile(treeNode.Tag.ToString(), sourceFolder, targetFolder))
                            {
                                ctx.Set<Contact>().Delete(c => c.Guid == treeNode.Tag.ToString());
                                FillTreeViewWithContact(new TreeNode { Tag = type });
                            }
                            break;
                        case "6":
                            sourceFolder = string.Format(@"{0}\My Dailies", Properties.Settings.Default.SavePath);
                            targetFolder = string.Format(@"{0}\Deleted Items", Properties.Settings.Default.SavePath);
                            if (RemoveFile(treeNode.Tag.ToString(), sourceFolder, targetFolder))
                            {
                                ctx.Set<Daily>().Delete(d => d.Guid == treeNode.Tag.ToString());
                                FillTreeViewWithDaily(new TreeNode { Tag = type });
                            }
                            break;
                        case "7":
                            sourceFolder = string.Format(@"{0}\My DailyReviews", Properties.Settings.Default.SavePath);
                            targetFolder = string.Format(@"{0}\Deleted Items", Properties.Settings.Default.SavePath);
                            if (RemoveFile(treeNode.Tag.ToString(), sourceFolder, targetFolder))
                            {
                                ctx.Set<DailyReview>().Delete(d => d.Guid == treeNode.Tag.ToString());
                                FillTreeViewWithDailyReview(new TreeNode { Tag = type });
                            }
                            break;
                        case "8":
                            sourceFolder = string.Format(@"{0}\My StickyNotes", Properties.Settings.Default.SavePath);
                            targetFolder = string.Format(@"{0}\Deleted Items", Properties.Settings.Default.SavePath);
                            if (RemoveFile(treeNode.Tag.ToString(), sourceFolder, targetFolder))
                            {
                                ctx.Set<StickyNote>().Delete(s => s.Guid == treeNode.Tag.ToString());
                                FillTreeViewWithStickyNote(new TreeNode { Tag = type });
                            }
                            break;
                        default:
                            break;
                    }
                    
                }
            }
        }

        /// <summary>
        /// 双击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvResult_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Folder Id
            string type = tvResult.Tag.ToString();
            //XtraMessageBox.Show(type);
            switch (type)
            {
                case "2":
                    Form2 form2 = new Form2(e.Node.Tag.ToString());
                    if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        form2.Close();
                    }
                    break;
                case "3":
                    Form4 form4 = new Form4(e.Node.Tag.ToString());
                    if (form4.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        form4.Close();
                    }
                    break;
                case "4":
                    ContactForm cf =new ContactForm(e.Node.Tag.ToString());
                    if (cf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        cf.Close();
                    }
                    break;
                case "6":
                    if (new DailyForm(e.Node.Tag.ToString()).ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                    }
                    break;
                case "7":
                    if (new Form3(e.Node.Tag.ToString()).ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                    }
                    break;
                case "8":
                    new StickyNoteForm(e.Node.Tag.ToString()).Show();
                    break;
                default:
                    break;
            }
        }


        #endregion

        #region 保持任何时刻只显示一个NavBarGroup

        /// <summary>
        /// 任何时刻保持一个展开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarGroup_ItemChanged(object sender, EventArgs e)
        {
            //NavBarGroup nbg = sender as NavBarGroup;
            //NavBarGroupControlContainer nbgcc  =null;
            //foreach (var item in navBarControl2.Controls)
            //{
            //    if (item is NavBarGroupControlContainer)
            //    {
            //        nbgcc = item as NavBarGroupControlContainer;
            //        ////XtraMessageBox.Show(nbgcc.OwnerGroup.Name);
            //        nbgcc.OwnerGroup.Expanded = !nbgcc.OwnerGroup.Expanded;
            //        //if (nbgcc.OwnerGroup.Name == nbg.Name)
            //        //{
            //        //    nbgcc.OwnerGroup.Expanded = true;
            //        //}
            //        // (item as NavBarGroupControlContainer).OwnerGroup.Expanded = false;
            //    }
            //}
            ////nbg.Expanded = true;

        }

        #endregion
        
        #region 搜索功能 

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
                    if (edit.EditValue == null)
                    {
                        XtraMessageBox.Show(this.LookAndFeel, "亲，您总得写点啥吧\r\n这样让人家好为难啊", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        Search(edit.EditValue.ToString());
                    }
                    break;
                case 1:
                    edit.EditValue = "";
                    break;
            }
        }

        /// <summary>
        /// 搜索
        /// </summary>
        void Search(string keyword)
        {
            //var item1 = new Filter
            //{
            //    Field = "Title",
            //    Operation = OperationType.Contains,
            //    Value = keyword,
            //    OrGroup = "a"
            //};
            //var item2 = new Filter
            //{
            //    Field = "Tag",
            //    Operation = OperationType.Contains,
            //    Value = keyword,
            //    OrGroup = "a"
            //};


            String field = "title";

            Lucene.Net.Index.IndexReader reader = Lucene.Net.Index.IndexReader.Open(Lucene.Net.Store.FSDirectory.Open(new DirectoryInfo(Properties.Settings.Default.SavePath + @"\Index")), true);

           Lucene.Net.Search.Searcher searcher = new Lucene.Net.Search.IndexSearcher(reader);
           Lucene.Net.Analysis.Analyzer analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

            Lucene.Net.QueryParsers.QueryParser parser = new Lucene.Net.QueryParsers.QueryParser(Lucene.Net.Util.Version.LUCENE_30, field, analyzer);

            Lucene.Net.Search.Query query1 = parser.Parse(keyword.Trim());

            Lucene.Net.Search.TopScoreDocCollector collector = Lucene.Net.Search.TopScoreDocCollector.Create(searcher.MaxDoc, false);
            searcher.Search(query1, collector);
            Lucene.Net.Search.ScoreDoc[] hits = collector.TopDocs().ScoreDocs;

            MessageBox.Show(this, "共 " + collector.TotalHits.ToString() + " 条记录");
            return;
            var item1 = new Filter
            {
                Field = "Title",
                Operation = OperationType.Like,
                Value = "*" + keyword + "*",
                OrGroup = "a"
            };
            var item2 = new Filter
            {
                Field = "Tag",
                Operation = OperationType.Like,
                Value = "*" + keyword + "*",
                OrGroup = "a"
            };

            var sm = new QueryModel();
            sm.AddRange(new[]{item1,item2});
             List<Note> notes = null;
            using (var ctx =  DbConfiguration.Items["Mono"].CreateDbContext())
            {
                IQueryable<Note> query = ctx.Set<Note>().AsQueryable();
                //IQueryable<Note> actual = query.Where(n => n.Title.ToLower().Contains(keyword.ToLower()) || n.Tag.ToLower().Contains(keyword.ToLower()));
                IQueryable<Note> actual = query.Where(sm);
                notes = actual.ToList<Note>();

            }

            if (notes.Count == 0)
            {
                XtraMessageBox.Show(this.LookAndFeel, "亲，抱歉哦\r\n没能为您找到任何关于“" + keyword + "”文件", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tvResult.Nodes.Clear();
            tvResult.Tag = 2;
            TreeNode tn = null;
            foreach (var item in notes)
            {
                tn = new TreeNode
                {
                    Text = string.Format("< {0} > ", item.Title),
                    Tag = item.Guid,
                    ImageIndex = 5
                };
                tvResult.Nodes.Add(tn);
            }
            //tvResult.NodeMouseDoubleClick -= tvResult_NodeMouseDoubleClick;
        }

        /// <summary>
        /// 当输入框处于激活状态时，监听键盘事件，回车，启动搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEditSearch_ButtonPressed(this.btnEditSearch, new ButtonPressedEventArgs(this.btnEditSearch.Properties.Buttons[0]));
                //MessageBox.Show("你敲回车了");  
            }
        }

        
        #endregion

        #region 文件夹操作方法

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private bool DeleteFile(string filePath)
        {
            bool flag = false;

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    flag = true;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(this.LookAndFeel, "出错:\r\n" + ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }


        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="sourceFolder">原文件夹</param>
        /// <param name="targetFolder">目的文件夹</param>
        /// <returns></returns>
        private bool RemoveFile(string fileName, string sourceFolder, string targetFolder)
        {
            bool flag = false;
            EnterpriseObjects.DirectoryHelper directoryHelper = new EnterpriseObjects.DirectoryHelper();
            directoryHelper.CreateDirOperate(targetFolder, EnterpriseObjects.OperateOption.ExistReturn);
            string source = string.Format(@"{0}\{1}.mono", sourceFolder, fileName);
            string target = string.Format(@"{0}\{1}.mono", targetFolder, fileName);
            if (File.Exists(source))
            {
                try
                {
                    //File.Create(target);
                    File.Move(source, target);
                    flag = true;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(this.LookAndFeel, "出错:\r\n" + ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        #endregion

        #region 插入已删除表

        void Insert()
        {
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {

            }
        }

        #endregion

        private void barButtonItemCreateIndex_ItemClick(object sender, ItemClickEventArgs e)
        {

            //检测本地是否已经存在索引文件夹 ，不存在，就创建
            EnterpriseObjects.DirectoryHelper directoryHelper = new EnterpriseObjects.DirectoryHelper();
            directoryHelper.CreateDirOperate(Properties.Settings.Default.SavePath + @"\Index", EnterpriseObjects.OperateOption.ExistReturn);

            IEnumerable<Note> notes = null;

            using (var db = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                notes = db.Set<Note>().ToList();
            }

            Lucene.Net.Index.IndexWriter writer = new Lucene.Net.Index.IndexWriter(Lucene.Net.Store.FSDirectory.Open(new DirectoryInfo(Properties.Settings.Default.SavePath + @"\Index")), new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30), true, Lucene.Net.Index.IndexWriter.MaxFieldLength.LIMITED);

            foreach (var note in notes)
            {
                CreateIndex(writer, note.Title, note.Content);

            }
            writer.Optimize();
            writer.Dispose();
        }

        private void CreateIndex(Lucene.Net.Index.IndexWriter writer, string a, string b)
        {
            Lucene.Net.Documents.Document doc = new Lucene.Net.Documents.Document();
            doc.Add(new Lucene.Net.Documents.Field("title", a,  Lucene.Net.Documents.Field.Store.YES,  Lucene.Net.Documents.Field.Index.ANALYZED));
            doc.Add(new Lucene.Net.Documents.Field("content", b,  Lucene.Net.Documents.Field.Store.YES,  Lucene.Net.Documents.Field.Index.ANALYZED));

            writer.AddDocument(doc);
            writer.Commit();
        }


       
    }
}

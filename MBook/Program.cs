using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Threading;
using System.Runtime.InteropServices;
using DevExpress.XtraEditors;
using NLite.Data;

namespace MBook
{
    static class Program
    {

        #region 调用DLL

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string className, string title);

        [DllImport("user32.dll")]
        public static extern void SetForegroundWindow(IntPtr hwnd);

        #endregion


        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            DbConfiguration cfg = DbConfiguration
               .Configure("Mono")//通过connectionStringName对象创建DbConfiguration对象（可以用于配置文件中有多个数据库连接字符串配置）
                //.AddClass<MonoBookEntity.Index>()//注册实体到数据表的映射关系
               .AddClass<MonoBookEntity.Index>(p =>
               {
                   p.TableName("tbIndex");
                   p.Id(q => q.Id).DbGenerated().ColumnName("i_id");
                   p.Column(q => q.Guid).ColumnName("i_guid");
                   p.Column(q => q.TypeId).ColumnName("i_type_id");
               })
               .AddClass<MonoBookEntity.Folder>()
               .AddClass<MonoBookEntity.Daily>()
               .AddClass<MonoBookEntity.Contact>()
               .AddClass<MonoBookEntity.DailyReview>()
                .AddClass<MonoBookEntity.GridDaily>()
                .AddClass<MonoBookEntity.StickyNote>()
                .AddClass<MonoBookEntity.Note>()
                .AddClass<MonoBookEntity.Profile>()
                .AddClass<MonoBookEntity.Event>()
                .AddClass<MonoBookEntity.UserScheduler>()
                .AddClass<MonoBookEntity.RssResource>()
               ;
               //.AddClass<MonoBookEntity.Folder>(p =>
               //{
               //    p.TableName("tbFolder");
               //    p.Id(q => q.Id).DbGenerated().ColumnName("f_id");
               //    p.Column(q => q.parentId).ColumnName("f_parent_id");
               //    p.Column(q => q.FolderName).ColumnName("f_display_name");
               //    p.Column(q => q.FolderPath).ColumnName("f_name");
               //});
            using (var ctx = cfg.CreateDbContext())
            {
                var q = ctx.Set<MonoBookEntity.Index>();
                var mapping = q.Entity;
            }

            #region 单例


            #endregion

            #region 注册皮肤

            BonusSkins.Register();
            OfficeSkins.Register();
            SkinManager.EnableFormSkins();

            #endregion

            #region 汉化包注册

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CHS");
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("zh-CHS");


            DevExpress.Accessibility.AccLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressUtilsLocalizationCHS();
            DevExpress.XtraBars.Localization.BarLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraBarsLocalizationCHS();
            // DevExpress.XtraCharts.Localization.ChartLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraChartsLocalizationCHS();
            DevExpress.XtraEditors.Controls.Localizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraEditorsLocalizationCHS();
            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraGridLocalizationCHS();
            DevExpress.XtraLayout.Localization.LayoutLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraLayoutLocalizationCHS();
            DevExpress.XtraNavBar.NavBarLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraNavBarLocalizationCHS();
            // DevExpress.XtraPivotGrid.Localization.PivotGridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraPivotGridLocalizationCHS();
            DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraPrintingLocalizationCHS();
            // DevExpress.XtraReports.Localization.ReportLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraReportsLocalizationCHS();
            DevExpress.XtraRichEdit.Localization.XtraRichEditLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraRichEditLocalizationCHS();
            DevExpress.XtraRichEdit.Localization.RichEditExtensionsLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraRichEditExtensionsLocalizationCHS();
            DevExpress.XtraScheduler.Localization.SchedulerLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSchedulerLocalizationCHS();
            DevExpress.XtraScheduler.Localization.SchedulerExtensionsLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSchedulerExtensionsLocalizationCHS();
            //   DevExpress.XtraSpellChecker.Localization.SpellCheckerLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSpellCheckerLocalizationCHS();
            DevExpress.XtraTreeList.Localization.TreeListLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraTreeListLocalizationCHS();
            DevExpress.XtraVerticalGrid.Localization.VGridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraVerticalGridLocalizationCHS();
            //  DevExpress.XtraWizard.Localization.WizardLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraWizardLocalizationCHS();


            #endregion

            #region 注释掉的方法

            //取消登录程序验证
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //SystemLoginForm loginForm = new SystemLoginForm();
            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new Form1());
            //}

            #endregion

            #region 初始化资源窗体，根据初始化结果判断是否显示主窗体

            InitForm initForm = new InitForm();
            if (initForm.ShowDialog() == DialogResult.OK)
            {
                //bool mutexWasCreated;

                //Mutex mutex = new Mutex(true, "Mutex", out mutexWasCreated);

                //if (!mutexWasCreated)
                //{
                Application.Run(new Form1());
                //}
                //else
                //{
                //    XtraMessageBox.Show("程序已经在运行了");
                //}
                //mutex.ReleaseMutex();
            }

            #endregion

        }
    }
}

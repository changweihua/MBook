using System;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using NLite.Data;
using MonoBookEntity;
using System.Windows.Forms;

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       Form3
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       Form3
     * 创建时间:       2012/12/2 14:18:37
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class Form3 : XtraForm
    {

        #region 全局变量

        MonoBookEntity.DailyReview dailyReview;

        #endregion

        #region 窗体构造

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string guid)
        {
            InitializeComponent();
            this.Tag = guid;
        }

        #endregion

        #region 窗体公共方法

        /// <summary>
        /// 检查窗体
        /// </summary>
        private bool CheckForm()
        {
            var groupControls = this.Controls.Find("groupControl1", false);

            if (groupControls.Length > 0)
            {

                var collection1 = groupControls[0].Controls;

                for (int i = 0; i < collection1.Count; i++)
                {
                    if (collection1[i].GetType().Name == "TextEdit")
                    {
                        if ((collection1[i] as TextEdit).EditValue == null)
                        {
                            XtraMessageBox.Show(this.LookAndFeel, "必须填写", "信息提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else if (collection1[i].GetType().Name == "DateEdit")
                    {
                        if ((collection1[i] as DateEdit).EditValue == null)
                        {
                            XtraMessageBox.Show(this.LookAndFeel, "必须填写", "信息提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else if (collection1[i].GetType().Name == "TimeEdit")
                    {
                        if ((collection1[i] as TimeEdit).EditValue == null)
                        {
                            XtraMessageBox.Show(this.LookAndFeel, "必须填写", "信息提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else if (collection1[i].GetType().Name == "MemoEdit")
                    {
                        if ((collection1[i] as MemoEdit).EditValue == null)
                        {
                            XtraMessageBox.Show(this.LookAndFeel, "必须填写", "信息提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }


            return true;
        }


        /// <summary>
        /// 设置窗体只读
        /// </summary>
        private void SetFormReadonly()
        {
            var groupControls = this.Controls.Find("groupControl1", false);

            if (groupControls.Length > 0)
            {

                var collection1 = groupControls[0].Controls;

                for (int i = 0; i < collection1.Count; i++)
                {
                    if (collection1[i].GetType().Name == "TextEdit")
                    {
                        (collection1[i] as TextEdit).Properties.ReadOnly = true;
                    }
                    else if (collection1[i].GetType().Name == "DateEdit")
                    {
                        (collection1[i] as DateEdit).Properties.ReadOnly = true;
                    }
                    else if (collection1[i].GetType().Name == "TimeEdit")
                    {
                        (collection1[i] as TimeEdit).Properties.ReadOnly = true;
                    }
                    else if (collection1[i].GetType().Name == "MemoEdit")
                    {
                        (collection1[i] as MemoEdit).Properties.ReadOnly = true;
                    }
                }
            }

        }

        #endregion

        #region 按钮

        /// <summary>
        /// 操作按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = e.Button.Index;

            switch (index)
            {
                case 0:
                    SaveDailyReview();
                    break;
                case 1:
                    this.Close();
                    break;
                default:
                    break;
            }

        }

        #endregion

        #region 操作，改，查

        /// <summary>
        /// 保存每日回顾
        /// </summary>
        private void SaveDailyReview()
        {
            if (!CheckForm())
            {
                return;
            }

            SetFormReadonly();
            mpbcStatus.Location = buttonEditAction.Location;
            buttonEditAction.Visible = false;
            mpbcStatus.Visible = true;

            //得到实例
            if (this.Tag == null)
            {
                dailyReview = new MonoBookEntity.DailyReview
                {
                    Guid = Guid.NewGuid().ToString(),
                    CommemorationDay = textEditCommemorationDay.EditValue.ToString(),
                    FortuneDay = textEditFortuneDay.EditValue.ToString(),
                    Inspiration = memoEditInspiration.EditValue.ToString(),
                    MeetionDay = textEditMeetionDay.EditValue.ToString(),
                    TodayBooksMajored = memoEditTodayBooksMajored.EditValue.ToString(),
                    TodayBooksNotMajored = memoEditTodayBooksNotMajored.EditValue.ToString(),
                    TodayDate = dateEditTodayDate.EditValue.ToString(),
                    TodayDescrption = textEditTodayDesc.EditValue.ToString(),
                    TodayGains = memoEditTodayGains.EditValue.ToString(),
                    TodayGetupTime = timeEditTodayGetupTime.EditValue.ToString(),
                    TodayMood = textEditTodayMood.EditValue.ToString(),
                    TodayWeather = textEditTodayWeather.EditValue.ToString(),
                    YesterdayProgress = memoEditYesterdayProgress.EditValue.ToString(),
                    YesterdayShortage = memoEditYesterdayShortage.EditValue.ToString(),
                    YesterdaySleepTime = timeEditYesterdaySleepTime.EditValue.ToString(),
                    CreateDate = DateTime.Now.ToShortDateString(),
                    RecordType = 4
                };
            }
            else
            {
                dailyReview = new MonoBookEntity.DailyReview
                {
                    Guid = this.Tag.ToString(),
                    CommemorationDay = textEditCommemorationDay.EditValue.ToString(),
                    FortuneDay = textEditFortuneDay.EditValue.ToString(),
                    Inspiration = memoEditInspiration.EditValue.ToString(),
                    MeetionDay = textEditMeetionDay.EditValue.ToString(),
                    TodayBooksMajored = memoEditTodayBooksMajored.EditValue.ToString(),
                    TodayBooksNotMajored = memoEditTodayBooksNotMajored.EditValue.ToString(),
                    TodayDate = dateEditTodayDate.EditValue.ToString(),
                    TodayDescrption = textEditTodayDesc.EditValue.ToString(),
                    TodayGains = memoEditTodayGains.EditValue.ToString(),
                    TodayGetupTime = timeEditTodayGetupTime.EditValue.ToString(),
                    TodayMood = textEditTodayMood.EditValue.ToString(),
                    TodayWeather = textEditTodayWeather.EditValue.ToString(),
                    YesterdayProgress = memoEditYesterdayProgress.EditValue.ToString(),
                    YesterdayShortage = memoEditYesterdayShortage.EditValue.ToString(),
                    YesterdaySleepTime = timeEditYesterdaySleepTime.EditValue.ToString()
                };
            }

            string filePath = string.Format(@"{0}\My DailyReviews\{1}.mono", Properties.Settings.Default.SavePath, dailyReview.Guid);

            //序列化开始

            bool flag = EnterpriseObjects.SerializeHelper.Serialize(EnterpriseObjects.SerializeType.Binary, dailyReview, filePath);

            //序列化结束

            //数据库操作开始
            
            int count = 0;
            if (this.Tag == null)
            {
                using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                {
                    count = ctx.Set<MonoBookEntity.DailyReview>().Insert(dailyReview);
                }
            }
            else
            {
                using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                {
                    count = ctx.Set<MonoBookEntity.DailyReview>().Update(dailyReview);
                }
            }
            //数据库操作结束

            if (count == 1)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }

           
        }

        #endregion


        #region 废弃的方法

        void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion


        #region 显示每日回顾

        void ShowDailyReview()
        { 
            //读取Sqlite
            string guid = this.Tag.ToString();

            //using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            //{
            //    //var query = ctx.Set<DailyReview>().Where((da) =>{ da.Guid == guid});
            //}

            //读取本地
            string filePath = string.Format(@"{0}\My DailyReviews\{1}.mono", Properties.Settings.Default.SavePath, guid);

            //检测本地文件是否存在
            if (!EnterpriseObjects.FileHelper.CheckFile(filePath))
            {
                XtraMessageBox.Show(this.LookAndFeel, "可能出现了点小意外，文件找不到了", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dailyReview = new DailyReview();
            object obj = EnterpriseObjects.SerializeHelper.Deserialize(EnterpriseObjects.SerializeType.Binary, dailyReview.GetType(), filePath);

            dailyReview = obj as DailyReview;

            if (dailyReview != null)
            {
                this.textEditCommemorationDay.EditValue = dailyReview.CommemorationDay;
                this.textEditFortuneDay.EditValue = dailyReview.FortuneDay;
                this.textEditMeetionDay.EditValue = dailyReview.MeetionDay;
                this.textEditTodayDesc.EditValue = dailyReview.TodayDescrption;
                this.textEditTodayMood.EditValue = dailyReview.TodayMood;
                this.textEditTodayWeather.EditValue = dailyReview.TodayWeather;
                this.dateEditTodayDate.EditValue = dailyReview.TodayDate;
                this.memoEditInspiration.EditValue = dailyReview.Inspiration;
                this.memoEditTodayBooksMajored.EditValue = dailyReview.TodayBooksMajored;
                this.memoEditTodayBooksNotMajored.EditValue = dailyReview.TodayBooksNotMajored;
                this.memoEditTodayGains.EditValue = dailyReview.TodayGains;
                this.memoEditYesterdayProgress.EditValue = dailyReview.YesterdayProgress;
                this.memoEditYesterdayShortage.EditValue = dailyReview.YesterdayShortage;
                this.timeEditTodayGetupTime.EditValue = dailyReview.TodayGetupTime;
                this.timeEditYesterdaySleepTime.EditValue = dailyReview.YesterdaySleepTime;
            }

        }

        #endregion

        private void Form3_Load(object sender, EventArgs e)
        {
            //检测本地是否已经存在文件夹，不存在，就创建
            EnterpriseObjects.DirectoryHelper directoryHelper = new EnterpriseObjects.DirectoryHelper();
            directoryHelper.CreateDirOperate(Properties.Settings.Default.SavePath + @"\My DailyReviews", EnterpriseObjects.OperateOption.ExistReturn);

            if (this.Tag != null)
            {
                ShowDailyReview();
            }
        }

    }

    #region RichEditControl帮助类


    public class HtmlLoadHelper
    {
        /// <summary>
        /// 获取相对路径
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetRelativePath(string name)
        {
            name = "templates\\" + name;
            //string path = System.Windows.Forms.Application.StartupPath;
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + name;
            if (System.IO.File.Exists(fileName))
                return fileName;
            else
                return "";
        }

        public static void Load(String fileName, RichEditControl richEditControl)
        {
            string path = GetRelativePath(fileName);

            if (!String.IsNullOrEmpty(path))
            {
                richEditControl.LoadDocument(path, DocumentFormat.Html);
            }
            //richEditControl.LoadDocument(@"E:\JavaScript\letterspacing.html", DocumentFormat.Html);
        }
    }



    #endregion RichEditControl帮助类

}

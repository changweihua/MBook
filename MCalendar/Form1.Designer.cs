namespace MCalendar
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            resources.ApplyResources(this.schedulerControl1, "schedulerControl1");
            this.schedulerControl1.LookAndFeel.SkinName = "Office 2010 Black";
            this.schedulerControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday;
            this.schedulerControl1.OptionsView.NavigationButtons.NextCaption = resources.GetString("schedulerControl1.OptionsView.NavigationButtons.NextCaption");
            this.schedulerControl1.Start = new System.DateTime(2012, 12, 1, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.Views.DayView.DisplayName = resources.GetString("schedulerControl1.Views.DayView.DisplayName");
            this.schedulerControl1.Views.DayView.MenuCaption = resources.GetString("schedulerControl1.Views.DayView.MenuCaption");
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.MonthView.DisplayName = resources.GetString("schedulerControl1.Views.MonthView.DisplayName");
            this.schedulerControl1.Views.MonthView.MenuCaption = resources.GetString("schedulerControl1.Views.MonthView.MenuCaption");
            this.schedulerControl1.Views.TimelineView.DisplayName = resources.GetString("schedulerControl1.Views.TimelineView.DisplayName");
            this.schedulerControl1.Views.TimelineView.MenuCaption = resources.GetString("schedulerControl1.Views.TimelineView.MenuCaption");
            this.schedulerControl1.Views.WeekView.DisplayName = resources.GetString("schedulerControl1.Views.WeekView.DisplayName");
            this.schedulerControl1.Views.WeekView.MenuCaption = resources.GetString("schedulerControl1.Views.WeekView.MenuCaption");
            this.schedulerControl1.Views.WorkWeekView.DisplayName = resources.GetString("schedulerControl1.Views.WorkWeekView.DisplayName");
            this.schedulerControl1.Views.WorkWeekView.MenuCaption = resources.GetString("schedulerControl1.Views.WorkWeekView.MenuCaption");
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "无", "&None"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "重要", "&Important"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "商务", "&Business"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "私人", "&Personal"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "假期", "&Vacation"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "务必出席", "Must &Attend"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "可以出差", "&Travel Required"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "需要准备", "&Needs Preparation"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "生日", "&Birthday"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "周年纪念日", "&Anniversary"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "电话呼叫", "Phone &Call"));
            this.schedulerStorage1.Appointments.Statuses.Add(new DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Free, "自由", "&Free"));
            this.schedulerStorage1.Appointments.Statuses.Add(new DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Tentative, System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(135)))), ((int)(((byte)(226))))), "暂时", "&Tentative"));
            this.schedulerStorage1.Appointments.Statuses.Add(new DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Busy, System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(135)))), ((int)(((byte)(226))))), "忙碌", "&Busy"));
            this.schedulerStorage1.Appointments.Statuses.Add(new DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.OutOfOffice, System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(83))))), "离开", "&Out Of Office"));
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.AllowDrop = false;
            this.dateNavigator1.AppearanceCalendar.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dateNavigator1.AppearanceCalendar.GradientMode")));
            this.dateNavigator1.AppearanceCalendar.Options.UseTextOptions = true;
            this.dateNavigator1.AppearanceCalendar.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateNavigator1.AppearanceCalendar.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dateNavigator1.AppearanceCalendar.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.dateNavigator1.AppearanceWeekNumber.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("dateNavigator1.AppearanceWeekNumber.GradientMode")));
            resources.ApplyResources(this.dateNavigator1, "dateNavigator1");
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.LookAndFeel.SkinName = "Office 2010 Black";
            this.dateNavigator1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateNavigator1.Multiselect = false;
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.schedulerControl1;
            this.dateNavigator1.TabStop = false;
            this.dateNavigator1.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.FirstFullWeek;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            resources.ApplyResources(this.splitContainerControl1, "splitContainerControl1");
            this.splitContainerControl1.LookAndFeel.SkinName = "Office 2010 Black";
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.dateNavigator1);
            this.splitContainerControl1.Panel1.ShowCaption = true;
            resources.ApplyResources(this.splitContainerControl1.Panel1, "splitContainerControl1.Panel1");
            this.splitContainerControl1.Panel2.Controls.Add(this.schedulerControl1);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.SplitterPosition = 243;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.LookAndFeel.SkinName = "Office 2010 Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;

    }
}


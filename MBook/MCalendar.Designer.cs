namespace MBook
{
    partial class MCalendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCalendar));
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.AllowDrop = false;
            this.dateNavigator1.AppearanceCalendar.Options.UseTextOptions = true;
            this.dateNavigator1.AppearanceCalendar.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateNavigator1.AppearanceCalendar.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateNavigator1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(2, 23);
            this.dateNavigator1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateNavigator1.Multiselect = false;
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.schedulerControl1;
            this.dateNavigator1.Size = new System.Drawing.Size(229, 192);
            this.dateNavigator1.TabIndex = 0;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.schedulerControl1.Appearance.AlternateHeaderCaption.Options.UseTextOptions = true;
            this.schedulerControl1.Appearance.AlternateHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.schedulerControl1.Appearance.AlternateHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.schedulerControl1.AppointmentImages = this.imageList1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(2, 23);
            this.schedulerControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday;
            this.schedulerControl1.OptionsView.NavigationButtons.NextCaption = "下一个约定";
            this.schedulerControl1.OptionsView.NavigationButtons.PrevCaption = "上一个约定";
            this.schedulerControl1.PaintStyleName = "Skin";
            this.schedulerControl1.Size = new System.Drawing.Size(802, 429);
            this.schedulerControl1.Start = new System.DateTime(2012, 12, 4, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.DisplayName = "日历";
            this.schedulerControl1.Views.DayView.MenuCaption = "日视图";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.MonthView.DisplayName = "月历";
            this.schedulerControl1.Views.MonthView.MenuCaption = "月视图";
            this.schedulerControl1.Views.TimelineView.DisplayName = "时光轴";
            this.schedulerControl1.Views.TimelineView.MenuCaption = "时间线视图";
            this.schedulerControl1.Views.WeekView.DisplayName = "周历";
            this.schedulerControl1.Views.WeekView.MenuCaption = "周视图";
            this.schedulerControl1.Views.WorkWeekView.DisplayName = "工作周历";
            this.schedulerControl1.Views.WorkWeekView.MenuCaption = "工作周视图";
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "无"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "重要"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "商务"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "私人"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "假日"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "务必出席"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "出差"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "提前准备"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "生日"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "周年纪念日"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "打电话"));
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateNavigator1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(233, 454);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "月历";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.schedulerControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(233, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(806, 454);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "事件";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1039, 454);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Silver";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MCalendar";
            this.Text = "MonoBook ---- 日历，记录重要的时刻";
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.ImageList imageList1;
    }
}
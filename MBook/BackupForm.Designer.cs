namespace MBook
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.simpleButtonStart = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.simpleButtonStop = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonPause = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.memoEditProgress = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.buttonEditSelectFolder = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditSelectFolder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonStart
            // 
            this.simpleButtonStart.ImageIndex = 2;
            this.simpleButtonStart.ImageList = this.imageList1;
            this.simpleButtonStart.Location = new System.Drawing.Point(12, 39);
            this.simpleButtonStart.Name = "simpleButtonStart";
            this.simpleButtonStart.Size = new System.Drawing.Size(85, 25);
            this.simpleButtonStart.TabIndex = 0;
            this.simpleButtonStart.Text = "开始备份";
            this.simpleButtonStart.Click += new System.EventHandler(this.simpleButtonStart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "20121223092407472_easyicon_cn_16.png");
            this.imageList1.Images.SetKeyName(1, "20121223092430415_easyicon_cn_16.png");
            this.imageList1.Images.SetKeyName(2, "20121223092530256_easyicon_cn_16.png");
            this.imageList1.Images.SetKeyName(3, "20121223093408814_easyicon_cn_16.png");
            // 
            // simpleButtonStop
            // 
            this.simpleButtonStop.ImageIndex = 0;
            this.simpleButtonStop.ImageList = this.imageList1;
            this.simpleButtonStop.Location = new System.Drawing.Point(286, 39);
            this.simpleButtonStop.Name = "simpleButtonStop";
            this.simpleButtonStop.Size = new System.Drawing.Size(85, 25);
            this.simpleButtonStop.TabIndex = 0;
            this.simpleButtonStop.Text = "停止备份";
            this.simpleButtonStop.Click += new System.EventHandler(this.simpleButtonStop_Click);
            // 
            // simpleButtonPause
            // 
            this.simpleButtonPause.ImageIndex = 1;
            this.simpleButtonPause.ImageList = this.imageList1;
            this.simpleButtonPause.Location = new System.Drawing.Point(149, 39);
            this.simpleButtonPause.Name = "simpleButtonPause";
            this.simpleButtonPause.Size = new System.Drawing.Size(85, 25);
            this.simpleButtonPause.TabIndex = 0;
            this.simpleButtonPause.Text = "暂停备份";
            this.simpleButtonPause.Click += new System.EventHandler(this.simpleButtonPause_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(12, 6);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(496, 27);
            this.progressBarControl1.TabIndex = 1;
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.ImageIndex = 3;
            this.simpleButtonClose.ImageList = this.imageList1;
            this.simpleButtonClose.Location = new System.Drawing.Point(423, 39);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(85, 25);
            this.simpleButtonClose.TabIndex = 0;
            this.simpleButtonClose.Text = "关闭窗体";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.progressBarControl1);
            this.panelControl1.Controls.Add(this.simpleButtonStart);
            this.panelControl1.Controls.Add(this.simpleButtonPause);
            this.panelControl1.Controls.Add(this.simpleButtonStop);
            this.panelControl1.Controls.Add(this.simpleButtonClose);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 285);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(523, 74);
            this.panelControl1.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.memoEditProgress);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 100);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(523, 259);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "详细信息";
            // 
            // memoEditProgress
            // 
            this.memoEditProgress.Location = new System.Drawing.Point(12, 39);
            this.memoEditProgress.Name = "memoEditProgress";
            this.memoEditProgress.Size = new System.Drawing.Size(496, 140);
            this.memoEditProgress.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.buttonEditSelectFolder);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(523, 100);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "设置备份信息";
            // 
            // buttonEditSelectFolder
            // 
            this.buttonEditSelectFolder.EditValue = "选择备份文件保存路径";
            this.buttonEditSelectFolder.Location = new System.Drawing.Point(23, 28);
            this.buttonEditSelectFolder.Name = "buttonEditSelectFolder";
            this.buttonEditSelectFolder.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            serializableAppearanceObject1.Options.UseTextOptions = true;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.buttonEditSelectFolder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "点击，选择文件你就", null, null, true)});
            this.buttonEditSelectFolder.Properties.ReadOnly = true;
            this.buttonEditSelectFolder.Size = new System.Drawing.Size(451, 21);
            this.buttonEditSelectFolder.TabIndex = 0;
            this.buttonEditSelectFolder.Click += new System.EventHandler(this.buttonEditSelectFolder_Click);
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 359);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Sharp";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "BackupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据备份";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditSelectFolder.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonStart;
        private DevExpress.XtraEditors.SimpleButton simpleButtonStop;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPause;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit memoEditProgress;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ButtonEdit buttonEditSelectFolder;
    }
}
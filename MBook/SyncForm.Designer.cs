namespace MBook
{
    partial class SyncForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyncForm));
            this.progressBarControlCurrentProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.progressBarControlTotalProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.memoEditDetail = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButtonDetail = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.simpleButtonSync = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonHide = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBoxTopMost = new System.Windows.Forms.PictureBox();
            this.labelControlCurrentStatus = new DevExpress.XtraEditors.LabelControl();
            this.pictureBoxNormal = new System.Windows.Forms.PictureBox();
            this.backgroundWorkerSync = new System.ComponentModel.BackgroundWorker();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlCurrentProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlTotalProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopMost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarControlCurrentProgress
            // 
            this.progressBarControlCurrentProgress.Location = new System.Drawing.Point(12, 12);
            this.progressBarControlCurrentProgress.Name = "progressBarControlCurrentProgress";
            this.progressBarControlCurrentProgress.Size = new System.Drawing.Size(542, 24);
            this.progressBarControlCurrentProgress.TabIndex = 0;
            // 
            // progressBarControlTotalProgress
            // 
            this.progressBarControlTotalProgress.Location = new System.Drawing.Point(12, 103);
            this.progressBarControlTotalProgress.Name = "progressBarControlTotalProgress";
            this.progressBarControlTotalProgress.Size = new System.Drawing.Size(652, 24);
            this.progressBarControlTotalProgress.TabIndex = 0;
            // 
            // memoEditDetail
            // 
            this.memoEditDetail.Location = new System.Drawing.Point(5, 29);
            this.memoEditDetail.Name = "memoEditDetail";
            this.memoEditDetail.Size = new System.Drawing.Size(642, 224);
            this.memoEditDetail.TabIndex = 1;
            // 
            // simpleButtonDetail
            // 
            this.simpleButtonDetail.ImageIndex = 2;
            this.simpleButtonDetail.ImageList = this.imageList1;
            this.simpleButtonDetail.Location = new System.Drawing.Point(12, 58);
            this.simpleButtonDetail.Name = "simpleButtonDetail";
            this.simpleButtonDetail.Size = new System.Drawing.Size(95, 24);
            this.simpleButtonDetail.TabIndex = 2;
            this.simpleButtonDetail.Tag = "";
            this.simpleButtonDetail.Text = "详细信息";
            this.simpleButtonDetail.Click += new System.EventHandler(this.simpleButtonDetail_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "20121221041428620_easyicon_cn_16.png");
            this.imageList1.Images.SetKeyName(1, "load.gif");
            this.imageList1.Images.SetKeyName(2, "20121221041708324_easyicon_cn_16.png");
            // 
            // simpleButtonSync
            // 
            this.simpleButtonSync.ImageIndex = 0;
            this.simpleButtonSync.ImageList = this.imageList1;
            this.simpleButtonSync.Location = new System.Drawing.Point(570, 12);
            this.simpleButtonSync.Name = "simpleButtonSync";
            this.simpleButtonSync.Size = new System.Drawing.Size(94, 24);
            this.simpleButtonSync.TabIndex = 2;
            this.simpleButtonSync.Text = "开始同步";
            this.simpleButtonSync.Click += new System.EventHandler(this.simpleButtonSync_Click);
            // 
            // simpleButtonHide
            // 
            this.simpleButtonHide.Location = new System.Drawing.Point(570, 58);
            this.simpleButtonHide.Name = "simpleButtonHide";
            this.simpleButtonHide.Size = new System.Drawing.Size(94, 24);
            this.simpleButtonHide.TabIndex = 2;
            this.simpleButtonHide.Text = "隐藏窗体";
            this.simpleButtonHide.Click += new System.EventHandler(this.simpleButtonHide_Click);
            // 
            // pictureBoxTopMost
            // 
            this.pictureBoxTopMost.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTopMost.Image")));
            this.pictureBoxTopMost.Location = new System.Drawing.Point(123, 58);
            this.pictureBoxTopMost.Name = "pictureBoxTopMost";
            this.pictureBoxTopMost.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxTopMost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTopMost.TabIndex = 3;
            this.pictureBoxTopMost.TabStop = false;
            this.pictureBoxTopMost.Click += new System.EventHandler(this.pictureBoxTopMost_Click);
            // 
            // labelControlCurrentStatus
            // 
            this.labelControlCurrentStatus.Location = new System.Drawing.Point(186, 78);
            this.labelControlCurrentStatus.Name = "labelControlCurrentStatus";
            this.labelControlCurrentStatus.Size = new System.Drawing.Size(18, 14);
            this.labelControlCurrentStatus.TabIndex = 4;
            this.labelControlCurrentStatus.Text = "xxx";
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNormal.Image")));
            this.pictureBoxNormal.Location = new System.Drawing.Point(123, 58);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNormal.TabIndex = 3;
            this.pictureBoxNormal.TabStop = false;
            this.pictureBoxNormal.Visible = false;
            this.pictureBoxNormal.Click += new System.EventHandler(this.pictureBoxNormal_Click);
            // 
            // backgroundWorkerSync
            // 
            this.backgroundWorkerSync.WorkerReportsProgress = true;
            this.backgroundWorkerSync.WorkerSupportsCancellation = true;
            this.backgroundWorkerSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSync_DoWork);
            this.backgroundWorkerSync.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSync_ProgressChanged);
            this.backgroundWorkerSync.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSync_RunWorkerCompleted);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.memoEditDetail);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 150);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(652, 258);
            this.panelControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(186, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "labelControl1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "详细信息";
            // 
            // SyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 420);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControlCurrentStatus);
            this.Controls.Add(this.pictureBoxNormal);
            this.Controls.Add(this.pictureBoxTopMost);
            this.Controls.Add(this.simpleButtonHide);
            this.Controls.Add(this.simpleButtonSync);
            this.Controls.Add(this.simpleButtonDetail);
            this.Controls.Add(this.progressBarControlTotalProgress);
            this.Controls.Add(this.progressBarControlCurrentProgress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Foggy";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "SyncForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "同步";
            this.Load += new System.EventHandler(this.SyncForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlCurrentProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControlTotalProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopMost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl progressBarControlCurrentProgress;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControlTotalProgress;
        private DevExpress.XtraEditors.MemoEdit memoEditDetail;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDetail;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSync;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHide;
        private System.Windows.Forms.PictureBox pictureBoxTopMost;
        private DevExpress.XtraEditors.LabelControl labelControlCurrentStatus;
        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSync;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
namespace MBook
{
    partial class SinaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinaForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.txtSomething = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sbtnSend = new DevExpress.XtraEditors.SimpleButton();
            this.lcLeftCount = new DevExpress.XtraEditors.LabelControl();
            this.lcOther = new DevExpress.XtraEditors.LabelControl();
            this.lcDescription = new DevExpress.XtraEditors.LabelControl();
            this.lcNickName = new DevExpress.XtraEditors.LabelControl();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.imgProfile);
            this.groupControl1.Controls.Add(this.txtSomething);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.sbtnSend);
            this.groupControl1.Controls.Add(this.lcLeftCount);
            this.groupControl1.Controls.Add(this.lcOther);
            this.groupControl1.Controls.Add(this.lcDescription);
            this.groupControl1.Controls.Add(this.lcNickName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(813, 250);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // imgProfile
            // 
            this.imgProfile.Location = new System.Drawing.Point(12, 12);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(100, 96);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProfile.TabIndex = 14;
            this.imgProfile.TabStop = false;
            // 
            // txtSomething
            // 
            this.txtSomething.Location = new System.Drawing.Point(12, 115);
            this.txtSomething.Multiline = true;
            this.txtSomething.Name = "txtSomething";
            this.txtSomething.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSomething.Size = new System.Drawing.Size(789, 84);
            this.txtSomething.TabIndex = 13;
            this.txtSomething.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageIndex = 0;
            this.simpleButton1.ImageList = this.imageList1;
            this.simpleButton1.Location = new System.Drawing.Point(12, 205);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 38);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "点击，选择图片";
            this.simpleButton1.Click += new System.EventHandler(this.btnInsertPicture_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "14655.gif");
            this.imageList1.Images.SetKeyName(1, "15331.gif");
            this.imageList1.Images.SetKeyName(2, "17675.gif");
            this.imageList1.Images.SetKeyName(3, "585812.gif");
            // 
            // sbtnSend
            // 
            this.sbtnSend.ImageIndex = 3;
            this.sbtnSend.ImageList = this.imageList1;
            this.sbtnSend.Location = new System.Drawing.Point(689, 205);
            this.sbtnSend.Name = "sbtnSend";
            this.sbtnSend.Size = new System.Drawing.Size(109, 38);
            this.sbtnSend.TabIndex = 11;
            this.sbtnSend.Text = "发表";
            this.sbtnSend.Click += new System.EventHandler(this.sbtnSend_Click);
            // 
            // lcLeftCount
            // 
            this.lcLeftCount.Location = new System.Drawing.Point(156, 217);
            this.lcLeftCount.Name = "lcLeftCount";
            this.lcLeftCount.Size = new System.Drawing.Size(113, 14);
            this.lcLeftCount.TabIndex = 10;
            this.lcLeftCount.Text = "还可以输入 140 个字";
            // 
            // lcOther
            // 
            this.lcOther.Location = new System.Drawing.Point(136, 94);
            this.lcOther.Name = "lcOther";
            this.lcOther.Size = new System.Drawing.Size(104, 14);
            this.lcOther.TabIndex = 6;
            this.lcOther.Text = "关注----粉丝----微博";
            // 
            // lcDescription
            // 
            this.lcDescription.Location = new System.Drawing.Point(136, 50);
            this.lcDescription.Name = "lcDescription";
            this.lcDescription.Size = new System.Drawing.Size(24, 14);
            this.lcDescription.TabIndex = 7;
            this.lcDescription.Text = "简介";
            // 
            // lcNickName
            // 
            this.lcNickName.Location = new System.Drawing.Point(136, 12);
            this.lcNickName.Name = "lcNickName";
            this.lcNickName.Size = new System.Drawing.Size(24, 14);
            this.lcNickName.TabIndex = 8;
            this.lcNickName.Text = "昵称";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 250);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(813, 213);
            this.webBrowser1.TabIndex = 1;
            // 
            // SinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 463);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "SinaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mono Book ---- 分享您的快乐到新浪微博，让大家开心开心";
            this.Load += new System.EventHandler(this.SinaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sbtnSend;
        private DevExpress.XtraEditors.LabelControl lcLeftCount;
        private DevExpress.XtraEditors.LabelControl lcOther;
        private DevExpress.XtraEditors.LabelControl lcDescription;
        private DevExpress.XtraEditors.LabelControl lcNickName;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtSomething;
        private System.Windows.Forms.PictureBox imgProfile;


    }
}
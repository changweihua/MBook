namespace MBook
{
    partial class RssForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("RSS读取器");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RssForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tvRss = new System.Windows.Forms.TreeView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.hyperLinkEditLink = new DevExpress.XtraEditors.HyperLinkEdit();
            this.labelControlTitle = new DevExpress.XtraEditors.LabelControl();
            this.mpbcReadStatus = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEditRssName = new DevExpress.XtraEditors.TextEdit();
            this.textEditRssAddress = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRead = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.hyperLinkEditRssAddress = new DevExpress.XtraEditors.HyperLinkEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroupRssAddress = new DevExpress.XtraEditors.RadioGroup();
            this.pictureEditStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditLink.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpbcReadStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditRssAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupRssAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tvRss);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1077, 496);
            this.splitContainerControl1.SplitterPosition = 199;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tvRss
            // 
            this.tvRss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRss.Location = new System.Drawing.Point(0, 0);
            this.tvRss.Name = "tvRss";
            treeNode1.Checked = true;
            treeNode1.Name = "root";
            treeNode1.Text = "RSS读取器";
            this.tvRss.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvRss.Size = new System.Drawing.Size(199, 496);
            this.tvRss.TabIndex = 0;
            this.tvRss.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvRss_NodeMouseDoubleClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.richEditControl1);
            this.groupControl2.Controls.Add(this.panelControl2);
            this.groupControl2.Controls.Add(this.mpbcReadStatus);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 134);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(873, 362);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "详细信息 ";
            // 
            // richEditControl1
            // 
            this.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(2, 105);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(869, 255);
            this.richEditControl1.TabIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureEditStatus);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.hyperLinkEditLink);
            this.panelControl2.Controls.Add(this.labelControlTitle);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 23);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(869, 82);
            this.panelControl2.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "文章标题";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "文章地址";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(228, 14);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "文章内容或摘要，具体点击请访问文章地址";
            // 
            // hyperLinkEditLink
            // 
            this.hyperLinkEditLink.Location = new System.Drawing.Point(82, 32);
            this.hyperLinkEditLink.Name = "hyperLinkEditLink";
            this.hyperLinkEditLink.Properties.ReadOnly = true;
            this.hyperLinkEditLink.Size = new System.Drawing.Size(608, 21);
            this.hyperLinkEditLink.TabIndex = 4;
            this.hyperLinkEditLink.ToolTip = "文章URL地址";
            // 
            // labelControlTitle
            // 
            this.labelControlTitle.Location = new System.Drawing.Point(82, 5);
            this.labelControlTitle.Name = "labelControlTitle";
            this.labelControlTitle.Size = new System.Drawing.Size(48, 14);
            this.labelControlTitle.TabIndex = 3;
            this.labelControlTitle.Text = "文章标题";
            this.labelControlTitle.ToolTip = "文章标题";
            // 
            // mpbcReadStatus
            // 
            this.mpbcReadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mpbcReadStatus.EditValue = "";
            this.mpbcReadStatus.Location = new System.Drawing.Point(457, 2);
            this.mpbcReadStatus.Name = "mpbcReadStatus";
            this.mpbcReadStatus.Properties.ReadOnly = true;
            this.mpbcReadStatus.Properties.ShowTitle = true;
            this.mpbcReadStatus.Size = new System.Drawing.Size(411, 18);
            this.mpbcReadStatus.TabIndex = 1;
            this.mpbcReadStatus.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEditRssName);
            this.panelControl1.Controls.Add(this.textEditRssAddress);
            this.panelControl1.Controls.Add(this.simpleButtonSave);
            this.panelControl1.Controls.Add(this.simpleButtonRead);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(873, 134);
            this.panelControl1.TabIndex = 0;
            // 
            // textEditRssName
            // 
            this.textEditRssName.EditValue = "";
            this.textEditRssName.Location = new System.Drawing.Point(18, 101);
            this.textEditRssName.Name = "textEditRssName";
            this.textEditRssName.Size = new System.Drawing.Size(131, 21);
            this.textEditRssName.TabIndex = 4;
            this.textEditRssName.ToolTip = "这里RSS源名称";
            // 
            // textEditRssAddress
            // 
            this.textEditRssAddress.EditValue = "";
            this.textEditRssAddress.Location = new System.Drawing.Point(165, 101);
            this.textEditRssAddress.Name = "textEditRssAddress";
            this.textEditRssAddress.Size = new System.Drawing.Size(431, 21);
            this.textEditRssAddress.TabIndex = 4;
            this.textEditRssAddress.ToolTip = "这里RSS源名称";
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSave.Image")));
            this.simpleButtonSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButtonSave.Location = new System.Drawing.Point(619, 99);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(108, 23);
            this.simpleButtonSave.TabIndex = 3;
            this.simpleButtonSave.Text = "保  存 RSS 源";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // simpleButtonRead
            // 
            this.simpleButtonRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonRead.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonRead.Image")));
            this.simpleButtonRead.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButtonRead.Location = new System.Drawing.Point(748, 99);
            this.simpleButtonRead.Name = "simpleButtonRead";
            this.simpleButtonRead.Size = new System.Drawing.Size(108, 23);
            this.simpleButtonRead.TabIndex = 3;
            this.simpleButtonRead.Text = "读  取 RSS 源";
            this.simpleButtonRead.Click += new System.EventHandler(this.simpleButtonRead_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.simpleButtonDelete);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.hyperLinkEditRssAddress);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.radioGroupRssAddress);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(869, 91);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "RSS站点";
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonDelete.Location = new System.Drawing.Point(617, 62);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(108, 24);
            this.simpleButtonDelete.TabIndex = 3;
            this.simpleButtonDelete.Text = "删  除 RSS 源";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(746, 62);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 24);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "修  改 RSS 源";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // hyperLinkEditRssAddress
            // 
            this.hyperLinkEditRssAddress.EditValue = "";
            this.hyperLinkEditRssAddress.Location = new System.Drawing.Point(163, 62);
            this.hyperLinkEditRssAddress.Name = "hyperLinkEditRssAddress";
            this.hyperLinkEditRssAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.hyperLinkEditRssAddress.Properties.ReadOnly = true;
            this.hyperLinkEditRssAddress.Size = new System.Drawing.Size(431, 21);
            this.hyperLinkEditRssAddress.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(104, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 14);
            this.labelControl3.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "当前RSS地址  ";
            // 
            // radioGroupRssAddress
            // 
            this.radioGroupRssAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioGroupRssAddress.EditValue = "http://www.cmono.net/rss.php";
            this.radioGroupRssAddress.Location = new System.Drawing.Point(2, 23);
            this.radioGroupRssAddress.Name = "radioGroupRssAddress";
            this.radioGroupRssAddress.Size = new System.Drawing.Size(865, 33);
            this.radioGroupRssAddress.TabIndex = 0;
            // 
            // pictureEditStatus
            // 
            this.pictureEditStatus.Image = ((System.Drawing.Image)(resources.GetObject("pictureEditStatus.Image")));
            this.pictureEditStatus.Location = new System.Drawing.Point(260, 62);
            this.pictureEditStatus.Name = "pictureEditStatus";
            this.pictureEditStatus.Size = new System.Drawing.Size(16, 16);
            this.pictureEditStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureEditStatus.TabIndex = 5;
            this.pictureEditStatus.TabStop = false;
            this.pictureEditStatus.Visible = false;
            // 
            // RssForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 496);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "RssForm";
            this.Text = "RSS采集器";
            this.Load += new System.EventHandler(this.RssForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditLink.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpbcReadStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditRssAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupRssAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroupRssAddress;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRead;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEditRssAddress;
        private DevExpress.XtraEditors.TextEdit textEditRssAddress;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.TextEdit textEditRssName;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl mpbcReadStatus;
        private System.Windows.Forms.TreeView tvRss;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEditLink;
        private DevExpress.XtraEditors.LabelControl labelControlTitle;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.PictureBox pictureEditStatus;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RssForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radioGroupRssAddress = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.hyperLinkEditRssAddress = new DevExpress.XtraEditors.HyperLinkEdit();
            this.textEditRssAddress = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.textEditRssName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControlSiteTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSiteDescription = new DevExpress.XtraEditors.LabelControl();
            this.labelControlArticleTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.hyperLinkEditArticleLink = new DevExpress.XtraEditors.HyperLinkEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.tvArticle = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupRssAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditRssAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditArticleLink.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tvArticle);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1077, 496);
            this.splitContainerControl1.SplitterPosition = 199;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEditRssName);
            this.panelControl1.Controls.Add(this.textEditRssAddress);
            this.panelControl1.Controls.Add(this.simpleButtonAdd);
            this.panelControl1.Controls.Add(this.simpleButtonUpdate);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(873, 134);
            this.panelControl1.TabIndex = 0;
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
            // radioGroupRssAddress
            // 
            this.radioGroupRssAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioGroupRssAddress.EditValue = "http://www.cmono.net/rss.php";
            this.radioGroupRssAddress.Location = new System.Drawing.Point(2, 23);
            this.radioGroupRssAddress.Name = "radioGroupRssAddress";
            this.radioGroupRssAddress.Size = new System.Drawing.Size(865, 33);
            this.radioGroupRssAddress.TabIndex = 0;
            this.radioGroupRssAddress.SelectedIndexChanged += new System.EventHandler(this.radioGroupRssAddress_SelectedIndexChanged);
            // 
            // simpleButtonUpdate
            // 
            this.simpleButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonUpdate.Image")));
            this.simpleButtonUpdate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButtonUpdate.Location = new System.Drawing.Point(748, 99);
            this.simpleButtonUpdate.Name = "simpleButtonUpdate";
            this.simpleButtonUpdate.Size = new System.Drawing.Size(108, 23);
            this.simpleButtonUpdate.TabIndex = 3;
            this.simpleButtonUpdate.Text = "更  新 RSS 源";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "当前RSS地址  ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(104, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 14);
            this.labelControl3.TabIndex = 1;
            // 
            // hyperLinkEditRssAddress
            // 
            this.hyperLinkEditRssAddress.EditValue = "http://www.cmono.net/rss.php";
            this.hyperLinkEditRssAddress.Location = new System.Drawing.Point(163, 62);
            this.hyperLinkEditRssAddress.Name = "hyperLinkEditRssAddress";
            this.hyperLinkEditRssAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.hyperLinkEditRssAddress.Size = new System.Drawing.Size(431, 21);
            this.hyperLinkEditRssAddress.TabIndex = 2;
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
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAdd.Image")));
            this.simpleButtonAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButtonAdd.Location = new System.Drawing.Point(619, 99);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(108, 23);
            this.simpleButtonAdd.TabIndex = 3;
            this.simpleButtonAdd.Text = "添  加 RSS 源";
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.hyperLinkEditArticleLink);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControlArticleTitle);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControlSiteDescription);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControlSiteTitle);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 134);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(873, 362);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "详细信息 ";
            // 
            // labelControlSiteTitle
            // 
            this.labelControlSiteTitle.Location = new System.Drawing.Point(86, 38);
            this.labelControlSiteTitle.Name = "labelControlSiteTitle";
            this.labelControlSiteTitle.Size = new System.Drawing.Size(48, 14);
            this.labelControlSiteTitle.TabIndex = 0;
            this.labelControlSiteTitle.Text = "站点名称";
            // 
            // labelControlSiteDescription
            // 
            this.labelControlSiteDescription.Location = new System.Drawing.Point(86, 66);
            this.labelControlSiteDescription.Name = "labelControlSiteDescription";
            this.labelControlSiteDescription.Size = new System.Drawing.Size(48, 14);
            this.labelControlSiteDescription.TabIndex = 0;
            this.labelControlSiteDescription.Text = "站点描述";
            // 
            // labelControlArticleTitle
            // 
            this.labelControlArticleTitle.Location = new System.Drawing.Point(86, 94);
            this.labelControlArticleTitle.Name = "labelControlArticleTitle";
            this.labelControlArticleTitle.Size = new System.Drawing.Size(48, 14);
            this.labelControlArticleTitle.TabIndex = 0;
            this.labelControlArticleTitle.Text = "文章标题";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "大致内容";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "文章链接";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "站点名称";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(18, 66);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "站点描述";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(18, 94);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "文章标题";
            // 
            // hyperLinkEditArticleLink
            // 
            this.hyperLinkEditArticleLink.EditValue = "";
            this.hyperLinkEditArticleLink.Location = new System.Drawing.Point(86, 120);
            this.hyperLinkEditArticleLink.Name = "hyperLinkEditArticleLink";
            this.hyperLinkEditArticleLink.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEditArticleLink.Properties.ReadOnly = true;
            this.hyperLinkEditArticleLink.Size = new System.Drawing.Size(100, 19);
            this.hyperLinkEditArticleLink.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(617, 62);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "修  改 RSS 源";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Location = new System.Drawing.Point(746, 62);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(108, 23);
            this.simpleButtonDelete.TabIndex = 3;
            this.simpleButtonDelete.Text = "删  除 RSS 源";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // tvArticle
            // 
            this.tvArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvArticle.Location = new System.Drawing.Point(0, 0);
            this.tvArticle.Name = "tvArticle";
            this.tvArticle.Size = new System.Drawing.Size(199, 496);
            this.tvArticle.TabIndex = 0;
            this.tvArticle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvArticle_MouseClick);
            // 
            // RssForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 496);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "RssForm";
            this.Text = "RSS采集器";
            this.Load += new System.EventHandler(this.RssForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupRssAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditRssAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditArticleLink.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroupRssAddress;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEditRssAddress;
        private DevExpress.XtraEditors.TextEdit textEditRssAddress;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.TextEdit textEditRssName;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControlSiteTitle;
        private DevExpress.XtraEditors.LabelControl labelControlSiteDescription;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControlArticleTitle;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEditArticleLink;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TreeView tvArticle;
    }
}
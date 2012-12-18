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
            this.tvArticle = new System.Windows.Forms.TreeView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEditRssName = new DevExpress.XtraEditors.TextEdit();
            this.textEditRssAddress = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.hyperLinkEditRssAddress = new DevExpress.XtraEditors.HyperLinkEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroupRssAddress = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditRssAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupRssAddress.Properties)).BeginInit();
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
            // tvArticle
            // 
            this.tvArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvArticle.Location = new System.Drawing.Point(0, 0);
            this.tvArticle.Name = "tvArticle";
            this.tvArticle.Size = new System.Drawing.Size(199, 496);
            this.tvArticle.TabIndex = 0;
            this.tvArticle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvArticle_MouseClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.xtraTabControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 134);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(873, 362);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "详细信息 ";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 23);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(869, 337);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
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
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAdd.Image")));
            this.simpleButtonAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButtonAdd.Location = new System.Drawing.Point(619, 99);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(108, 23);
            this.simpleButtonAdd.TabIndex = 3;
            this.simpleButtonAdd.Text = "添  加 RSS 源";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonUpdate
            // 
            this.simpleButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonUpdate.Image")));
            this.simpleButtonUpdate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButtonUpdate.Location = new System.Drawing.Point(748, 99);
            this.simpleButtonUpdate.Name = "simpleButtonUpdate";
            this.simpleButtonUpdate.Size = new System.Drawing.Size(108, 23);
            this.simpleButtonUpdate.TabIndex = 3;
            this.simpleButtonUpdate.Text = "更  新 RSS 源";
            this.simpleButtonUpdate.Click += new System.EventHandler(this.simpleButtonUpdate_Click);
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
            this.hyperLinkEditRssAddress.EditValue = "http://www.cmono.net/rss.php";
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
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRssAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditRssAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupRssAddress.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TreeView tvArticle;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    }
}
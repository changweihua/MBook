namespace MBook
{
    partial class DailyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyForm));
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barFile = new DevExpress.XtraBars.Bar();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonClear = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRedo = new DevExpress.XtraBars.BarButtonItem();
            this.barContent = new DevExpress.XtraBars.Bar();
            this.barButtonCut = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCopy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPaste = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barCode = new DevExpress.XtraBars.Bar();
            this.barButtonHighlight = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.repositoryItemRichEditStyleEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Twip;
            this.richEditControl1.Location = new System.Drawing.Point(0, 31);
            this.richEditControl1.MenuManager = this.barManager1;
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Options.Behavior.Copy = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.richEditControl1.Options.Behavior.Cut = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.richEditControl1.Options.Behavior.Drag = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.richEditControl1.Options.Behavior.Drop = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.richEditControl1.Options.Behavior.FontSource = DevExpress.XtraRichEdit.RichEditBaseValueSource.Document;
            this.richEditControl1.Options.Behavior.Paste = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.richEditControl1.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.richEditControl1.Options.DocumentSaveOptions.DefaultFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.richEditControl1.Options.Import.FallbackFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.richEditControl1.Size = new System.Drawing.Size(1117, 613);
            this.richEditControl1.TabIndex = 5;
            this.richEditControl1.Text = "这里输入日记的内容";
            this.richEditControl1.TextChanged += new System.EventHandler(this.richEditControl1_TextChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barFile,
            this.barContent,
            this.bar3,
            this.barCode});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageList1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonSave,
            this.barButtonCut,
            this.barButtonClose,
            this.barButtonClear,
            this.barButtonHighlight,
            this.barButtonUndo,
            this.barButtonRedo,
            this.barButtonCopy,
            this.barButtonPaste,
            this.barStaticItem1,
            this.barMdiChildrenListItem1,
            this.barEditItem1,
            this.barStaticItem2});
            this.barManager1.MainMenu = this.barContent;
            this.barManager1.MaxItemId = 17;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemColorEdit1,
            this.repositoryItemRichEditStyleEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemTimeEdit1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // barFile
            // 
            this.barFile.BarName = "Tools";
            this.barFile.DockCol = 0;
            this.barFile.DockRow = 0;
            this.barFile.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonClear),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonRedo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barFile.Text = "Tools";
            // 
            // barButtonSave
            // 
            this.barButtonSave.Caption = "保存日记";
            this.barButtonSave.Id = 0;
            this.barButtonSave.ImageIndex = 0;
            this.barButtonSave.LargeImageIndex = 0;
            this.barButtonSave.Name = "barButtonSave";
            this.barButtonSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonClose
            // 
            this.barButtonClose.Caption = "取消并关闭";
            this.barButtonClose.Id = 2;
            this.barButtonClose.ImageIndex = 10;
            this.barButtonClose.Name = "barButtonClose";
            this.barButtonClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonClose_ItemClick);
            // 
            // barButtonClear
            // 
            this.barButtonClear.Caption = "清空文本";
            this.barButtonClear.Id = 3;
            this.barButtonClear.ImageIndex = 2;
            this.barButtonClear.Name = "barButtonClear";
            this.barButtonClear.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonClear_ItemClick);
            // 
            // barButtonUndo
            // 
            this.barButtonUndo.Caption = "撤销操作";
            this.barButtonUndo.Id = 5;
            this.barButtonUndo.ImageIndex = 5;
            this.barButtonUndo.Name = "barButtonUndo";
            this.barButtonUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUndo_ItemClick);
            // 
            // barButtonRedo
            // 
            this.barButtonRedo.Caption = "重做操作";
            this.barButtonRedo.Id = 6;
            this.barButtonRedo.ImageIndex = 3;
            this.barButtonRedo.Name = "barButtonRedo";
            this.barButtonRedo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonRedo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonRedo_ItemClick);
            // 
            // barContent
            // 
            this.barContent.BarName = "Main menu";
            this.barContent.DockCol = 1;
            this.barContent.DockRow = 0;
            this.barContent.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barContent.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonCut, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonCopy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonPaste, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barContent.Text = "Main menu";
            // 
            // barButtonCut
            // 
            this.barButtonCut.Caption = "剪切";
            this.barButtonCut.Id = 1;
            this.barButtonCut.ImageIndex = 7;
            this.barButtonCut.Name = "barButtonCut";
            this.barButtonCut.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonCut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCut_ItemClick);
            // 
            // barButtonCopy
            // 
            this.barButtonCopy.Caption = "复制";
            this.barButtonCopy.Id = 7;
            this.barButtonCopy.ImageIndex = 6;
            this.barButtonCopy.Name = "barButtonCopy";
            this.barButtonCopy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCopy_ItemClick);
            // 
            // barButtonPaste
            // 
            this.barButtonPaste.Caption = "粘贴";
            this.barButtonPaste.Id = 8;
            this.barButtonPaste.ImageIndex = 8;
            this.barButtonPaste.Name = "barButtonPaste";
            this.barButtonPaste.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonPaste.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPaste_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barStaticItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "书写日记，放飞心情";
            this.barStaticItem1.Id = 9;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "字数：1000";
            this.barStaticItem2.Id = 12;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // barCode
            // 
            this.barCode.BarName = "Custom 5";
            this.barCode.DockCol = 2;
            this.barCode.DockRow = 0;
            this.barCode.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barCode.FloatLocation = new System.Drawing.Point(61, 217);
            this.barCode.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonHighlight, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barCode.Offset = 607;
            this.barCode.Text = "Custom 5";
            // 
            // barButtonHighlight
            // 
            this.barButtonHighlight.Caption = "高亮显示";
            this.barButtonHighlight.Id = 4;
            this.barButtonHighlight.ImageIndex = 9;
            this.barButtonHighlight.Name = "barButtonHighlight";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1117, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 644);
            this.barDockControlBottom.Size = new System.Drawing.Size(1117, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 613);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1117, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 613);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 31);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(1117, 0);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "20121204094139448_easyicon_cn_16.png");
            this.imageList1.Images.SetKeyName(1, "20121204094235658_easyicon_cn_16.png");
            this.imageList1.Images.SetKeyName(2, "Clear.png");
            this.imageList1.Images.SetKeyName(3, "Redo.png");
            this.imageList1.Images.SetKeyName(4, "SelectAll.png");
            this.imageList1.Images.SetKeyName(5, "Undo.png");
            this.imageList1.Images.SetKeyName(6, "20121207111657651_easyicon_cn_24.png");
            this.imageList1.Images.SetKeyName(7, "20121207111756790_easyicon_cn_24.png");
            this.imageList1.Images.SetKeyName(8, "20121207111844961_easyicon_cn_24.png");
            this.imageList1.Images.SetKeyName(9, "20121207112029114_easyicon_cn_24.png");
            this.imageList1.Images.SetKeyName(10, "20121207112500209_easyicon_cn_24.png");
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 10;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "状态";
            this.barEditItem1.Edit = this.repositoryItemMarqueeProgressBar1;
            this.barEditItem1.Id = 11;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // repositoryItemColorEdit1
            // 
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            // 
            // repositoryItemRichEditStyleEdit1
            // 
            this.repositoryItemRichEditStyleEdit1.AutoHeight = false;
            this.repositoryItemRichEditStyleEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditStyleEdit1.Control = null;
            this.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // DailyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 669);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DailyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MonoBook ---- 记录每一秒的幸福";
            this.Load += new System.EventHandler(this.DailyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barFile;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.Bar barContent;
        private DevExpress.XtraBars.BarButtonItem barButtonCut;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar barCode;
        private DevExpress.XtraBars.BarButtonItem barButtonClose;
        private DevExpress.XtraBars.BarButtonItem barButtonClear;
        private DevExpress.XtraBars.BarButtonItem barButtonUndo;
        private DevExpress.XtraBars.BarButtonItem barButtonRedo;
        private DevExpress.XtraBars.BarButtonItem barButtonHighlight;
        private DevExpress.XtraBars.BarButtonItem barButtonCopy;
        private DevExpress.XtraBars.BarButtonItem barButtonPaste;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit repositoryItemRichEditStyleEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;

    }
}
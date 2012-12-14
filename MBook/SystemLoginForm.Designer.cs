namespace MBook
{
    partial class SystemLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemLoginForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.checkEditRemember = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.buttonEditPassword = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEditPassport = new DevExpress.XtraEditors.ButtonEdit();
            this.loginProgress = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.buttonEditAction = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRemember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditPassport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditAction.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.hyperLinkEdit1);
            this.groupControl1.Controls.Add(this.checkEditRemember);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.buttonEditPassword);
            this.groupControl1.Controls.Add(this.buttonEditPassport);
            this.groupControl1.Controls.Add(this.loginProgress);
            this.groupControl1.Controls.Add(this.buttonEditAction);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(377, 195);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "www.cmono.net";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(265, 98);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.Caption = "忘记密码";
            this.hyperLinkEdit1.Properties.Image = ((System.Drawing.Image)(resources.GetObject("hyperLinkEdit1.Properties.Image")));
            this.hyperLinkEdit1.Properties.ImageAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.hyperLinkEdit1.Size = new System.Drawing.Size(100, 24);
            this.hyperLinkEdit1.TabIndex = 5;
            this.hyperLinkEdit1.ToolTip = "点击，取回密码";
            // 
            // checkEditRemember
            // 
            this.checkEditRemember.Location = new System.Drawing.Point(73, 100);
            this.checkEditRemember.Name = "checkEditRemember";
            this.checkEditRemember.Properties.Appearance.Font = new System.Drawing.Font("浪漫雅圆", 10F);
            this.checkEditRemember.Properties.Appearance.Options.UseFont = true;
            this.checkEditRemember.Properties.Caption = "是否记住用户名和密码";
            this.checkEditRemember.Size = new System.Drawing.Size(169, 19);
            this.checkEditRemember.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("浪漫雅圆", 10F);
            this.labelControl2.Location = new System.Drawing.Point(13, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "密   码";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("浪漫雅圆", 10F);
            this.labelControl1.Location = new System.Drawing.Point(13, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "用户名";
            // 
            // buttonEditPassword
            // 
            this.buttonEditPassword.Location = new System.Drawing.Point(76, 66);
            this.buttonEditPassword.Name = "buttonEditPassword";
            this.buttonEditPassword.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "点此，清空文本框", null, null, true)});
            this.buttonEditPassword.Properties.PasswordChar = '*';
            this.buttonEditPassword.Size = new System.Drawing.Size(289, 21);
            this.buttonEditPassword.TabIndex = 2;
            // 
            // buttonEditPassport
            // 
            this.buttonEditPassport.Location = new System.Drawing.Point(76, 25);
            this.buttonEditPassport.Name = "buttonEditPassport";
            this.buttonEditPassport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "点此，清空文本框", null, null, true)});
            this.buttonEditPassport.Properties.Mask.EditMask = "([a-zA-Z]+([a-zA-Z]\\.)?)@([a-zA-Z]+\\.)+([a-zA-Z]+\\.)?[a-zA-Z]+";
            this.buttonEditPassport.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.buttonEditPassport.Size = new System.Drawing.Size(289, 21);
            this.buttonEditPassport.TabIndex = 1;
            // 
            // loginProgress
            // 
            this.loginProgress.EditValue = 0;
            this.loginProgress.Location = new System.Drawing.Point(13, 129);
            this.loginProgress.Name = "loginProgress";
            this.loginProgress.Size = new System.Drawing.Size(352, 24);
            this.loginProgress.TabIndex = 1;
            this.loginProgress.Visible = false;
            // 
            // buttonEditAction
            // 
            this.buttonEditAction.Location = new System.Drawing.Point(13, 159);
            this.buttonEditAction.Name = "buttonEditAction";
            this.buttonEditAction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("buttonEditAction.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "登录", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "关闭登录窗体", null, null, true)});
            this.buttonEditAction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.buttonEditAction.Size = new System.Drawing.Size(352, 18);
            this.buttonEditAction.TabIndex = 4;
            this.buttonEditAction.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditAction_ButtonClick);
            // 
            // SystemLoginForm
            // 
            this.Appearance.Font = new System.Drawing.Font("浪漫雅圆", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 195);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "SystemLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MonoBook ---- 系统登录";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRemember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditPassport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditAction.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit buttonEditAction;
        private DevExpress.XtraEditors.MarqueeProgressBarControl loginProgress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit buttonEditPassword;
        private DevExpress.XtraEditors.ButtonEdit buttonEditPassport;
        private DevExpress.XtraEditors.CheckEdit checkEditRemember;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
    }
}
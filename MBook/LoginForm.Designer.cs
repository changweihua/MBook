namespace MBook
{
    partial class LoginForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bePassport = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bePassword = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkRemember = new DevExpress.XtraEditors.CheckEdit();
            this.beAction = new DevExpress.XtraEditors.ButtonEdit();
            this.mpbcLoginStatus = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.bePassport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRemember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beAction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpbcLoginStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bePassport
            // 
            this.bePassport.Location = new System.Drawing.Point(83, 32);
            this.bePassport.Name = "bePassport";
            this.bePassport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "清空文本框，重新填写", null, null, true)});
            this.bePassport.Size = new System.Drawing.Size(238, 21);
            this.bePassport.TabIndex = 0;
            this.bePassport.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bePassport_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "微博账号";
            // 
            // bePassword
            // 
            this.bePassword.Location = new System.Drawing.Point(83, 88);
            this.bePassword.Name = "bePassword";
            this.bePassword.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "清空文本框，重新填写", null, null, true)});
            this.bePassword.Properties.PasswordChar = '*';
            this.bePassword.Size = new System.Drawing.Size(238, 21);
            this.bePassword.TabIndex = 0;
            this.bePassword.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bePassport_ButtonClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(83, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "账号密码";
            // 
            // chkRemember
            // 
            this.chkRemember.Location = new System.Drawing.Point(83, 116);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Properties.Caption = "是否记住账号和密码";
            this.chkRemember.Size = new System.Drawing.Size(238, 19);
            this.chkRemember.TabIndex = 2;
            // 
            // beAction
            // 
            this.beAction.Location = new System.Drawing.Point(85, 151);
            this.beAction.Name = "beAction";
            this.beAction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "登录", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "重新填写表单", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "取消", null, null, true)});
            this.beAction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.beAction.Size = new System.Drawing.Size(236, 20);
            this.beAction.TabIndex = 3;
            this.beAction.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beAction_ButtonClick);
            // 
            // mpbcLoginStatus
            // 
            this.mpbcLoginStatus.EditValue = 0;
            this.mpbcLoginStatus.Location = new System.Drawing.Point(83, 178);
            this.mpbcLoginStatus.Name = "mpbcLoginStatus";
            this.mpbcLoginStatus.Properties.LookAndFeel.SkinName = "Foggy";
            this.mpbcLoginStatus.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.mpbcLoginStatus.Size = new System.Drawing.Size(238, 18);
            this.mpbcLoginStatus.TabIndex = 4;
            this.mpbcLoginStatus.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 207);
            this.Controls.Add(this.mpbcLoginStatus);
            this.Controls.Add(this.beAction);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.bePassword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bePassport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Foggy";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bePassport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRemember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beAction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpbcLoginStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit bePassport;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit bePassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkRemember;
        private DevExpress.XtraEditors.ButtonEdit beAction;
        private DevExpress.XtraEditors.MarqueeProgressBarControl mpbcLoginStatus;
    }
}
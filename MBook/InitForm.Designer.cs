namespace MBook
{
    partial class InitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            this.mpbcInitStatus = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.mpbcInitStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mpbcInitStatus
            // 
            this.mpbcInitStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mpbcInitStatus.Location = new System.Drawing.Point(0, 358);
            this.mpbcInitStatus.Name = "mpbcInitStatus";
            this.mpbcInitStatus.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.mpbcInitStatus.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.mpbcInitStatus.Properties.MarqueeAnimationSpeed = 200;
            this.mpbcInitStatus.Properties.ReadOnly = true;
            this.mpbcInitStatus.Size = new System.Drawing.Size(776, 23);
            this.mpbcInitStatus.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(289, 127);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "正在启动......";
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 381);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.mpbcInitStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mpbcInitStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl mpbcInitStatus;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
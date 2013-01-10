namespace MBook
{
    partial class MIndForm
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
            this.lcMessage = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lcMessage
            // 
            this.lcMessage.Location = new System.Drawing.Point(75, 29);
            this.lcMessage.Name = "lcMessage";
            this.lcMessage.Size = new System.Drawing.Size(8, 14);
            this.lcMessage.TabIndex = 0;
            this.lcMessage.Text = "  ";
            // 
            // MIndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 159);
            this.Controls.Add(this.lcMessage);
            this.LookAndFeel.SkinName = "Springtime";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MIndForm";
            this.Text = "MIndForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lcMessage;
    }
}
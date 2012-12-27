namespace MCalendar
{
    partial class MindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MindForm));
            this.SuspendLayout();
            // 
            // MindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 120);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Summer 2008";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MindForm";
            this.Text = "MindForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MindForm_FormClosing);
            this.Load += new System.EventHandler(this.MindForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
namespace MBook
{
    partial class PanGuForm
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
            this.sbtnCreateIndex = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // sbtnCreateIndex
            // 
            this.sbtnCreateIndex.Location = new System.Drawing.Point(46, 41);
            this.sbtnCreateIndex.Name = "sbtnCreateIndex";
            this.sbtnCreateIndex.Size = new System.Drawing.Size(124, 45);
            this.sbtnCreateIndex.TabIndex = 0;
            this.sbtnCreateIndex.Text = "创建索引";
            this.sbtnCreateIndex.Click += new System.EventHandler(this.sbtnCreateIndex_Click);
            // 
            // PanGuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 266);
            this.Controls.Add(this.sbtnCreateIndex);
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "PanGuForm";
            this.Text = "PanGuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtnCreateIndex;
    }
}
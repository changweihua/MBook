using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MBook
{
    public partial class StickyNoteForm : Form
    {
        #region 引用dll，实现窗体拖动

        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        #endregion

        #region 窗体的方法

        public StickyNoteForm()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体拖动方法

        /// <summary>
        /// 窗体拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        #endregion

        #region 按钮操作

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxNew_Click(object sender, EventArgs e)
        {
            new StickyNoteForm().Show();
        }

        private void pictureBoxTop_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.pictureBoxDown.Visible = true;
        }

        private void StickyNoteForm_Load(object sender, EventArgs e)
        {
            this.textBoxContent.Dock = DockStyle.Fill;
            this.pictureBoxDown.Location = this.pictureBoxTop.Location;
        }

        private void pictureBoxDown_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.pictureBoxDown.Visible = false;
        }


        #endregion

       
       
    }
}

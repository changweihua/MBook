using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DevExpress.XtraEditors;
using NLite.Data;
using MonoBookEntity;

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

        #region 全局变量

        #endregion

        #region 窗体的方法

        public StickyNoteForm()
        {
            InitializeComponent();
        }

        public StickyNoteForm(string guid)
        {
            InitializeComponent();
            this.Tag = guid;
        }

        private void StickyNoteForm_Load(object sender, EventArgs e)
        {
            this.textBoxContent.Dock = DockStyle.Fill;
            this.pictureBoxDown.Location = this.pictureBoxTop.Location;
            if (this.Tag != null)
            {
                this.pictureBoxSave.Visible = false;
                this.pictureBoxDelete.Visible = false;
                ShowStickyNote();
            }
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

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxNew_Click(object sender, EventArgs e)
        {
            new StickyNoteForm().Show();
        }

        /// <summary>
        /// 置顶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTop_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.pictureBoxDown.Visible = true;
        }



        /// <summary>
        /// 取消置顶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDown_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.pictureBoxDown.Visible = false;
        }

        private void pictureBoxSave_Click(object sender, EventArgs e)
        {
            SaveStickyNote();
        }


        #endregion

        #region 保存便笺

        void SaveStickyNote()
        {
            if (this.textBoxContent.Text.Length > 0)
            {
                string guid = Guid.NewGuid().ToString();

                StickyNote note = new StickyNote
                {
                    Content = this.textBoxContent.Text.Trim(),
                    Guid = guid,
                    UpdateDate = DateTime.Now.ToString(),
                    RecordType = 7
                };

                string filePath = string.Format(@"{0}\My StickyNotes\{1}.mono", Properties.Settings.Default.savePath, guid);

                bool flag = EnterpriseObjects.SerializeHelper.Serialize(EnterpriseObjects.SerializeType.Binary, note, filePath);

                if (flag)
                {
                    using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                    {
                        int count = ctx.Set<StickyNote>().Insert(note);
                        if (count == 1)
                        {
                            XtraMessageBox.Show("保存成功咯，", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            XtraMessageBox.Show("可能出现了点小意外，您能重新点击保存吗？，", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("可能出现了点小意外，您能重新点击保存吗？，", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("您没有记录下任何东西哦，", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region 显示便笺

        void ShowStickyNote()
        {
            string guid = this.Tag.ToString();

            string filePath = string.Format(@"{0}\My StickyNotes\{1}.mono", Properties.Settings.Default.savePath, guid);

            if (!EnterpriseObjects.FileHelper.CheckFile(filePath))
            {
                XtraMessageBox.Show("可能出现了点小意外，文件找不到了", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StickyNote note = new StickyNote();

            object obj = EnterpriseObjects.SerializeHelper.Deserialize(EnterpriseObjects.SerializeType.Binary, note.GetType(), filePath);

            note = obj as StickyNote;

            if (note != null)
            {
                this.textBoxContent.Text = note.Content;
            }

        }

        #endregion

    }
}

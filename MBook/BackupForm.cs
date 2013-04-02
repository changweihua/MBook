using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EnterpriseObjects;
using System.IO;
using System.Runtime.InteropServices;

namespace MBook
{
    public delegate BackupResult BackupHandler(string a, string b);

    public partial class BackupForm : XtraForm
    {
        #region 窗体边框阴影效果变量申明
        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);
        //声明Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong_r(IntPtr hwnd, int nIndex);
        #endregion

        #region 窗体方法

        public BackupForm()
        {
            InitializeComponent();
            //SetClassLong(this.Handle, GCL_STYLE, GetClassLong_r(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
        }

        #endregion

        
        #region 按钮方法

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 暂停备份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonPause_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(this.LookAndFeel, "暂停备份", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 停止备份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonStop_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(this.LookAndFeel, "停止备份", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 开始备份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonStart_Click(object sender, EventArgs e)
        {
            memoEditProgress.Text += string.Format("{0}\r\n", "开始执行数据备份" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            //XtraMessageBox.Show(this.LookAndFeel, "开始备份", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var fileName = buttonEditSelectFolder.EditValue.ToString();
            //MessageBox.Show(fileName.Substring(0, fileName.LastIndexOf(@"\")));
            //return;
            if (!Directory.Exists(fileName.Substring(0, fileName.LastIndexOf(@"\"))))
            {
                memoEditProgress.Text += string.Format("{0}\r\n", "创建目录" + Directory.CreateDirectory(fileName.Substring(0, fileName.LastIndexOf(@"\"))));
            }
            else
            {
                memoEditProgress.Text += string.Format("{0}\r\n", "找到目录" + Directory.CreateDirectory(fileName.Substring(0, fileName.LastIndexOf(@"\"))));
            }

            BackupHandler handler = new BackupHandler( ZipHelper.ZipByFolderName);
            IAsyncResult result = handler.BeginInvoke(@Properties.Settings.Default.SavePath, fileName, new AsyncCallback((a) => {
                var x = handler.EndInvoke(a);
                if (x == BackupResult.Success)
                {
                    XtraMessageBox.Show(this.LookAndFeel, "备份成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show(this.LookAndFeel, "备份失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }), "AsycState:OK");
        }

        #endregion

        private void buttonEditSelectFolder_Click(object sender, EventArgs e)
        {
           var sfd = new SaveFileDialog();
           sfd.FileName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");
           sfd.Filter = "*.zip|*.zip";
           sfd.InitialDirectory = Application.StartupPath;
           if (sfd.ShowDialog() == DialogResult.OK)
           {
               (sender as ButtonEdit).EditValue = sfd.FileName;
               this.simpleButtonStart.Enabled = true;
           }
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            this.simpleButtonStart.Enabled = false;
            simpleButtonPause.Enabled = false;
            simpleButtonStop.Enabled = false;
        }

    }
}

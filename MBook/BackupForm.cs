using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MBook
{
    public partial class BackupForm : XtraForm
    {
        #region 窗体方法

        public BackupForm()
        {
            InitializeComponent();
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
            XtraMessageBox.Show(this.LookAndFeel, "开始备份", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


        #region BackgroundWorker

        private void backgroundWorkerBackup_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorkerBackup_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorkerBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        #endregion


        #region 公共方法

        /// <summary>
        /// 初始化备份，准备好一切数据
        /// </summary>
        /// <returns></returns>
        private bool InitBackup()
        {
            return true;
        }


        private void Backup(BackgroundWorker worker, DoWorkEventArgs e)
        {

        }

        #endregion

    }
}

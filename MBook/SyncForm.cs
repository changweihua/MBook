using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NLite.Data;
using MonoBookEntity;
using DevExpress.XtraEditors;

namespace MBook
{
    public partial class SyncForm : XtraForm
    {

        #region 公共方法

        /// <summary>
        /// 同步方法
        /// </summary>
        void Sync()
        {
            int count = 0;
            using (var ctx = DbConfiguration.Items["MonoLog"].CreateDbContext())
            {
                count = ctx.Set<MonoNote>().Insert(new MonoNote
                {

                });
            }
        }

        /// <summary>
        /// 启动同步
        /// </summary>
        private void StartSync()
        {
            int count = 0;
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                count = ctx.Set<Note>().Count(n => n.IsSync == 0);
            }
            XtraMessageBox.Show(this.LookAndFeel, count.ToString(), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 更新详细信息框
        /// </summary>
        /// <param name="msg"></param>
        void UpdateMemoEdit(string msg)
        {
            this.memoEditDetail.Text = "123456\r\n123456\r\n123456\r\n123456\r\n123456\r\n";
        }

        #endregion


        #region 窗体方法

        public SyncForm()
        {
            InitializeComponent();
        }

        private void SyncForm_Load(object sender, EventArgs e)
        {

        }

        #endregion


        #region 按钮方法

        /// <summary>
        /// 显示还是隐藏详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonDetail_Click(object sender, EventArgs e)
        {
            this.panelControl1.Visible = !this.panelControl1.Visible;
            if (this.panelControl1.Visible == true)
            {
                this.Height += panelControl1.Height;
            }
            else
            {
                this.Height -= panelControl1.Height;
            }
        }


        /// <summary>
        /// 同步按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonSync_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerSync.IsBusy)
            {
                this.backgroundWorkerSync.CancelAsync();
            }
            else
            {
                this.backgroundWorkerSync.RunWorkerAsync();
            }
        }


        /// <summary>
        /// 隐藏窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        /// <summary>
        /// 置顶窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTopMost_Click(object sender, EventArgs e)
        {
            this.pictureBoxNormal.Visible = true;
            this.pictureBoxTopMost.Visible = false;
            this.TopMost = true;
        }


        /// <summary>
        /// 取消置顶窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxNormal_Click(object sender, EventArgs e)
        {
            this.pictureBoxTopMost.Visible = true;
            this.pictureBoxNormal.Visible = false;
            this.TopMost = false;
        }

        #endregion

        #region BackgroundWorker

        /// <summary>
        /// 线程操作完毕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerSync_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            XtraMessageBox.Show(this.LookAndFeel, "后台线程操作完毕", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
        }

        /// <summary>
        /// 具体的工作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerSync_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                int a = 0;
                this.backgroundWorkerSync.ReportProgress(0);
            }

        }

        /// <summary>
        /// 进度改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerSync_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateMemoEdit("");
        }

        #endregion

        

    }
}

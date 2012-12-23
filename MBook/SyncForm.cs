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
using System.Threading;

namespace MBook
{
    public partial class SyncForm : XtraForm
    {

        #region 全局变量

        int totalProgress = 0;
        List<Note> notes = null;
        List<MonoNote> monoNotes = null;
        #endregion

        #region 公共方法

        /// <summary>
        /// 同步方法
        /// </summary>
        int Sync(BackgroundWorker worker, DoWorkEventArgs e)
        {
            int max = (int)e.Argument;
            int percent = 0;
            for (int i = 1; i <= max; i++)
            {
                if (worker.CancellationPending)
                {
                    return i;
                }
                else
                {
                    percent = (int)((double)i / (double)max * 100);
                    Note note = null;
                    using (var ctx = DbConfiguration.Items["MonoLog"].CreateDbContext())
                    {
                        ctx.Set<MonoNote>().Insert(monoNotes[i-1]);
                        note = notes.SingleOrDefault(n => n.Guid == monoNotes[i - 1].Guid);
                    }
                    note.IsSync = 1;
                    using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                    {
                        ctx.Set<Note>().Update(note);
                    }
                    worker.ReportProgress(percent, new KeyValuePair<int, string>(i, Guid.NewGuid().ToString()));
                    Thread.Sleep(100);
                }
            }

            return max;
           
        }

        /// <summary>
        /// 启动同步
        /// </summary>
        private bool StartSync()
        {
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                totalProgress = ctx.Set<Note>().Count(n => n.IsSync == 0);
                notes = ctx.Set<Note>().Where(n => n.IsSync == 0).ToList();
            }

            if (totalProgress == 0)
            {
                return false;
            }

            //XtraMessageBox.Show(this.LookAndFeel, count.ToString(), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.labelControl1.Text = "需要同步的记录数" + totalProgress.ToString();
            monoNotes = new List<MonoNote>();
            foreach (var note in notes)
            {
                monoNotes.Add(new MonoNote
                {
                    Content = EnterpriseObjects.EncryptHelper.DecryptAES(note.Content),
                    CreateDate = Convert.ToDateTime(note.CreateDate),
                    Guid = note.Guid,
                    Tag = note.Tag,
                    Title = note.Title,
                    UpdateDate = Convert.ToDateTime(note.UpdateDate),
                    Grade = 0
                });
            }

            return true;
        }

        /// <summary>
        /// 更新详细信息框
        /// </summary>
        /// <param name="msg"></param>
        void UpdateMemoEdit(string msg)
        {
            this.memoEditDetail.Text += string.Format("{0}\r\n", msg);
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
            if (StartSync())
            {
                if (backgroundWorkerSync.IsBusy)
                {
                    this.backgroundWorkerSync.CancelAsync();
                }
                else
                {
                    this.backgroundWorkerSync.RunWorkerAsync(totalProgress);
                }
            }
            else
            {
                XtraMessageBox.Show(this.LookAndFeel, "没有找到需要同步的信息", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            XtraMessageBox.Show(this.LookAndFeel, "同步完成", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.progressBarControlTotalProgress.EditValue = 0;
        }

        /// <summary>
        /// 具体的工作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerSync_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = Sync(backgroundWorkerSync, e);
        }

        /// <summary>
        /// 进度改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerSync_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            KeyValuePair<int, string> record = (KeyValuePair<int, string>)e.UserState;
            labelControlCurrentStatus.Text = string.Format("已处理{0}条记录", record.Key);
            progressBarControlTotalProgress.EditValue = e.ProgressPercentage;
            UpdateMemoEdit(record.Value);
        }

        #endregion

        

    }
}

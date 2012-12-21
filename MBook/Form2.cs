using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using MonoBookEntity;
using NLite.Data;
using System.Xml.Linq;
using System.IO;

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       Form2
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       Form2
     * 创建时间:       2012/11/30  10:18:41
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class Form2 : RibbonForm
    {
        #region 全局变量

        string attachments = string.Empty;
        Note globalNote;
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        #endregion

        #region 窗体方法

        /// <summary>
        /// 构造
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string guid)
        {
            InitializeComponent();
            this.Tag = guid;
        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            //检测本地是否已经存在文件夹，不存在，就创建
            EnterpriseObjects.DirectoryHelper directoryHelper = new EnterpriseObjects.DirectoryHelper();
            directoryHelper.CreateDirOperate(Properties.Settings.Default.SavePath + @"\My Notes", EnterpriseObjects.OperateOption.ExistReturn);

            if (this.Tag != null)
            {
                ShowNote();
            }

        }

        #endregion

        #region 文件标签页方法

        /// <summary>
        /// 保存笔记按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //XtraMessageBox.Show(this.richEditControl1.HtmlText);
            if (globalNote != null)
            {
                var note = MakeNote(true);
                UpdateNote(note);
            }
            else
            {
                var note = MakeNote(false);
                SaveNote(note);
            }
        }

        /// <summary>
        /// 添加附件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonAttchment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ofd = new OpenFileDialog();
            string attach = string.Empty;
            ofd.Multiselect = true;
            ofd.Filter = "所有文件|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] fileNames = ofd.FileNames;
                StringBuilder sb = new StringBuilder("|");
                foreach (var item in fileNames)
                {
                    sb.Append(item + "|");
                }
                attach = sb.ToString();
            }
            else
            {
                return;
            }
            attachments += attach;
            XtraMessageBox.Show(this.richEditControl1.LookAndFeel, "您选择了:" + attachments, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 公共函数

        /// <summary>
        /// 序列化笔记
        /// </summary>
        /// <returns>是否序列化成功</returns>
        bool SerializeNote(Note note)
        {
            bool flag = false;

            string filePath = string.Format(@"{0}\My Notes\{1}.mono", Properties.Settings.Default.SavePath, note.Guid);

            flag = EnterpriseObjects.SerializeHelper.Serialize(EnterpriseObjects.SerializeType.Binary, note, filePath);

            return flag;
        }

        /// <summary>
        /// 得到Note实例
        /// </summary>
        /// <param name="flag">是否更新，true，表示更新</param>
        /// <returns></returns>
        Note MakeNote(bool flag)
        {
            Note note = null;
            if (flag)
            {
                note = new Note
                {
                    Attachment = attachments,
                    //CreateDate = globalNote.CreateDate,
                    Content = EnterpriseObjects.EncryptHelper.EncryptAES(this.richEditControl1.HtmlText),
                    Guid = globalNote.Guid,
                    Title = this.barEditTitle.EditValue == null ? "未命名" + DateTime.Now.ToString() : this.barEditTitle.EditValue.ToString(),
                    UpdateDate = DateTime.Now.ToString(),
                    RecordType = 1,
                    Tag = this.barEditTag.EditValue == null ? "" : this.barEditTag.EditValue.ToString()
                };
            }
            else
            {
                note = new Note
                {
                    Attachment = attachments,
                    //AES加密
                    Content = EnterpriseObjects.EncryptHelper.EncryptAES(this.richEditControl1.HtmlText),
                    CreateDate = DateTime.Now.ToString(),
                    Guid = Guid.NewGuid().ToString(),
                    Title = this.barEditTitle.EditValue == null ? "未命名" + DateTime.Now.ToString() : this.barEditTitle.EditValue.ToString(),
                    UpdateDate = DateTime.Now.ToString(),
                    RecordType = 1,
                    Tag = this.barEditTag.EditValue == null ? "" : this.barEditTag.EditValue.ToString()
                };
            }
            //XtraMessageBox.Show(note.Content);
            return note;
        }


        /// <summary>
        /// 保存笔记
        /// </summary>
        /// <param name="note"></param>
        void SaveNote(Note note)
        {
            //string temp = EnterpriseObjects.EncryptHelper.EncryptAES(this.richEditControl1.HtmlText);
            //XtraMessageBox.Show(this.richEditControl1.LookAndFeel, "加密之后\r\n" + temp, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //GetHtmlTag(this.richEditControl1.HtmlText, "<body>", "</body>");
            //return;

            if (SerializeNote(note))
            {
                int count = 0;
                using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                {
                    count = ctx.Set<Note>().Insert(note);
                }

                if (count == 1)
                {
                    UpdateIndex(note.Guid, note.RecordType);
                    using (var ctx = DbConfiguration.Items["MonoLog"].CreateDbContext())
                    {
                        count = ctx.Set<MonoNote>().Insert(new MonoNote
                        {
                            Tag = note.Tag,
                            Title = note.Title,
                            UpdateDate = Convert.ToDateTime(note.UpdateDate),
                            Guid = note.Guid,
                            CreateDate = Convert.ToDateTime(note.CreateDate),
                            Content = this.richEditControl1.HtmlText,
                            Grade = 0
                        });
                    }
                    this.Close();
                }
                else
                {
                    string filePath = string.Format(@"{0}\My Notes\{1}.mono", Properties.Settings.Default.SavePath, note.Guid);
                    EnterpriseObjects.FileHelper.DeleteFile(filePath);
                    XtraMessageBox.Show(this.richEditControl1.LookAndFeel, "发生了点小意外，重新保存一下，好吗？", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                XtraMessageBox.Show(this.richEditControl1.LookAndFeel, "发生了点小意外，重新保存一下，好吗？", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 截取HTML部分内容
        /// </summary>
        /// <param name="html"></param>
        /// <param name="startTag"></param>
        /// <param name="endTag"></param>
        /// <returns></returns>
        public string GetHtmlTag(string html, string startTag, string endTag)
        {
            string msg = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(html) && html.IndexOf(startTag) > 0 && html.IndexOf(endTag) > 0 && html.IndexOf(endTag) > html.IndexOf(startTag))
                {
                    int a = html.IndexOf(startTag);
                    int b = html.IndexOf(endTag);
                    var len1 = a + startTag.Length;
                    msg = html.Substring(len1, b - len1);
                }
            }
            catch { }
            return msg;
        }

        /// <summary>
        /// 更新笔记
        /// </summary>
        /// <param name="note"></param>
        void UpdateNote(Note note)
        {
            if (SerializeNote(note))
            {
                int count = 0;
                using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                {
                    count = ctx.Set<Note>().Update(note);
                }

                if (count == 1)
                {
                    this.Close();
                }
                else
                {
                    string filePath = string.Format(@"{0}\My Notes\{1}.mono", Properties.Settings.Default.SavePath, note.Guid);
                    EnterpriseObjects.FileHelper.DeleteFile(filePath);
                    XtraMessageBox.Show(this.richEditControl1.LookAndFeel, "保存的时候发生了点小意外，重新保存一下，好吗？", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show(this.richEditControl1.LookAndFeel, "序列化数据发生了点小意外，重新保存一下，好吗？", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 显示笔记
        /// </summary>
        private void ShowNote()
        {
            string filePath = string.Format(@"{0}\My Notes\{1}.mono", Properties.Settings.Default.SavePath, this.Tag.ToString());

            if (!EnterpriseObjects.FileHelper.CheckFile(filePath))
            {
                XtraMessageBox.Show(this.LookAndFeel, "可能出现了点小意外，文件找不到了", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object obj = EnterpriseObjects.SerializeHelper.Deserialize(EnterpriseObjects.SerializeType.Binary, typeof(Note), filePath);
            globalNote = obj as Note;
            if (globalNote != null)
            {
                this.barEditTitle.EditValue = globalNote.Title;
                this.barEditTag.EditValue = globalNote.Tag;
                this.richEditControl1.HtmlText = EnterpriseObjects.EncryptHelper.DecryptAES(globalNote.Content);
            }

        }

        /// <summary>
        /// 更新索引表
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="typeId"></param>
        private void UpdateIndex(string guid, int typeId)
        {
            Index index = new Index
            {
                Guid = guid,
                TypeId = typeId
            };

            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                ctx.Set<Index>().Insert(index);
            }
        }


        #endregion

        #region RichEditControl控件的方法

        /// <summary>
        /// 内容改变，显示字数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richEditControl1_TextChanged(object sender, EventArgs e)
        {
            this.barStaticInputStatus.Caption = string.Format("当前输入 {0} 个字", this.richEditControl1.Text.Length);
        }

        #endregion

        #region 分享按钮方法

        /// <summary>
        /// 第三方分享按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonShare_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tag = e.Item.Tag == null ? "" : e.Item.Tag.ToString();
            if (!string.IsNullOrEmpty(tag))
            {
                switch (tag)
                {
                    case "sina":
                        XtraMessageBox.Show(this.richEditControl1.LookAndFeel, "受限于本人技术以及新浪微博字数限制，暂时未能实现同步，\r\n不过您可以在个人信息标签页中收发微博", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "mail":
                        SendEmail();
                        //XtraMessageBox.Show(this.richEditControl1.LookAndFeel, "暂时还不能使用", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 将笔记以邮件的形式发送
        /// </summary>
        private void SendEmail()
        {
            MailForm mailForm = new MailForm();
            string content = string.Format("我的笔记:《{0}》\r\n内容如下\r\n{1}", this.barEditTitle.EditValue == null ? "未命名" : this.barEditTitle.EditValue.ToString(), this.richEditControl1.Text);
            (mailForm.Controls.Find("memoEditMailContent", true).ElementAt(0) as MemoEdit).Text = content;
            string subject = barEditTag.EditValue == null ? "" : string.Format("关于 “{0}” 的笔记", barEditTag.EditValue);
            (mailForm.Controls.Find("memoEditMailSubject", true).ElementAt(0) as MemoEdit).Text = subject;
            string title = string.Format("{0}的{1}分享{2}", Properties.Settings.Default.UserName, subject, DateTime.Now.ToString());
            (mailForm.Controls.Find("buttonEditMailTitle", true).ElementAt(0) as ButtonEdit).Text = title;
            (mailForm.Controls.Find("buttonEditMailFrom", true).ElementAt(0) as ButtonEdit).Text = Properties.Settings.Default.UserEmail;
            (mailForm.Controls.Find("buttonEditMailFromName", true).ElementAt(0) as ButtonEdit).Text = Properties.Settings.Default.UserName;
            mailForm.ShowDialog();
        }

        #endregion

    }
}

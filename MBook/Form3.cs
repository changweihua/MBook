using System;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       Form3
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       Form3
     * 创建时间:       2012/12/2 14:18:37
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class Form3 : XtraForm
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }


        /// <summary>
        /// 检查窗体
        /// </summary>
        private bool CheckForm()
        {
            var groupControls = this.Controls.Find("groupControl1", false);

            if (groupControls.Length > 0)
            {

                var collection1 = groupControls[0].Controls;

                for (int i = 0; i < collection1.Count; i++)
                {
                    if (collection1[i].GetType().Name == "TextEdit")
                    {
                        if ((collection1[i] as TextEdit).EditValue == null)
                        {
                            XtraMessageBox.Show(this.LookAndFeel, "必须填写", "信息提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else if (collection1[i].GetType().Name == "DateEdit")
                    {
                        if ((collection1[i] as DateEdit).EditValue == null)
                        {
                            XtraMessageBox.Show(this.LookAndFeel, "必须填写", "信息提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else if (collection1[i].GetType().Name == "TimeEdit")
                    {
                        if ((collection1[i] as TimeEdit).EditValue == null)
                        {
                            XtraMessageBox.Show(this.LookAndFeel, "必须填写", "信息提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else if (collection1[i].GetType().Name == "MemoEdit")
                    {
                        if ((collection1[i] as MemoEdit).EditValue == null)
                        {
                            XtraMessageBox.Show(this.LookAndFeel, "必须填写", "信息提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }


            return true;
        }


        /// <summary>
        /// 设置窗体只读
        /// </summary>
        private void SetFormReadonly()
        {
            var groupControls = this.Controls.Find("groupControl1", false);

            if (groupControls.Length > 0)
            {

                var collection1 = groupControls[0].Controls;

                for (int i = 0; i < collection1.Count; i++)
                {
                    if (collection1[i].GetType().Name == "TextEdit")
                    {
                        (collection1[i] as TextEdit).Properties.ReadOnly = true;
                    }
                    else if (collection1[i].GetType().Name == "DateEdit")
                    {
                        (collection1[i] as DateEdit).Properties.ReadOnly = true;
                    }
                    else if (collection1[i].GetType().Name == "TimeEdit")
                    {
                        (collection1[i] as TimeEdit).Properties.ReadOnly = true;
                    }
                    else if (collection1[i].GetType().Name == "MemoEdit")
                    {
                        (collection1[i] as MemoEdit).Properties.ReadOnly = true;
                    }
                }
            }

        }

        /// <summary>
        /// 操作按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = e.Button.Index;

            switch (index)
            {
                case 0:
                    AddDailyReview();
                    break;
                case 1:
                    this.Close();
                    break;
                default:
                    break;
            }

        }


        /// <summary>
        /// 保存每日回顾
        /// </summary>
        private void AddDailyReview()
        {
            if (CheckForm())
            {
                SetFormReadonly();
                mpbcStatus.Location = buttonEditAction.Location;
                buttonEditAction.Visible = false;
                mpbcStatus.Visible = true;
            }
        }

    }

    #region RichEditControl帮助类


    public class HtmlLoadHelper
    {
        /// <summary>
        /// 获取相对路径
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetRelativePath(string name)
        {
            name = "templates\\" + name;
            //string path = System.Windows.Forms.Application.StartupPath;
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + name;
            if (System.IO.File.Exists(fileName))
                return fileName;
            else
                return "";
        }

        public static void Load(String fileName, RichEditControl richEditControl)
        {
            string path = GetRelativePath(fileName);

            if (!String.IsNullOrEmpty(path))
            {
                richEditControl.LoadDocument(path, DocumentFormat.Html);
            }
            //richEditControl.LoadDocument(@"E:\JavaScript\letterspacing.html", DocumentFormat.Html);
        }
    }



    #endregion RichEditControl帮助类

}

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

        #endregion

        #region 窗体方法

        /// <summary>
        /// 构造
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            
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
            XtraMessageBox.Show(this.richEditControl1.HtmlText);
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
        /// 第三方分享
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonShare_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tag = e.Item.Tag==null?"":e.Item.Tag.ToString();
            if (!string.IsNullOrEmpty(tag))
            {
                switch (tag)
                {
                    case "sina":
                        XtraMessageBox.Show(this.richEditControl1.LookAndFeel, "暂时还不能使用", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "baidu":
                        XtraMessageBox.Show(this.richEditControl1.LookAndFeel, "暂时还不能使用", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
            }
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
        bool SerializeNote()
        {
            bool flag = false;



            return flag;
        }

        Note MakeNote()
        {
            //Note note = new Note {
            // Attachment = attachments,
            //  Content = ==0
            //};
            return null;
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

    }
}

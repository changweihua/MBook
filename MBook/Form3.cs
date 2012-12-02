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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Threading;

namespace MBook
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //注册皮肤
            BonusSkins.Register();
            OfficeSkins.Register();
            SkinManager.EnableFormSkins();

            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CHS");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SystemLoginForm loginForm = new SystemLoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}

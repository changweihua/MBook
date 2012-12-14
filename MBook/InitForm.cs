using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using EnterpriseObjects;

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:      4.0.30319.586
     * 类 名 称:       InitForm
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       InitForm
     * 创建时间:       2012/12/6 16:04:36
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class InitForm : XtraForm
    {
        public InitForm()
        {
            InitializeComponent();
            
        }


        /// <summary>
        /// 初始化整个程序
        /// </summary>
        private void InitProgram()
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                //验证用户是否登录
                if (CheckIsLogin())
                {
                    //初始化数据访问类
                    //实例化窗体
                    //InitComplete(true, "成功");


                    //创建目录
                    if (directoryHelper.CreateDirOperate(Properties.Settings.Default.SavePath, OperateOption.ExistReturn) && directoryHelper.CreateDirOperate(Properties.Settings.Default.BackupPath, OperateOption.ExistReturn))
                    {
                        InitComplete(true, "您还没有登录");
                    }
                    else
                    {
                        InitComplete(false, "初始化目录失败");
                    }
                }
                else
                {
                    //用户登录
                    SystemLoginForm slf = new SystemLoginForm();
                    if (slf.ShowDialog() == DialogResult.OK)
                    {
                        //具体登录细节
                        InitComplete(true, "您还没有登录");
                    }
                    else
                    {
                        InitComplete(false, "登录失败，可能是您放弃了登录或者用户密码输入错误");
                    }
                }
            }));
            th.Start();
            
        }


        /// <summary>
        /// 检测是否已经登录或者是否有本地登录的信息
        /// </summary>
        /// <returns></returns>
        private bool CheckIsLogin()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName) || string.IsNullOrEmpty(Properties.Settings.Default.UserPassword))
            {
                return false;
            }
            {
                return true;
            }
        }

        EnterpriseObjects.DirectoryHelper directoryHelper = null;
        private void InitForm_Load(object sender, EventArgs e)
        {
            directoryHelper = new EnterpriseObjects.DirectoryHelper();

            InitProgram();
        }

        public void InitComplete(bool success, string msg)
        {
            if (mpbcInitStatus.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    InitComplete(success, msg);
                }));
            }
            else
            {
                if (success)
                {
                    mpbcInitStatus.Visible = false;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    mpbcInitStatus.Visible = false;
                    XtraMessageBox.Show(this.LookAndFeel, "失败信息。\r\n错误提示：" + msg, "初始化失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.No;
                }
            }
        }

    }
}

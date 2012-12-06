using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors;

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       ContactForm
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       ContactForm
     * 创建时间:       2012/12/2  19:07:44
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class ContactForm : XtraForm
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void buttonEditAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = e.Button.Index;

            switch (index)
            {
                case 0:
                    AddContact();
                    break;
                case 1:
                    ResetForm();
                    break;
                case 2:
                    this.Close();
                    break;
                default:
                    break;
            }

        }


        /// <summary>
        /// 重置整个表单
        /// </summary>
        private void ResetForm()
        {
            Control[] controls = this.Controls.Find("groupControl1", false);

            if (controls.Length == 1)
            {
                GroupControl control = controls[0] as GroupControl;
                if (control != null)
                {
                    var temp = control.Controls;
                    for (int i = 0; i < temp.Count; i++)
                    {
                        string name = temp[i].GetType().Name;

                        switch (name)
                        {
                            case "DateEdit":
                                (temp[i] as DateEdit).EditValue = "";
                                break;
                            case "TextEdit":
                                (temp[i] as TextEdit).EditValue = "";
                                break;
                            case "MemoEdit":
                                (temp[i] as MemoEdit).EditValue = "";
                                break;
                            default:
                                break;
                        }

                    }
                }
            }

            //XtraMessageBox.Show(this.Controls[0].Controls.Count.ToString());
        }


        /// <summary>
        /// 检查表单项是否输入完整
        /// </summary>
        /// <returns></returns>
        private bool CheckForm()
        {
            Control[] controls = this.Controls.Find("groupControl1", false);
            bool flag = true;
            if (controls.Length == 1)
            {
                GroupControl control = controls[0] as GroupControl;
                if (control != null)
                {
                    var temp = control.Controls;
                    object obj = null;
                    for (int i = 0; i < temp.Count; i++)
                    {
                        string name = temp[i].GetType().Name;

                        switch (name)
                        {
                            case "DateEdit":
                                obj=(temp[i] as DateEdit).EditValue ;
                                break;
                            case "TextEdit":
                                obj=(temp[i] as TextEdit).EditValue;
                                break;
                            case "MemoEdit":
                                obj=(temp[i] as MemoEdit).EditValue;
                                break;
                            default:
                                obj = "true";
                                break;
                        }

                        if (string.IsNullOrEmpty(obj == null ? "" : obj.ToString()))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
            }
            return flag;
            //XtraMessageBox.Show(this.Controls[0].Controls.Count.ToString());
        }


        private void AddContact()
        {
            if (!CheckForm())
            {
                XtraMessageBox.Show("不完整");
            }
        }

        /// <summary>
        /// 初始化验证规则
        /// </summary>
        private void InitValidationRules() 
        {
            //CustomValidationRule customValidationRule = new CustomValidationRule();
            //customValidationRule.ErrorText = "Please enter a valid person name";
            //customValidationRule.ErrorType = ErrorType.Warning;
        }

    }
}

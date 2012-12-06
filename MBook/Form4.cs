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
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       Form4
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       Form4
     * 创建时间:       2012/12/2  16:35:39
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class Form4 : XtraForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 检查输入是否完整
        /// </summary>
        /// <returns></returns>
        public bool CheckForm()
        {
            var controls = this.Controls;

            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i].GetType().Name == "GroupControl")
                {
                    var collection = controls[i].Controls;

                    for (int j = 0; j < collection.Count; j++)
                    {
                        if (collection[j].GetType().Name == "ButtonEdit")
                        {
                            if (string.IsNullOrEmpty((collection[j] as ButtonEdit).EditValue == null ? "" : (collection[j] as ButtonEdit).EditValue.ToString()))
                            {
                                XtraMessageBox.Show(this.LookAndFeel, "不能为空", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                        }
                        else if (collection[j].GetType().Name == "MemoEdit")
                        {
                            if (string.IsNullOrEmpty((collection[j] as MemoEdit).EditValue == null?"":(collection[j] as MemoEdit).EditValue.ToString()))
                            {
                                XtraMessageBox.Show(this.LookAndFeel, "不能为空", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                        }
                        else if (collection[j].GetType().Name == "DateEdit")
                        {
                            if (string.IsNullOrEmpty((collection[j] as DateEdit).EditValue == null ? "" : (collection[j] as DateEdit).EditValue.ToString()))
                            {
                                XtraMessageBox.Show(this.LookAndFeel, "不能为空", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                        }
                        else if(collection[j].GetType().Name == "TextEdit")
                        {
                            if (string.IsNullOrEmpty((collection[j] as TextEdit).EditValue == null ? "" : (collection[j] as TextEdit).EditValue.ToString()))
                            {
                                XtraMessageBox.Show(this.LookAndFeel, "不能为空", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                        }
                    }

                }
            }

            return true;
        }


        /// <summary>
        /// 提交信息时，将控件设置为只读
        /// </summary>
        /// <returns></returns>
        public void SetFormReadonly()
        {
            var controls = this.Controls;

            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i].GetType().Name == "GroupControl")
                {
                    var collection = controls[i].Controls;

                    for (int j = 0; j < collection.Count; j++)
                    {
                        if (collection[j].GetType().Name == "ButtonEdit")
                        {
                            (collection[j] as ButtonEdit).Properties.ReadOnly = true;
                        }
                        else if (collection[j].GetType().Name == "MemoEdit")
                        {
                            (collection[j] as MemoEdit).Properties.ReadOnly=true;
                        }
                        else if (collection[j].GetType().Name == "DateEdit")
                        {
                            (collection[j] as DateEdit).Properties.ReadOnly = true;
                        }
                        else if (collection[j].GetType().Name == "TextEdit")
                        {
                            (collection[j] as TextEdit).Properties.ReadOnly=true;
                        }
                    }

                }
            }

        }


        /// <summary>
        /// ButtonEdit 控件按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = e.Button.Index;

            switch (index)
            {
                case 0:
                    (sender as ButtonEdit).SelectAll();
                    (sender as ButtonEdit).Properties.ReadOnly=false;
                    break;
                case 1:
                    if (string.IsNullOrEmpty((sender as ButtonEdit).EditValue == null ? "" : (sender as ButtonEdit).EditValue.ToString()))
                    {
                        XtraMessageBox.Show(LookAndFeel, "必须要填写", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        (sender as ButtonEdit).DeselectAll();
                        (sender as ButtonEdit).Properties.ReadOnly = true;
                    }
                    break;
                default:
                    break;
            }

        }


        /// <summary>
        /// 操作按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = e.Button.Index;
            switch (index)
            {
                case 0:
                    AddGridDaily();
                    break;
                case 1:
                    break;
                case 2:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 添加九宫格日记
        /// </summary>
        private void AddGridDaily()
        {
            if (CheckForm())
            {
                XtraMessageBox.Show("Be in");
                SetFormReadonly();
                mpbcStatus.Location = buttonEditAction.Location;
                buttonEditAction.Visible = false;
                mpbcStatus.Visible = true;
            }
        
        }

    }
}

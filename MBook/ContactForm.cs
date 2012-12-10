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
using NLite.Data;
using MonoBookEntity;
using System.IO;
using System.Drawing.Imaging;

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
        private Contact contact;

        public ContactForm()
        {
            InitializeComponent();
            this.Tag = "";
        }

        public ContactForm(string guid)
        {
            InitializeComponent();
            this.Tag = guid;
        }

        #region 大按钮

        private void buttonEditAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int index = e.Button.Index;

            switch (index)
            {
                case 0:
                    SaveContact();
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


        #endregion

        #region 重置

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


        #endregion

        #region 保存

        /// <summary>
        /// 保存联系人
        /// </summary>
        private void SaveContact()
        {
            if (!CheckForm())
            {
                XtraMessageBox.Show(this.LookAndFeel, "信息必须填写完整", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string guid = "";
            if (!string.IsNullOrEmpty(this.Tag.ToString()))
            {
                guid = contact.Guid;
            }
            else
            {
                guid = Guid.NewGuid().ToString();
            }

            contact = new Contact
            {
                Address = textEditAddress.EditValue.ToString(),
                Birthday = dateEditBirthday.EditValue.ToString(),
                Department = textEditDepartment.EditValue.ToString(),
                Email = textEditEmail.EditValue.ToString(),
                Guid = guid,
                Msn = textEditMsn.EditValue.ToString(),
                Name = textEditName.EditValue.ToString(),
                QQ = textEditQQ.EditValue.ToString(),
                Rank = textEditRank.EditValue.ToString(),
                Remark = memoEditRemark.EditValue.ToString(),
                Telephone = textEditTelePhone.EditValue.ToString(),
                Website = textEditWebsite.EditValue.ToString(),
                RecordType = 5
            };

            string filePath = string.Format(@"{0}\My Contacts\{1}.mono", Properties.Settings.Default.savePath, contact.Guid);

            bool flag = EnterpriseObjects.SerializeHelper.Serialize(EnterpriseObjects.SerializeType.Xml, contact, filePath);

            if (flag)
            {
                Bitmap map = pictureEditImage.EditValue as Bitmap;
                if (map != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        map.Save(ms, ImageFormat.Png);
                        byte[] byteImage = new byte[ms.Length];
                        byteImage = ms.ToArray();
                        contact.UserImage = byteImage;
                    }
                }
                using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                {
                    int count = 0;
                    if (!string.IsNullOrEmpty(this.Tag.ToString()))
                    {
                        count = ctx.Set<Contact>().Update(contact);
                    }
                    else
                    {
                        count = ctx.Set<Contact>().Insert(contact);
                    }
                    //XtraMessageBox.Show(count.ToString());
                    if (count == 1)
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                }
            }
        }

        #endregion

        #region 显示

        private void ShowContact()
        {
            int a = 0;
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                contact = ctx.Set<Contact>().Where(c => c.Guid == this.Tag.ToString()).ElementAt(0);
                this.textEditAddress.EditValue = contact.Address;
                this.textEditDepartment.EditValue = contact.Department;
                this.textEditEmail.EditValue = contact.Email;
                this.textEditMsn.EditValue = contact.Msn;
                this.textEditName.EditValue = contact.Name;
                this.textEditQQ.EditValue = contact.QQ;
                this.textEditRank.EditValue = contact.Rank;
                this.textEditTelePhone.EditValue = contact.Telephone;
                this.textEditWebsite.EditValue = contact.Website;
                this.dateEditBirthday.EditValue = contact.Birthday;
                this.memoEditRemark.EditValue = contact.Remark;
            }
        }

        #endregion

        #region 公共方法

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
                                obj = (temp[i] as DateEdit).EditValue;
                                break;
                            case "TextEdit":
                                obj = (temp[i] as TextEdit).EditValue;
                                break;
                            case "MemoEdit":
                                obj = (temp[i] as MemoEdit).EditValue;
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


        /// <summary>
        /// 初始化验证规则
        /// </summary>
        private void InitValidationRules()
        {
            //CustomValidationRule customValidationRule = new CustomValidationRule();
            //customValidationRule.ErrorText = "Please enter a valid person name";
            //customValidationRule.ErrorType = ErrorType.Warning;
        }

        #endregion

        private void ContactForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Tag.ToString()))
            {
                ShowContact();
            }
        }

    }
}

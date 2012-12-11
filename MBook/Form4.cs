using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MonoBookEntity;
using System.IO;
using NLite.Data;

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
        #region 全局变量

        GridDaily gridDaily;
        GridDailyModel gdm;

        #endregion

        #region 构造方法


        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string guid)
        {
            InitializeComponent();
            this.Tag = guid;
        }

        #endregion

        #region 公共方法

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
                            if (string.IsNullOrEmpty((collection[j] as MemoEdit).EditValue == null ? "" : (collection[j] as MemoEdit).EditValue.ToString()))
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
                        else if (collection[j].GetType().Name == "TextEdit")
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
                            (collection[j] as MemoEdit).Properties.ReadOnly = true;
                        }
                        else if (collection[j].GetType().Name == "DateEdit")
                        {
                            (collection[j] as DateEdit).Properties.ReadOnly = true;
                        }
                        else if (collection[j].GetType().Name == "TextEdit")
                        {
                            (collection[j] as TextEdit).Properties.ReadOnly = true;
                        }
                    }

                }
            }

        }


        #endregion

        #region 按钮事件

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
                    (sender as ButtonEdit).Properties.ReadOnly = false;
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
                    SaveGridDaily();
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


        #endregion

        #region 保存

        /// <summary>
        /// 添加九宫格日记
        /// Bug : 无法将Content存入数据库
        /// </summary>
        private void SaveGridDaily()
        {
            if (!CheckForm())
            {
                return;
            }

            SetFormReadonly();
            mpbcStatus.Location = buttonEditAction.Location;
            buttonEditAction.Visible = false;
            mpbcStatus.Visible = true;

            List<DailyGrid> dailyGrids = new List<DailyGrid>() { 
                new DailyGrid{
                    Id=1,
                    Title= buttonEditGridTitle1.EditValue.ToString(),
                      SubHeading = buttonEditGridSubHeading1.EditValue.ToString(),
                       Content = memoEditContent1.EditValue.ToString()
                },
                new DailyGrid{
                     Id=2,
                    Title= buttonEditGridTitle2.EditValue.ToString(),
                      SubHeading = buttonEditGridSubHeading2.EditValue.ToString(),
                       Content = memoEditContent2.EditValue.ToString()
                },
                new DailyGrid{
                     Id=3,
                    Title= buttonEditGridTitle3.EditValue.ToString(),
                      SubHeading = buttonEditGridSubHeading3.EditValue.ToString(),
                       Content = memoEditContent3.EditValue.ToString()
                },
                new DailyGrid{
                     Id=4,
                    Title= buttonEditGridTitle4.EditValue.ToString(),
                      SubHeading = buttonEditGridSubHeading4.EditValue.ToString(),
                       Content = memoEditContent4.EditValue.ToString()
                },
                new DailyGrid{
                     Id=5,
                    Title= buttonEditGridTitle5.EditValue.ToString(),
                      SubHeading = buttonEditGridSubHeading5.EditValue.ToString(),
                       Content = memoEditContent5.EditValue.ToString()
                },
                new DailyGrid{
                     Id=6,
                    Title= buttonEditGridTitle6.EditValue.ToString(),
                      SubHeading = buttonEditGridSubHeading6.EditValue.ToString(),
                       Content = memoEditContent6.EditValue.ToString()
                },
                new DailyGrid{
                     Id=7,
                    Title= buttonEditGridTitle7.EditValue.ToString(),
                      SubHeading = buttonEditGridSubHeading7.EditValue.ToString(),
                       Content = memoEditContent7.EditValue.ToString()
                },
                new DailyGrid{
                     Id=8,
                    Title= buttonEditGridTitle8.EditValue.ToString(),
                      SubHeading = buttonEditGridSubHeading8.EditValue.ToString(),
                       Content = memoEditContent8.EditValue.ToString()
                }
            };

            string guid = this.Tag == null ? Guid.NewGuid().ToString() : this.Tag.ToString();

            var tempGdm = new GridDailyModel
            {
                Guid = guid,
                DailyGrids = dailyGrids,
                Title = buttonEditTitle.EditValue.ToString(),
                TodayBirthday = textEditTodayBirthday.EditValue.ToString(),
                TodayDate = dateEditTodayDate.EditValue.ToString(),
                TodayDesc = textEditTodayDesc.EditValue.ToString(),
                Weather = textEditTodayWeather.EditValue.ToString(),
                CreateDate = gdm == null ? DateTime.Now.ToString() : gdm.CreateDate,
                UpdateDate = DateTime.Now.ToString()
            };

            string filePath = string.Format(@"{0}\My GridDailies\{1}.mono", Properties.Settings.Default.savePath, tempGdm.Guid);

            bool flag = EnterpriseObjects.SerializeHelper.Serialize(EnterpriseObjects.SerializeType.Binary, tempGdm, filePath);
            string content = "";
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    content = reader.ReadToEnd();
                }
            }

            int count = 0;

            if (this.Tag == null)
            {
                var gd = new GridDaily
                 {
                     Guid = guid,
                     Content = @content,
                     RecordType = 6,
                     CreateDate = tempGdm.CreateDate
                 };

                using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                {
                    count = ctx.Set<GridDaily>().Insert(gd);
                }
            }
            else
            {
                //gridDaily.Guid = guid;
                //gridDaily.Content = content;
                //gridDaily.UpdateDate = DateTime.Now.ToString();

                var gd = new GridDaily
                {
                    Guid = guid,
                    Content = content,
                    RecordType = 6,
                    CreateDate = tempGdm.CreateDate,
                    UpdateDate = DateTime.Now.ToString()
                };

                using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
                {
                    count = ctx.Set<GridDaily>().Update(gd);
                }
            }
          

            if (count == 1)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                buttonEditAction.Visible = true;
                mpbcStatus.Visible = false;
            }
        }


        #endregion

        #region 展示九宫格日记

        void ShowGridDaily()
        {
            if (this.Tag != null)
            {
                string filePath = string.Format(@"{0}\My GridDailies\{1}.mono", Properties.Settings.Default.savePath, this.Tag.ToString());
                gdm = new GridDailyModel();
                object obj = EnterpriseObjects.SerializeHelper.Deserialize(EnterpriseObjects.SerializeType.Binary, gdm.GetType(), filePath);

                gdm = obj as GridDailyModel;

                if (gdm != null)
                {
                    this.textEditTodayBirthday.EditValue = gdm.TodayBirthday;
                    this.textEditTodayDesc.EditValue = gdm.TodayDesc;
                    this.textEditTodayWeather.EditValue = gdm.Weather;
                    this.dateEditTodayDate.EditValue = gdm.TodayDate;

                    List<DailyGrid> dailyGrids = gdm.DailyGrids;

                    this.buttonEditGridTitle1.EditValue = dailyGrids[0].Title;
                    this.buttonEditGridSubHeading1.EditValue = dailyGrids[0].SubHeading;
                    this.memoEditContent1.EditValue = dailyGrids[0].Content;

                    this.buttonEditGridTitle2.EditValue = dailyGrids[1].Title;
                    this.buttonEditGridSubHeading2.EditValue = dailyGrids[1].SubHeading;
                    this.memoEditContent2.EditValue = dailyGrids[1].Content;

                    this.buttonEditGridTitle3.EditValue = dailyGrids[2].Title;
                    this.buttonEditGridSubHeading3.EditValue = dailyGrids[2].SubHeading;
                    this.memoEditContent3.EditValue = dailyGrids[2].Content;

                    this.buttonEditGridTitle4.EditValue = dailyGrids[3].Title;
                    this.buttonEditGridSubHeading4.EditValue = dailyGrids[3].SubHeading;
                    this.memoEditContent4.EditValue = dailyGrids[3].Content;

                    this.buttonEditGridTitle5.EditValue = dailyGrids[4].Title;
                    this.buttonEditGridSubHeading5.EditValue = dailyGrids[4].SubHeading;
                    this.memoEditContent5.EditValue = dailyGrids[4].Content;

                    this.buttonEditGridTitle6.EditValue = dailyGrids[5].Title;
                    this.buttonEditGridSubHeading6.EditValue = dailyGrids[5].SubHeading;
                    this.memoEditContent6.EditValue = dailyGrids[5].Content;

                    this.buttonEditGridTitle7.EditValue = dailyGrids[6].Title;
                    this.buttonEditGridSubHeading7.EditValue = dailyGrids[6].SubHeading;
                    this.memoEditContent7.EditValue = dailyGrids[6].Content;

                    this.buttonEditGridTitle8.EditValue = dailyGrids[7].Title;
                    this.buttonEditGridSubHeading8.EditValue = dailyGrids[7].SubHeading;
                    this.memoEditContent8.EditValue = dailyGrids[7].Content;
                   
                }

            }
        }

        #endregion

        #region 窗体自身事件

        private void Form4_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                ShowGridDaily();
            }
        }

        #endregion

        

    }
}

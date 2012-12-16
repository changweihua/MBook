using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml.Linq;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using MonoBookEntity;
using NLite.Data;
using DevExpress.XtraEditors.Controls;

namespace MBook
{
    public partial class RssForm : XtraForm
    {

        public RssForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RssForm_Load(object sender, EventArgs e)
        {
            if (!CheckNetworkStatus())
            {
                if (XtraMessageBox.Show(this.LookAndFeel, "貌似您没有连接上网络，是否读取本地数据", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }
                return;
            }

            FillRadioGroup();

           

            #region 废弃的方法

            //try
            //{
            //    string memo = "";
            //    var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.cmono.net/?post=504");

            //    HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //    Stream receiveStream = myHttpWebResponse.GetResponseStream();
            //    Encoding encode = Encoding.GetEncoding("utf-8");
            //    StreamReader sr = new StreamReader(receiveStream, encode);
            //    char[] read = new char[256];
            //    int count = sr.Read(read, 0, 256);
            //    while (count > 0)
            //    {
            //        string str = new string(read, 0, count);
            //        memo += str;
            //        count = sr.Read(read, 0, 256);

            //    }
            //    sr.Close();
            //    myHttpWebResponse.Close();

            //    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //    doc.LoadHtml(memo);

            //    HtmlNode node = doc.GetElementbyId("content");

            //    this.richEditControl1.HtmlText = node.SelectSingleNode("//*[@class=\"context\"]").InnerHtml;

            //}
            //catch (Exception ex)
            //{

            //}

            #endregion
            
        }

        #region 更新TreeView


        void Refresh(string url)
        {
            if (url.Contains("cmono"))
            {
                var rssDoc = XDocument.Load(url);
                var query = (from blog in rssDoc.Descendants("item")
                             select new
                             {
                                 Title = blog.Element("title").Value,
                                 Link = blog.Element("link").Value
                             }).Take(20);

                this.labelControlSiteTitle.Text = query.ElementAt(0).Title;
                this.labelControlSiteDescription.Text = query.ElementAt(0).Title;
            }
            else if (url.Contains("cnblogs"))
            {
                var rssDoc = XDocument.Load(url);
                var query = (from blog in rssDoc.Descendants("entry")
                             select new
                             {
                                 Id = blog.Element("id").Value,
                                 Title = blog.Element("link").Value,
                                 Summary = blog.Element("summary").Value
                             }).Take(10);
                //XtraMessageBox.Show(query.Count().ToString());
                //this.labelControlSiteTitle.Text = query.ElementAt(0).Id;
                //this.labelControlSiteDescription.Text = query.ElementAt(0).Title;
            }
        }


        #endregion

        #region 检测网络状况，决定是读取本地还是网络数据

        /// <summary>
        /// 检测网络状况，决定是读取本地还是网络数据
        /// </summary>
        /// <returns></returns>
        private bool CheckNetworkStatus()
        {
            EnterpriseObjects.NetStatus netStatus = EnterpriseObjects.NetworkHelper.GetConnectionStatus("cmono.net");

            if (netStatus == EnterpriseObjects.NetStatus.None)
            {
                XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (netStatus == EnterpriseObjects.NetStatus.ModemUnlink)
            {
                XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (netStatus == EnterpriseObjects.NetStatus.LanCardUnlink)
            {
                XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        #endregion

        #region RSS源选择事件
        
        /// <summary>
        /// RSS源选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioGroupRssAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup radioGroup = sender as RadioGroup;
            int index = radioGroup.SelectedIndex;
            hyperLinkEditRssAddress.Text = radioGroup.Properties.Items[index].Value.ToString();
            Refresh(radioGroup.Properties.Items[index].Value.ToString());
        }

        #endregion

        #region 填充RadioGroup

        private void FillRadioGroup()
        {
            List<RssResource> rssResources = null;

            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                rssResources = ctx.Set<RssResource>().ToList();
            }

            if (rssResources != null)
            {
                RadioGroupItem rgi = null;
                foreach (var item in rssResources)
                {
                    rgi = new RadioGroupItem
                    {
                        Description = item.Description,
                        Value = item.Address
                    };
                    this.radioGroupRssAddress.Properties.Items.Add(rgi);
                }
                this.radioGroupRssAddress.SelectedIndex = 0;
            }

        }

        #endregion

        private void tvArticle_MouseClick(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// 删除RSS源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                int count = ctx.Set<RssResource>().Delete(r => r.Address == this.textEditRssAddress.EditValue.ToString());
                if (count == 1)
                {
                    //this.radioGroupRssAddress.Properties.Items.Remove(
                    XtraMessageBox.Show(this.LookAndFeel, "删除成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 修改RSS源，将其填充到输入框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int index = radioGroupRssAddress.SelectedIndex;
            this.textEditRssName.EditValue = radioGroupRssAddress.Properties.Items[index].Description;
            this.textEditRssAddress.EditValue = radioGroupRssAddress.Properties.Items[index].Value;
        }

    }
}

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
using DevExpress.XtraTab;
using System.Text.RegularExpressions;

namespace MBook
{
    public partial class RssForm : XtraForm
    {

        #region 窗体自身的方法

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
            //if (!CheckNetworkStatus())
            //{
            //    if (XtraMessageBox.Show(this.LookAndFeel, "貌似您没有连接上网络，是否读取本地数据", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            //    {
            //        this.Close();
            //    }
            //}

            FillRadioGroup();
            this.radioGroupRssAddress.SelectedIndex = -1;
            this.radioGroupRssAddress.SelectedIndexChanged += radioGroupRssAddress_SelectedIndexChanged;
            
            //InitTabPanel(0);

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


        #endregion
        
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
            }
        }


        #endregion

        #region 检测网络状况，决定是读取本地还是网络数据

        /// <summary>
        /// 检测网络状况，决定是读取本地还是网络数据
        /// </summary>
        /// <returns></returns>
        private bool CheckNetworkStatus(string url)
        {
            string domain = string.Empty;
            Regex reg = new Regex(@"(?imn)(http://(?<do>[^/]+)/)(?<dir>([^/]+/)*([^/.]*$)?)((?<page>[^?.]+\.[^?]+)\?)?(?<par>.*$)");
            MatchCollection mc = reg.Matches(url);
            domain = mc[0].Groups["do"].Value.ToString();
            //foreach (Match m in mc)
            //{
            //    Console.WriteLine(m.Groups["do"].Value);  //http://www.rczjp.cn/
            //    Console.WriteLine(m.Groups["dir"].Value); //A/B/C/
            //    Console.WriteLine(m.Groups["page"].Value);  //index.aspx
            //    Console.WriteLine(m.Groups["par"].Value); //cid=11&sid=22
            //}
            EnterpriseObjects.NetStatus netStatus = EnterpriseObjects.NetworkHelper.GetConnectionStatus(domain);

            if (netStatus == EnterpriseObjects.NetStatus.None)
            {
                //XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (netStatus == EnterpriseObjects.NetStatus.ModemUnlink)
            {
                //XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (netStatus == EnterpriseObjects.NetStatus.LanCardUnlink)
            {
                //XtraMessageBox.Show(this.LookAndFeel, EnterpriseObjects.EnumHelper.GetEnumDescription<EnterpriseObjects.NetStatus>(netStatus), "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            RadioGroupItem rgi = radioGroup.Properties.Items[index];
            string desc = rgi.Description.ToString();
            string url = rgi.Value.ToString();
            hyperLinkEditRssAddress.Text = url;
            //Refresh(radioGroup.Properties.Items[index].Value.ToString());
            UpdateTreeList(url);

            //更新TreeList


            //ShowPanel(rgi);
        }

        #endregion

        #region 填充RadioGroup

        /// <summary>
        /// 加载所有RSS源
        /// </summary>
        private void FillRadioGroup()
        {
            List<RssResource> rssResources = null;

            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                rssResources = ctx.Set<RssResource>().ToList();
            }
            if (rssResources != null)
            {
                this.radioGroupRssAddress.Properties.Items.Clear();

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
                //this.radioGroupRssAddress.SelectedIndex = 0;
            }

        }

        #endregion

        #region TreeView的方法

        private void tvArticle_MouseClick(object sender, MouseEventArgs e)
        {

        }


        #endregion

        #region 增删改查RSS源

        /// <summary>
        /// 删除RSS源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                string url = this.hyperLinkEditRssAddress.EditValue.ToString();
                int count = ctx.Set<RssResource>().Delete(r => r.Address == url);
                if (count == 1)
                {
                    XtraMessageBox.Show(this.LookAndFeel, "删除成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillRadioGroup();
                    this.radioGroupRssAddress.SelectedIndex = 0;
                    RemovePanel(url);
                }
                else
                {
                    XtraMessageBox.Show(this.LookAndFeel, "删除失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /// <summary>
        /// 添加RSS源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckNameAndAddress())
            {
                XtraMessageBox.Show(this.LookAndFeel, "必须输入RSS源名称和地址", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                int count = ctx.Set<RssResource>().Insert(new RssResource
                {
                    Address = textEditRssName.EditValue.ToString(),
                    Description = textEditRssAddress.EditValue.ToString()
                });
                if (count == 1)
                {
                    //this.radioGroupRssAddress.Properties.Items.Remove(
                    XtraMessageBox.Show(this.LookAndFeel, "成功添加RSS源成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillRadioGroup();
                }
            }

        }

        /// <summary>
        /// 更新RSS源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckNameAndAddress())
            {
                XtraMessageBox.Show(this.LookAndFeel, "必须输入RSS源名称和地址", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


        private bool CheckNameAndAddress()
        {
            if (string.IsNullOrEmpty(textEditRssName.EditValue == null ? "" : textEditRssName.EditValue.ToString()) || string.IsNullOrEmpty(textEditRssAddress.EditValue == null ? "" : textEditRssAddress.EditValue.ToString()))
            {
                return false;
            }
            return true;
        }

        #endregion

        #region TabPanel

        /// <summary>
        /// 初始化
        /// </summary>
        void InitTabPanel(int index)
        {
            //this.xtraTabPage1.Text = this.radioGroupRssAddress.Properties.Items[this.radioGroupRssAddress.SelectedIndex].Description;
            //this.xtraTabPage1.Tag = this.radioGroupRssAddress.Properties.Items[this.radioGroupRssAddress.SelectedIndex].Value;
        }

        /// <summary>
        /// 根据标题显示Panel
        /// </summary>
        /// <param name="title"></param>
        void ShowPanel(RadioGroupItem rgi)
        {
            XtraTabPage page = null;
            var query = this.xtraTabControl1.TabPages.Where(t => t.Tag.ToString() == rgi.Value.ToString());
            
            page = query.ElementAtOrDefault(0);

            if (page == null)
            {
                page = new XtraTabPage
                {
                    Text = rgi.Description,
                    Tag = rgi.Value
                };
                page.Controls.Add(new TreeListTabPage {  Dock = DockStyle.Fill});
                this.xtraTabControl1.TabPages.Add(page);
            }
            page.PageVisible = true;
            this.xtraTabControl1.SelectedTabPage = page;
        }

        /// <summary>
        /// 根据url地址移除Panel
        /// </summary>
        /// <param name="title"></param>
        void RemovePanel(string url)
        {
            XtraTabPage page = null;
            var query = this.xtraTabControl1.TabPages.Where(t => t.Tag.ToString() == url);
            page = query.ElementAtOrDefault(0);
            if (page != null)
            {
                this.xtraTabControl1.TabPages.Remove(page);
            }
        }

        /// <summary>
        /// 关闭标签页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this.LookAndFeel, "是否真的要关闭?", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                (sender as XtraTabControl).SelectedTabPage.PageVisible = false;
                this.radioGroupRssAddress.SelectedIndex = 0;
            }
        }

        #endregion

        #region TreeList

        private void UpdateTreeList(string url)
        {
            if (!CheckNetworkStatus(url))
            {
                if (XtraMessageBox.Show(this.LookAndFeel, "貌似您没有连接上网络，是否读取本地数据", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }

            XDocument doc = XDocument.Load(url);
            MessageBox.Show(doc.Descendants("title").ElementAt(0).Value);
        }

        #endregion




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       RssItem
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          RssItem
     * Created Time       2012/12/16 15:14:08
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// RSS节点对象
    /// </summary>
    /// 
    public class RssItem
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 连接地址
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 内容简要描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PubDate { get; set; }

        /// <summary>
        /// 目录、类别
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string Guid { get; set; }

        /// <summary>
        /// 条目节点
        /// </summary>
        public XElement Item
        {
            get
            {
                XElement item = new XElement(
                    "item",
                    new XElement("title",this.Title),
                    new XElement("link",this.Link),
                    new XElement("description",new  XCData(this.Description)),
                    new XElement("pubDate",this.PubDate.ToString("r")),
                    new XElement("category",this.Category),
                    new XElement("author",this.Author),
                    new XElement("guid",this.Guid)
                );

                return item;
            }
        }
    }
}

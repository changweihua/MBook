using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       RssWriter
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          RssWriter
     * Created Time       2012/12/16 15:22:30
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// RSS 2.0 生成
    /// </summary>
    /// 
    public class RssWriter
    {
        #region 变量

        /// <summary>
        /// RSS注释
        /// </summary>
        public string RssComment { get; set; }

        /// <summary>
        /// 频道标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 频道总地址
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 频道说明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 频道语言
        /// </summary>
        public RssLanguage Language { get; set; }

        /// <summary>
        /// 频道发布时间
        /// </summary>
        public DateTime PubDate { get; set; }

        /// <summary>
        /// 频道最后更新时间
        /// </summary>
        public DateTime  LastBuildDate { get; set; }

        /// <summary>
        /// 此RSS文档地址
        /// </summary>
        public string Docs { get; set; }

        /// <summary>
        /// 信息条目集合
        /// </summary>
        public List<RssItem> Items { get; private set; }

        #endregion

        #region 构造函数

        public RssWriter()
        {
            this.Items = new List<RssItem>();
            this.Language = RssLanguage.SimplifiedChinese;
        }

        #endregion

        #region 方法

        /// <summary>
        /// 生成RSS，并按照字符串的形式返回
        /// </summary>
        /// <returns></returns>
        public string Build()
        {
            return this.Build(null, null);
        }

        /// <summary>
        /// 生成RSS，并写入一个流
        /// </summary>
        /// <param name="stream"></param>
        public void Build(Stream stream)
        {
            this.Build(null, stream);
        }

        /// <summary>
        /// 生成RSS并写入到文件
        /// </summary>
        /// <param name="fileName"></param>
        public void Build(string fileName)
        {
            this.Build(fileName, null);
        }

        public string Build(string fileName, Stream stream)
        {
            XElement channel = new XElement(
                "channel",
                new XElement("title", this.Title),
                new XElement("link", this.Link),
                new XElement("description", this.Title),
                new XElement("language", EnumHelper.GetEnumDescription<RssLanguage>(this.Language)),
                new XElement("pubDate", this.PubDate.ToString("r")),
                new XElement("lastBuildDate", this.LastBuildDate.ToString("r")),
                new XElement("docs", this.Docs)
                );

            XElement rss = new XElement("rss", new XAttribute("version", "2.0"), channel);

            XDocument rssDoc = new XDocument(new XDeclaration("1.0", "utf-8", null), new XComment(this.RssComment), rss);

            foreach (RssItem item in this.Items)
            {
                channel.Add(item.Item);
            }

            if (!string.IsNullOrEmpty(fileName))
            {
                rssDoc.Save(fileName);
            }

            if (stream != null)
            {
                using (XmlWriter writer = XmlWriter.Create(stream))
                {
                    rssDoc.WriteTo(writer);
                    writer.Flush();
                }

            }

            string content = null;

            using (StringWriter sw = new StringWriter())
            {
                rssDoc.Save(sw, SaveOptions.None);
                sw.Flush();
                content = sw.ToString();
            }

            return content;


        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       Site
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          Site
     * Created Time       2012/12/18 15:52:36
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 不同时间的RSS源的文章
    /// </summary>
    /// 
    [Table(Name="tbSiteRecord")]
    public class SiteRecord
    {
        /// <summary>
        /// 唯一标识，即RSS地址
        /// </summary>
        /// 
        [Column(Name="guid")]
        public string Guid;
        /// <summary>
        /// 站点标题
        /// </summary>
        /// 
        [Column(Name="title")]
        public string Title;
        /// <summary>
        /// 站点描述
        /// </summary>
        /// 
        [Column(Name = "description")]
        public string Description;

        [Association(ThisKey = "Guid", OtherKey = "Guid")]
        public IList<RssEntity> RssEntities;

    }

    /// <summary>
    /// 文章
    /// </summary>
    /// 
    [Table(Name="tbRssEntity")]
    public class RssEntity
    {
        /// <summary>
        /// 文章链接
        /// </summary>
        /// 
        [Id(Name = "id")]
        public int? id;
        /// <summary>
        /// 文章链接
        /// </summary>
        /// 
        [Column(Name = "link")]
        public string Link;
        /// <summary>
        /// 所属站点
        /// </summary>
        /// 
        [Column(Name = "guid")]
        public string Guid;
        /// <summary>
        /// 文章标题
        /// </summary>
        /// 
        [Column(Name = "title")]
        public string Title;
        
        /// <summary>
        /// 发布时间
        /// </summary>
        /// 
        [Column(Name = "pubdate")]
        public string PubDate;
        /// <summary>
        /// 作者
        /// </summary>
        /// 
        [Column(Name = "author")]
        public string Author;
        /// <summary>
        /// 文章摘要
        /// </summary>
        /// 
        [Column(Name = "summary")]
        public string Summary;
        /// <summary>
        /// 文章内容
        /// </summary>
        /// 
        [Column(Name = "content")]
        public string Content;
        /// <summary>
        /// 添加日期
        /// </summary>
        /// 
        [Column(Name = "addDate")]
        public string AddDate;
    }

}

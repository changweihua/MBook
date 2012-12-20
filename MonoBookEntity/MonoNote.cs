using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    [Table(Name="mononote")]
    public class MonoNote
    {
        /// <summary>
        /// 自动编号
        /// </summary>
        /// 
        [Id(Name="id")]
        public int Id;

        /// <summary>
        /// Guid
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
        /// 文章内容
        /// </summary>
        /// 
        [Column(Name = "content")]
        public string Content;

        /// <summary>
        /// 文章标签
        /// </summary>
        /// 
        [Column(Name = "tag")]
        public string Tag;

        /// <summary>
        /// 创建日期
        /// </summary>
        /// 
        [Column(Name = "createdate")]
        public DateTime CreateDate;

        /// <summary>
        /// 更新日期
        /// </summary>
        /// 
        [Column(Name = "updatedate")]
        public DateTime UpdateDate;

        /// <summary>
        /// 文章等级
        /// </summary>
        /// 
        [Column(Name = "grade")]
        public double Grade;
    }
}

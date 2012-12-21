using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       Note
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          Note
     * Created Time       2012/12/12 10:26:42
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 笔记实体类
    /// </summary>
    /// 
    [Table(Name="tbNote")]
    [Serializable]
    public class Note
    {
        [Id(Name = "n_guid")]
        public string Guid { get; set; }

        [Column(Name = "n_title")]
        public string Title { get; set; }

        [Column(Name = "n_content")]
        public string Content { get; set; }

        [Column(Name = "n_create_date")]
        public string CreateDate { get; set; }

        [Column(Name = "n_update_date")]
        public string UpdateDate { get; set; }

        [Column(Name = "n_attachment")]
        public string Attachment { get; set; }

        [Column(Name = "n_tag")]
        public string Tag { get; set; }

        [Column(Name = "n_record_type_id")]
        public int RecordType { get; set; }

        [Column(Name = "n_is_sync")]
        public int? IsSync { get; set; }
    }
}

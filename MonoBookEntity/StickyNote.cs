using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       StickyNote
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          StickyNote
     * Created Time       2012/12/11 19:42:13
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 编辑
    /// </summary>
    /// 
    [Table(Name="tbStickyNote")]
    [Serializable]
    public class StickyNote
    {
        [Id(Name = "sn_guid")]
        public string Guid { get; set; }
        [Id(Name = "sn_update_date")]
        public string UpdateDate { get; set; }
        [Id(Name = "sn_content")]
        public string Content { get; set; }
        [Id(Name = "sn_record_type_id")]
        public int RecordType { get; set; }
    }
}

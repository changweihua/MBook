using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       Event
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          Event
     * Created Time       2012/12/15 0:05:10
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 添加类描述
    /// </summary>
    /// 
    [Table(Name="tbEvent")]
    public class Event
    {
        [Id(Name="e_guid")]
        public string Guid { get; set; }
        [Column(Name = "e_status")]
        public int Status { get; set; }
        [Column(Name = "e_subject")]
        public string Subject { get; set; }
        [Column(Name = "e_description")]
        public string Description { get; set; }
        [Column(Name = "e_start_time")]
        public string StartTime { get; set; }
        [Column(Name = "e_end_time")]
        public string EndTime { get; set; }
        [Column(Name = "e_all_day")]
        public bool AllDay { get; set; }
        [Column(Name = "e_event_type")]
        public int EventType { get; set; }
        [Column(Name = "e_recurrent_info")]
        public string RecurrentInfo { get; set; }
        [Column(Name = "e_remide")]
        public string Remide { get; set; }
    }
}

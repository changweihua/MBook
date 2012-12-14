using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       UserScheduler
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          UserScheduler
     * Created Time       2012/12/15 0:21:32
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
    [Table(Name="tbScheduler")]
    public class UserScheduler
    {
        [Id(Name="guid")]
        public string Guid { get; set; }
        [Column(Name="username")]
        public string UserName { get; set; }
        [Column(Name = "appallday")]
        public int AppAllDay { get; set; }
        [Column(Name = "appdescription")]
        public string AppDescription { get; set; }
        [Column(Name = "append")]
        public DateTime AppEnd { get; set; }
        [Column(Name = "applabel")]
        public int AppLabel { get; set; }
        [Column(Name = "applocation")]
        public string AppLocation { get; set; }
        [Column(Name = "apprecurrenceinfo")]
        public string AppRecurrenceInfo { get; set; }
        [Column(Name = "appreminderinfo")]
        public string AppReminderInfo { get; set; }
        [Column(Name = "appresourceid")]
        public int AppResourceId { get; set; }
        [Column(Name = "appstart")]
        public DateTime AppStart { get; set; }
        [Column(Name = "appstatus")]
        public string AppStatus { get; set; }
        [Column(Name = "appsubject")]
        public string AppSubject { get; set; }
        [Column(Name = "apptype")]
        public string AppType { get; set; }
    }
}

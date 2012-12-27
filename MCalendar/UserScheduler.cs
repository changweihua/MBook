using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalendar
{
    public class UserScheduler
    {
        public string Guid { get; set; }
        public string UserName { get; set; }
        public int AppAllDay { get; set; }
        public string AppDescription { get; set; }
        public DateTime AppEnd { get; set; }
        public int AppLabel { get; set; }
        public string AppLocation { get; set; }
        public string AppRecurrenceInfo { get; set; }
        public string AppReminderInfo { get; set; }
        public int AppResourceId { get; set; }
        public DateTime AppStart { get; set; }
        public string AppStatus { get; set; }
        public string AppSubject { get; set; }
        public string AppType { get; set; }
    }
}

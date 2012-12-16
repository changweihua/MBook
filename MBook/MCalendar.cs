using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NLite.Data;
using MonoBookEntity;
using DevExpress.XtraScheduler;

namespace MBook
{
    /*************************************************************************************
     * CLR  版本:       4.0.30319.586
     * 类 名 称:       MCalendar
     * 机器名称:       HSERVER
     * 命名空间:       MBook
     * 文 件 名:       MCalendar
     * 创建时间:       2012/12/4  12:26:44
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    public partial class MCalendar : XtraForm
    {
        public MCalendar()
        {
            InitializeComponent();
        }

        List<UserScheduler> userSchedulers = null;
       AppointmentCollection schedulers = null;

        private void MCalendar_Load(object sender, EventArgs e)
        {

            schedulerStorage1.Appointments.Mappings.AllDay="AppAllDay";
            schedulerStorage1.Appointments.Mappings.Description = "AppDescription";
            schedulerStorage1.Appointments.Mappings.End = "AppEnd";
            schedulerStorage1.Appointments.Mappings.Label = "AppLabel";
            schedulerStorage1.Appointments.Mappings.Location = "AppLocation";
            schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "AppRecurrenceInfo";
            schedulerStorage1.Appointments.Mappings.ReminderInfo = "AppReminderInfo";
            schedulerStorage1.Appointments.Mappings.Start = "AppStart";
            schedulerStorage1.Appointments.Mappings.Status = "AppStatus";
            schedulerStorage1.Appointments.Mappings.Subject = "AppSubject";
            schedulerStorage1.Appointments.Mappings.Type = "AppType";
            //schedulerStorage1.Appointments.Mappings.ResourceId = "AppResourceId";
            schedulerStorage1.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Guid", "Guid"));
            FillSchedule();
            schedulers = schedulerStorage1.Appointments.Items;
            
        }


        void FillSchedule()
        {
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                userSchedulers = ctx.Set<UserScheduler>().ToList();
            }
            dateNavigator1.DateTime = DateTime.Now;
            schedulerStorage1.Appointments.DataSource = userSchedulers;
            schedulerControl1.Start = DateTime.Now;
        }

        //todo
        //删除日历项，通过比较Guid，进行删除
        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            int count = 0;

            var schedules = schedulerStorage1.Appointments.Items;

            List<UserScheduler> newSchedules = new List<UserScheduler>();
            List<UserScheduler> oldSchedules = new List<UserScheduler>();

            int maxResourceId = 0;

            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                maxResourceId = ctx.Set<UserScheduler>().Max(u => u.AppResourceId);
            }

            //MessageBox.Show(maxResourceId.ToString());
            //return;
            foreach (var item in schedules)
            {
                if (item.CustomFields["Guid"] == null)
                {
                    newSchedules.Add(new UserScheduler
                    {
                        Guid = Guid.NewGuid().ToString(),
                        AppAllDay = item.AllDay ? 1 : 0,
                        AppDescription = item.Description,
                        AppEnd = item.End == DateTime.MinValue ? DateTime.MinValue : item.End,
                        AppLabel = item.LabelId,
                        AppLocation = string.IsNullOrEmpty(item.Location) ? "" : item.Location,
                        //AppRecurrenceInfo = item.RecurrenceInfo == null ? "" : item.RecurrenceInfo.ToXml(),
                        //AppReminderInfo = item.Reminder == null ? "" : item.Reminder.ToString(),
                        //AppResourceId = item.ResourceId == null ? 0 : ++maxResourceId,
                        AppStart = item.Start == DateTime.MinValue ? DateTime.MinValue : item.Start,
                        AppStatus = item.StatusId.ToString(),
                        AppSubject = item.Subject,
                        AppType = item.Type.ToString()
                    });
                }
                else
                {
                    oldSchedules.Add(new UserScheduler
                    {
                        Guid = item.CustomFields["Guid"].ToString(),
                        AppAllDay = item.AllDay ? 1 : 0,
                        AppDescription = item.Description,
                        AppEnd = item.End==DateTime.MinValue?DateTime.MinValue:item.End,
                        AppLabel = item.LabelId,
                        AppLocation = string.IsNullOrEmpty(item.Location) ? "" : item.Location,
                        //AppRecurrenceInfo = item.RecurrenceInfo == null ? "" : item.RecurrenceInfo.ToXml(),
                        //AppReminderInfo = item.Reminder == null ? "" : item.Reminder.ToString(),
                        //AppResourceId = item.ResourceId == null ? 0 : (int)item.ResourceId,
                        AppStart = item.Start==DateTime.MinValue?DateTime.MinValue:item.Start,
                        AppStatus = item.StatusId.ToString(),
                        AppSubject = item.Subject,
                        AppType = item.Type.ToString()
                    });
                }
            }

            
            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                foreach (var oldSchedule in oldSchedules)
                {
                    count+=ctx.Set<UserScheduler>().Update(oldSchedule);
                }
            }

            using (var ctx = DbConfiguration.Items["Mono"].CreateDbContext())
            {
                foreach (var newSchedule in newSchedules)
                {
                    count += ctx.Set<UserScheduler>().Insert(newSchedule);
                }
            }

            if (count == schedules.Count)
            {
                FillSchedule();
                schedulers = schedulerStorage1.Appointments.Items;
                XtraMessageBox.Show(this.LookAndFeel, "保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(this.LookAndFeel, "保存失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //this.schedulerStorage1.Appointments.BeginUpdate();
        }

    }
}

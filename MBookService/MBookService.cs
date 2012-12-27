using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using NLite.Data;
using NLog;

namespace MBookService
{
    partial class MBookService : ServiceBase
    {
        static Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public MBookService()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer = null;
        UserScheduler scheduler = null;
        List<UserScheduler> schedulers = null;
        DbConfiguration cfg = null;

        protected override void OnStart(string[] args)
        {
            try
            {
                // TODO: 在此处添加代码以启动服务。
                timer = new System.Timers.Timer();
                timer.Interval = 1000;
                timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
                logger.Trace(args[0]);
                logger.Trace(args[1]);
                logger.Trace(DbConfiguration.Configure(DbConfiguration.BuildSQLiteConnectionString(args[0], false), args[1]).ConnectionString);
                cfg = DbConfiguration.Configure(DbConfiguration.BuildSQLiteConnectionString(args[0], false), args[1]).AddClass<UserScheduler>();
                //logger.Trace(DbConfiguration.Configure(DbConfiguration.BuildSQLiteConnectionString(@"E:\VS2010\MBook\MBook\bin\Debug\Data.db", false), "System.Data.SQLite").ConnectionString);
                //cfg = DbConfiguration.Configure(DbConfiguration.BuildSQLiteConnectionString(@"E:\VS2010\MBook\MBook\bin\Debug\Data.db", false), "System.Data.SQLite").AddClass<UserScheduler>();
                logger.Trace(cfg == null);
                logger.Debug("注册数据库");
                timer.Enabled = true;
                logger.Debug("启动Timer控件");
                logger.Debug("启动服务");
                RefreshScheduler();
            }
            catch (Exception ex)
            {
                //logger.Error(DbConfiguration.Configure(DbConfiguration.BuildSQLiteConnectionString(@"E:\VS2010\MBook\MBook\bin\Debug\Data.db", false), "System.Data.SQLite").ConnectionString);
                logger.Error(DbConfiguration.Configure(DbConfiguration.BuildSQLiteConnectionString(args[0], false), args[1]).ConnectionString);
                logger.Error("启动发生错误" + ex.Message);
            }
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                DateTime now = e.SignalTime;
                logger.Debug("当前时间" + now.ToString("yyyy-MM-dd hh:mm:ss"));
                scheduler = schedulers.Count > 0 ? schedulers[0] : null;
                if (scheduler != null)
                {
                    logger.Debug("任务时间" + scheduler.AppStart.ToString());
                    logger.Debug("当前时间" + now.ToString());
                    logger.Debug("时间对比" + DateTime.Compare(Convert.ToDateTime(now.ToString("yyyy-MM-dd hh:mm:ss")), Convert.ToDateTime(scheduler.AppStart.ToString("yyyy-MM-dd hh:mm:ss"))).ToString());
                    if (DateTime.Compare(Convert.ToDateTime(now.ToString("yyyy-MM-dd hh:mm:ss")), Convert.ToDateTime(scheduler.AppStart.ToString("yyyy-MM-dd hh:mm:ss"))) == 0)
                    {
                        logger.Debug(scheduler.AppSubject);
                        Remind();
                    }
                }
                RefreshScheduler();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
            
        }

        /// <summary>
        /// 获取最新
        /// </summary>
        void RefreshScheduler()
        {
            using (var ctx = cfg.CreateDbContext())
            {
                schedulers = ctx.Set<UserScheduler>().Where(s => DateTime.Compare(s.AppStart, DateTime.Now) > 0 ? true : false).OrderBy(s => s.AppStart).ToList();
            }
        }

        /// <summary>
        /// 提醒
        /// </summary>
        void Remind()
        {
            logger.Debug(scheduler.AppSubject + "时间到了");
            logger.Trace("开始调用提醒窗体");
            scheduler = null;
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            timer.Enabled = false;
            logger.Trace("停止服务");
        }
    }
}

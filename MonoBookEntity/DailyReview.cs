using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       DailyReview
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       DailyReview
     * 创建时间:       2012/12/5  17:05:36
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    /// <summary>
    /// 每日回顾实体类
    /// </summary>
    
    [Table(Name="tbDailyReview")]
    public class DailyReview
    {
        /// <summary>
        /// Guid标识符
        /// </summary>
        [Id(Name = "dr_guid")]
        public string Guid;

        /// <summary>
        /// 日期
        /// </summary>
        [Column(Name = "dr_today_date")]
        public string TodayDate;

        /// <summary>
        /// 今日天气
        /// </summary>
        [Column(Name = "dr_today_weather")]
        public string TodayWeather;

        /// <summary>
        /// 日子
        /// </summary>
        [Column(Name = "dr_today_desc")]
        public string TodayDescrption;

        /// <summary>
        /// 纪念日
        /// </summary>
        [Column(Name = "dr_commenoration_day")]
        public string CommemorationDay;

        /// <summary>
        /// 命运日
        /// </summary>
        [Column(Name = "dr_fortune_day")]
        public string FortuneDay;

        /// <summary>
        /// 相遇日
        /// </summary>
        [Column(Name = "dr_meetion_day")]
        public string MeetionDay;

        /// <summary>
        /// 起床时间
        /// </summary>
        [Column(Name = "dr_today_getuptime")]
        public string TodayGetupTime;

        /// <summary>
        /// 昨天睡觉时间
        /// </summary>
        [Column(Name = "dr_yesterday_sleeptime")]
        public string YesterdaySleepTime;

        /// <summary>
        /// 今天心情
        /// </summary>
        [Column(Name = "dr_today_mood")]
        public string TodayMood;

        /// <summary>
        /// 灵感涂鸦
        /// </summary>
        [Column(Name = "dr_inspiration")]
        public string Inspiration;

        /// <summary>
        /// 昨天的不足
        /// </summary>
        [Column(Name = "dr_yesterday_shortage")]
        public string YesterdayShortage;

        /// <summary>
        /// 昨天的进步
        /// </summary>
        [Column(Name = "dr_yesterday_progress")]
        public string YesterdayProgress;

        /// <summary>
        /// 今天的感悟和收获
        /// </summary>
        [Column(Name = "dr_today_gains")]
        public string TodayGains;

        /// <summary>
        /// 今天阅读的书目和理解(非专业书籍)
        /// </summary>
        [Column(Name = "dr_today_books_notmajored")]
        public string TodayBooksNotMajored;

        /// <summary>
        /// 专业关注和理解(专业)
        /// </summary>
        [Column(Name = "dr_today_books_majored")]
        public string TodayBooksMajored;
    }
}

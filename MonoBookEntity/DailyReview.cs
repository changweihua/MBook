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
    /// 添加类描述
    /// </summary>
    
    [Table(Name="tbDailyReview")]
    public class DailyReview
    {
        [Id(Name="")]
        public string TodayDate;
        [Column]
        public string TodayWeather;
        [Column]
        public string TodayDescrption;
        [Column]
        public string CommemorationDay;
        [Column]
        public string FortuneDay;
        [Column]
        public string MeetionDay;
        [Column]
        public string TodayGetupTime;
        [Column]
        public string YesterdaySleepTime;
        [Column]
        public string TodayMood;
        [Column]
        public string Inspiration;
        [Column]
        public string YesterdayShortage;
        [Column]
        public string YesterdayProgress;
        [Column]
        public string TodayGains;
        [Column]
        public string TodayBooksNotMajored;
        [Column]
        public string TodayBooksMajored;
    }
}

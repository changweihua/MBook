using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       GridDailyModel
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          GridDailyModel
     * Created Time       2012/12/11 14:04:09
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
    [Serializable]
    public class GridDailyModel
    {
        public string Guid { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        public string Title { get; set; }
        public string TodayDate { get; set; }
        public string Weather { get; set; }
        public string TodayDesc { get; set; }
        public string TodayBirthday { get; set; }
        public List<DailyGrid> DailyGrids { get; set; }
    }
}

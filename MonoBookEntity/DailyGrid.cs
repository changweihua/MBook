using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       DailyGrid
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          DailyGrid
     * Created Time       2012/12/11 13:23:50
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 九宫格日记的格子
    /// </summary>
    /// 
    [Serializable]
    public class DailyGrid
    {
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 副标题
        /// </summary>
        public string SubHeading { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}

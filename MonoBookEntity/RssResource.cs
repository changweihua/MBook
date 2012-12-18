using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       RssResource
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          RssResource
     * Created Time       2012/12/16 21:42:14
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
    [Table(Name="tbRssResource")]
    public class RssResource
    {
        [Column(Name="description")]
        public string Description { get; set; }

        [Column(Name = "address")]
        public string Address { get; set; }
    }
}

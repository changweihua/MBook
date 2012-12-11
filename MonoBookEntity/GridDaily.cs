using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       GridDaily
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       GridDaily
     * 创建时间:       2012/12/5  17:29:47
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
    /// 九宫格日记实体类
    /// </summary>
    
    [Table(Name="tbGridDaily")]
    public class GridDaily
    {
        /// <summary>
        /// Guid编号
        /// </summary>
        [Id(Name = "gd_guid")]
        public string Guid;

        /// <summary>
        /// 内容
        /// </summary>
        [Column(Name="gd_content")]
        public string Content;

        /// <summary>
        /// 记录类型
        /// </summary>
        [Column(Name = "gd_record_type_id")]
        public int RecordType;

        /// <summary>
        /// 记录日期
        /// </summary>
        [Column(Name = "gd_create_date")]
        public string CreateDate;

        /// <summary>
        /// 修改日期
        /// </summary>
        [Column(Name = "gd_update_date")]
        public string UpdateDate;

    }
}

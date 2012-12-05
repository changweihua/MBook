using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       Index
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       Index
     * 创建时间:       2012/12/5  22:02:33
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
    /// 索引实体类
    /// </summary>
    
    [Table(Name="tbIndex")]
    public class Index
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Id(Name="i_id")]
        public int Id;

        /// <summary>
        /// 记录Guid标识符
        /// </summary>
        [Column(Name="i_guid")]
        public string Guid;

        /// <summary>
        /// 记录类别编号
        /// </summary>
        [Column(Name="i_type_id")]
        public int TypeId;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       Grade
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       Grade
     * 创建时间:       2012/12/6  13:10:26
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
    /// 用户等级实体类
    /// </summary>
    
    [Table(Name="tbGrade")]
    public class Grade
    {
        /// <summary>
        /// 等级编号
        /// </summary>
        [Id]
        public int Id;

        /// <summary>
        /// 等级名称
        /// </summary>
        [Column]
        public string Name;

        /// <summary>
        /// 等级积分
        /// </summary>
        [Column]
        public int Count;

    }
}

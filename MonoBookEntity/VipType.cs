using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       VipType
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       VipType
     * 创建时间:       2012/12/5  13:24:23
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
    /// VIP级别类
    /// </summary>
    [Table(Name="tbVipType")]
    public class VipType
    {
        /// <summary>
        /// Guid标识符
        /// </summary>
        [Id(Name = "vt_id")]
        public int VipTypeId;

        /// <summary>
        /// VIP级别名称
        /// </summary>
        [Column(Name = "vt_name")]
        public string VipTypeName;

        /// <summary>
        /// VIP每月流量
        /// </summary>
        [Column(Name = "vt_flow")]
        public int VipTypeFlow;

        /// <summary>
        /// 积分数量要求
        /// </summary>
        [Column(Name = "vt_upgrade_count")]
        public int VipTypeUpgradeCount;

        /// <summary>
        /// 会员费/月
        /// </summary>
        [Column(Name = "vt_month_day")]
        public double VipTypeMonthPay;

    }
}

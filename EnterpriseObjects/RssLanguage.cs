using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       RssLanguage
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          RssLanguage
     * Created Time       2012/12/16 15:11:35
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// RSS语言类型
    /// </summary>
    /// 

    public enum RssLanguage
    {
        [EnumDescription("zh-cn")]
        SimplifiedChinese,
        [EnumDescription("en-us")]
        AmericanEnglish
    }

}

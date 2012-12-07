using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       SingletonHelper
     * 机器名称:       HSERVER
     * 命名空间:       EnterpriseObjects
     * 文 件 名:       SingletonHelper
     * 创建时间:       2012/12/7  10:21:51
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
    public class Singleton<T> where T : new()
    {
        public static T Instance
        {
            get { return SingletonCreator.instance; }
        }

        class SingletonCreator
        {
            internal static readonly T instance = new T();
        }

    }
}

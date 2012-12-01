using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       Folder
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       Folder
     * 创建时间:       2012/12/1 21:33:15
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
    /// 文件夹信息类
    /// </summary>
    public class Folder
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 文件夹显示名称
        /// </summary>
        public string FolderName { get; set; }
        /// <summary>
        /// 文件夹真实名称
        /// </summary>
        public string FolderPath { get; set; }
        /// <summary>
        /// 是否是叶子节点
        /// </summary>
        public bool IsLeaf { get; set; }
    }
}

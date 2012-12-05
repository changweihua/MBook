using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       RecordType
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       RecordType
     * 创建时间:       2012/12/5  22:02:50
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
    /// 记录类型实体类
    /// </summary>
    
    [Table(Name="tbRecordType")]
    public class RecordType
    {
        /// <summary>
        /// 类别编号
        /// </summary>
        [Id(Name="rt_id")]
        public int Id;

        /// <summary>
        /// 类别名称
        /// </summary>
        [Column(Name="rt_name")]
        public string Name;

        /// <summary>
        /// 类别文件夹名称
        /// </summary>
        [Column(Name="rt_folder_path")]
        public string FolderPath;
    }
}

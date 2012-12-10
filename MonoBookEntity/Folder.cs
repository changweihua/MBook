using System;
using System.Collections.Generic;
using System.Text;
using NLite.Data;


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
    /// 
    [NLite.Data.Table(Name = "tbFolder")]
    public class Folder
    {
        /// <summary>
        /// 编号
        /// </summary>
        /// 
        [Id(IsDbGenerated=true,Name="f_id")]
        public int Id { get; set; }

        /// <summary>
        /// 文件夹显示名称
        /// </summary>
        /// 
        [Column(Name="f_display_name")]
        public string FolderName { get; set; }

        /// <summary>
        /// 文件夹真实名称
        /// </summary>
        /// 
        [Column(Name = "f_name")]
        public string FolderPath { get; set; }

        /// <summary>
        /// 父节点编号
        /// </summary>
        /// 
        [Column(Name = "f_parent_id")]
        public int parentId { get; set; }

        [Column(Name = "f_record_type_id")]
        public int RecordTypeId { get; set; }
    }
}

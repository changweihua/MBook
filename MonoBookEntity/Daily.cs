using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.296
     * Class   Name       Daily
     * Machine Name       LUMIA800
     * Namespace          MonoBookEntity
     * File Name          Daily
     * Created Time       2012/12/10 11:37:06
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 日记实体类
    /// </summary>
    /// 
    [Table(Name = "tbDaily")]
    public class Daily
    {
        [Id(Name = "d_guid")]
        public string Guid;
        [Column(Name = "d_create_date")]
        public string CreateDate;
        [Column(Name = "d_update_date")]
        public string UpdateDate;
        [Column(Name = "d_secret")]
        public bool IsSecret;
        [Column(Name = "d_password")]
        public string Password;
        [Column(Name = "d_record_type_id")]
        public int RecordType;
    }
}

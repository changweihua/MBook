using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;
using MonoBookEntity;

namespace MBook
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.296
     * Class   Name       MonoBookDBContext
     * Machine Name       LUMIA800
     * Namespace          MBook
     * File Name          MonoBookDBContext
     * Created Time       2012/12/9 16:53:46
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// MonoBook程序的数据库操作类
    /// </summary>
    /// 
    public class MonoBookDBUtil
    {
        const string connectionStringName = "Mono";

         static DbConfiguration config = DbConfiguration.Configure("Mono")
            .AddClass<Index>()
            .AddClass<Folder>();

         private IDbContext dbContext;

         public MonoBookDBUtil()
         {
             this.dbContext = config.CreateDbContext();
         }

         public virtual IDbSet<Folder> Folders
         {
             get
             {
                 return this.dbContext.Set<Folder>();
             }
         }

         public virtual IDbSet<Index> Indexs
         {
             get
             {
                 return this.dbContext.Set<Index>();
             }
         }

    }
}

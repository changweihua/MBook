using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lucene.Net.Index;
using Lucene.Net.Documents;

namespace EnterpriseObjects
{
    /// <summary>
    /// 使用Lucene.NET实现索引功能
    /// </summary>
    public class IndexHelper
    {

        /// <summary>
        /// 创建索引
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fieldNames">索引项名称</param>
        /// <param name="fieldValues">索引项值</param>
        private void CreateIndex(IndexWriter writer, string[] fieldNames, string [] fieldValues)
        {
           Document doc = new Document();

           for (int i = 0; i < fieldNames.Length; i++)
           {
               doc.Add(new Field(fieldNames[i], fieldValues[i], Field.Store.YES, Field.Index.ANALYZED));
           }

            writer.AddDocument(doc);
            writer.Commit();
        }

        /// <summary>
        /// 创建索引Doc文件的项Field
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fieldName"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        private IFieldable CreateField(IndexWriter writer, string fieldName, string fieldValue)
        {
            var field = new Field(fieldName, fieldValue, Field.Store.YES, Field.Index.ANALYZED);
            return field;
        }

    }




}

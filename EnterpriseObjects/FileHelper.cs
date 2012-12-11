using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       FileHelper
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          FileHelper
     * Created Time       2012/12/11 20:11:01
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 文件帮助类
    /// </summary>
    /// 
    public class FileHelper
    {
        #region 文件夹操作方法

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool DeleteFile(string filePath)
        {
            bool flag = false;

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }


        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="sourceFolder">原文件夹</param>
        /// <param name="targetFolder">目的文件夹</param>
        /// <returns></returns>
        public static bool RemoveFile(string fileName, string sourceFolder, string targetFolder)
        {
            bool flag = false;

            string source = string.Format(@"{0}\{1}.mono", sourceFolder, fileName);
            string target = string.Format(@"{0}\{1}.mono", targetFolder, fileName);

            if (File.Exists(source))
            {
                try
                {
                    File.Move(source, target);
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// 检查否见是否存在
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool CheckFile(string filePath)
        {
            bool flag = false;
            if (File.Exists(filePath))
            {
                flag = true;
            }
            return flag;
        }

        #endregion
    }
}

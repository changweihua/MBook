﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       DirectoryHelper
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          DirectoryHelper
     * Created Time       2012/12/12 17:52:17
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 文件夹帮助类
    /// </summary>
    /// 
    public class DirectoryHelper
    {

        
        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="dirFullPath">文件夹路径</param>
        /// <param name="dirOperateOption">文件夹操作选项</param>
        /// <returns>True/False</returns>
        public bool CreateDirOperate(string dirFullPath, OperateOption dirOperateOption)
        {
            try
            {
                if (!Directory.Exists(dirFullPath))
                {
                    Directory.CreateDirectory(dirFullPath);
                }
                else if (dirOperateOption == OperateOption.ExistDelete)
                {
                    Directory.Delete(dirFullPath, true);
                    Directory.CreateDirectory(dirFullPath);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 删除文件夹操作
        /// </summary>
        /// <param name="dirFullPath">文件夹路径</param>
        /// <returns>True/False</returns>
        public bool DeleteDirOperate(string dirFullPath)
        {
            if (Directory.Exists(dirFullPath))
            {
                Directory.Delete(dirFullPath, true);
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到文件夹下的所有文件，不包含子文件夹
        /// </summary>
        /// <param name="dirFullPath">文件夹路径</param>
        /// <returns>string[]</returns>
        /// <remarks></remarks>
        public string[] GetDirFiles(string dirFullPath)
        {
            string[] fileList = null;
            if (Directory.Exists(dirFullPath))
            {
                return fileList = Directory.GetFiles(dirFullPath, "*.*", SearchOption.TopDirectoryOnly);

            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到文件夹下的所有文件，按指定的搜索模式
        /// </summary>
        /// <param name="dirFullPath">文件夹路径</param>
        /// <param name="so">搜索类型</param>
        /// <returns>string[]</returns>
        /// <remarks></remarks>
        public string[] GetDirFiles(string dirFullPath, SearchOption searchOption)
        {
            string[] fileList = null;
            if (Directory.Exists(dirFullPath))
            {
                return fileList = Directory.GetFiles(dirFullPath, "*.*", searchOption);

            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到文件夹下所有与文件类型匹配的文件
        /// </summary>
        /// <param name="dirFullPath">文件夹路径</param>
        /// <param name="SearchPattern">文件类型</param>
        /// <returns></returns>
        public string[] GetDirFiles(string dirFullPath, string SearchPattern)
        {
            string[] fileList = null;
            if (Directory.Exists(dirFullPath))
            {
                return fileList = Directory.GetFiles(dirFullPath, SearchPattern);

            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到文件夹下所有文件
        /// </summary>
        /// <param name="dirFullPath">文件夹路径</param>
        /// <param name="SearchPattern">文件类型</param>
        /// <param name="so">搜索类型</param>
        /// <returns>string[]</returns>
        /// <remarks></remarks>
        public string[] GetDirFiles(string dirFullPath, string SearchPattern, SearchOption searchOption)
        {
            string[] fileList = null;
            if (Directory.Exists(dirFullPath))
            {
                return fileList = Directory.GetFiles(dirFullPath, SearchPattern, searchOption);

            }
            else
            {
                return null;
            }
        }
    }

    public enum OperateOption
    {
        /// <summary>
        /// 文件夹存在时删除
        /// </summary>
        ExistDelete,
        /// <summary>
        /// 文件夹存在时返回
        /// </summary>
        ExistReturn
    }


}

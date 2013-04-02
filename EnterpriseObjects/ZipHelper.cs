using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ionic.Zip;

namespace EnterpriseObjects
{
    public class ZipHelper
    {
        public static BackupResult ZipByFolderName(string folderName, string saveFileName)
        {
            using (ZipFile zip = new ZipFile(System.Text.Encoding.UTF8))
            {
                zip.AddDirectory(folderName);
                zip.Comment = "This zip was created at " + System.DateTime.Now.ToString("G");
                zip.Save(saveFileName);
            }

            return BackupResult.Success;
        }
    }

    public enum BackupResult
    {
        Success,
        Error
    }

}

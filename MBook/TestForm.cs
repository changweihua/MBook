using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnterpriseObjects;
using System.IO;
using NLite.Data;

namespace MBook
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DirectoryHelper dh = new DirectoryHelper();
            dh.CreateDirOperate(@"D:\aa\bb\cc", OperateOption.ExistDelete);

            return;

            using (var zipfile = ZipArchiveWithoutSubFolder.CreateZipFile(@"D:\ttt1.zip"))
            {
                var files = Directory.GetFiles(@"F:\截图");
                Array.ForEach(files.ToArray(), file =>
                {
                    int sourcedirlen = Path.GetDirectoryName(file).Length + 1;
                    using (FileStream input = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        using (Stream output = zipfile.AddFile(file.Substring(sourcedirlen)).SetStream())
                        {
                            byte[] buffer = new byte[int.MaxValue / 32];
                            for (int bytesRead = input.Read(buffer, 0, buffer.Length); bytesRead > 0; bytesRead = input.Read(buffer, 0, buffer.Length))
                                output.Write(buffer, 0, bytesRead);
                            output.Flush();
                            output.Close();
                        }
                    }
                }
                );
            }


            using (var zipfile = ZipArchiveWithSubFolder.CreateZipFile(@"D:\ttt2.zip"))
            {
                var dirs = Directory.GetDirectories(@"F:\截图");
                Array.ForEach(dirs.ToArray(), dir =>
                {
                    int sourcedirlen = Path.GetDirectoryName(dir).Length + 1;
                    Queue<FileSystemInfo> copyfolders = new Queue<FileSystemInfo>(new DirectoryInfo(dir).GetFileSystemInfos());
                    while (copyfolders.Count > 0)
                    {
                        FileSystemInfo atom = copyfolders.Dequeue();
                        FileInfo file = atom as FileInfo;
                        if (file == null)
                        {
                            DirectoryInfo directory = atom as DirectoryInfo;
                            foreach (FileSystemInfo fi in directory.GetFileSystemInfos())
                                copyfolders.Enqueue(fi);
                        }
                        else
                        {
                            using (FileStream input = new FileStream(file.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using (Stream output = zipfile.AddFile(file.FullName.Substring(sourcedirlen)).SetStream())
                                {
                                    byte[] buffer = new byte[int.MaxValue / 32];
                                    for (int bytesRead = input.Read(buffer, 0, buffer.Length); bytesRead > 0; bytesRead = input.Read(buffer, 0, buffer.Length))
                                        output.Write(buffer, 0, bytesRead);
                                    output.Flush();
                                    output.Close();
                                }
                            }
                        }
                    }
                }
                );
            }
        }
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private void button2_Click(object sender, EventArgs e)
        {
            using (var ctx = DbConfiguration.Items["MonoLog"].CreateDbContext())
            {
                ctx.Connection.Open();
                logger.Info(ctx.Connection.State.ToString());
            }
        }
    }
}

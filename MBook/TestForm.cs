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
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

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

        private void button3_Click(object sender, EventArgs e)
        {
            string CurrentDirectory = System.Environment.CurrentDirectory;

            Process process = new Process();

            //process.StartInfo.UseShellExecute = false;

            process.StartInfo.FileName = "Install.bat";

           // process.StartInfo.CreateNoWindow = true;

            process.Start();

            System.Environment.CurrentDirectory = CurrentDirectory;

            ServiceController serviceController = new ServiceController("MBookService");
            Thread.Sleep(10000);
            if (serviceController.Status == ServiceControllerStatus.Stopped)
            {
                serviceController.Start(new string[] { Application.StartupPath + @"\Data.db", "System.Data.SQLite" });
            }
            else
            {
                MessageBox.Show("没有找到指定的服务");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\Uninstall.bat");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ZipHelper.ZipByFolderName(@Properties.Settings.Default.SavePath, "zipp");
        }
    }
}

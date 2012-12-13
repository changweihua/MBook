using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       GZipHelper
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          GZipHelper
     * Created Time       2012/12/13 23:20:18
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 添加类描述
    /// </summary>
    /// 
    public class GZipHelper
    {

        /// <summary>
        /// 解压
        /// </summary>
        /// <param name="sourceFile">源文件</param>
        /// <param name="destinationFile">目标文件</param>
        public static void DecompressFile(string sourceFile, string destinationFile)
        {
            if (!File.Exists(sourceFile))
            {
                FileStream sourceStream = null;
                FileStream destinationStream = null;
                GZipStream decompressedStream = null;
                byte[] quqrterBuffer = null;

                try
                {
                    //读取压缩文件流
                    sourceStream = new FileStream(sourceFile, FileMode.Open);

                    quqrterBuffer = new byte[4];
                    int position = (int)sourceStream.Length - 4;
                    sourceStream.Position = position;
                    sourceStream.Read(quqrterBuffer, 0, 4);
                    sourceStream.Position = 0;
                    int checkLength = BitConverter.ToInt32(quqrterBuffer, 0);

                    byte[] buffer = new byte[checkLength + 100];

                    int offset = 0;
                    int total = 0;

                    while (true)
                    {
                        int bytesRead = decompressedStream.Read(buffer, offset, 100);

                        if (bytesRead == 0)
                        {
                            break;
                        }

                        offset += bytesRead;
                        total += bytesRead;

                    }

                    destinationStream = new FileStream(destinationFile, FileMode.Create);
                    destinationStream.Write(buffer, 0, total);

                    destinationStream.Flush();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (sourceStream != null)
                    { 
                        sourceStream.Close(); 
                    }

                    if (decompressedStream != null)
                    { 
                        decompressedStream.Close(); 
                    }

                    if (destinationStream != null)
                    { 
                        destinationStream.Close(); 
                    }
                }

            }
        }


        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="sourceFile">源文件</param>
        /// <param name="destinationFile">目的文件</param>
        public static void CompressFile(string sourceFile, string destinationFile)
        {
            // make sure the source file is there
            if (File.Exists(sourceFile) == false)
                throw new FileNotFoundException();

            // Create the streams and byte arrays needed
            byte[] buffer = null;
            FileStream sourceStream = null;
            FileStream destinationStream = null;
            GZipStream compressedStream = null;

            try
            {
                // Read the bytes from the source file into a byte array
                sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.Read);

                // Read the source stream values into the buffer
                buffer = new byte[sourceStream.Length];
                int checkCounter = sourceStream.Read(buffer, 0, buffer.Length);

                if (checkCounter != buffer.Length)
                {
                    throw new ApplicationException();
                }

                // Open the FileStream to write to
                destinationStream = new FileStream(destinationFile, FileMode.OpenOrCreate, FileAccess.Write);

                // Create a compression stream pointing to the destiantion stream
                compressedStream = new GZipStream(destinationStream, CompressionMode.Compress, true);

                // Now write the compressed data to the destination file
                compressedStream.Write(buffer, 0, buffer.Length);
            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
            finally
            {
                if (sourceStream != null)
                    sourceStream.Close();

                if (compressedStream != null)
                    compressedStream.Close();

                if (destinationStream != null)
                    destinationStream.Close();
            }
        }

    }
}

using ICSharpCode.SharpZipLib.Checksum;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace BLL
{
    /// <summary>
    /// 压缩解压缩
    /// </summary>
    public static class Compression
    {
        #region 压缩

        /// <summary>
        /// 用压缩算法压缩字节
        /// </summary>
        /// <param name="input">需要压缩的字节</param>
        /// <returns>返回压缩的字节</returns>
        public static byte[] CompressBytes(byte[] input)
        {
            using (MemoryStream buf = new MemoryStream())
            using (ZipOutputStream zip = new ZipOutputStream(buf))
            {
                Crc32 crc = new Crc32();
                zip.SetLevel(9);    // 0..9.

                ZipEntry entry = new ZipEntry(string.Empty);
                entry.DateTime = DateTime.Now;
                entry.Size = input.Length;

                crc.Reset();
                crc.Update(input);

                entry.Crc = crc.Value;

                zip.PutNextEntry(entry);
                zip.Write(input, 0, input.Length);
                zip.Finish();

                byte[] c = new byte[buf.Length];
                buf.Seek(0, SeekOrigin.Begin);
                buf.Read(c, 0, c.Length);

                zip.Close();

                return c;
            }
        }

        public static byte[] CompressFile(
            System.IO.FileStream StreamToZip,
            int iCompressionLevel = 9,
            int iBlockSize = 5120)
        {
            using (MemoryStream ZipFile = new MemoryStream())
            {
                using (ZipOutputStream ZipStream = new ZipOutputStream(ZipFile))
                {
                    ZipEntry ZipEntry = new ZipEntry(string.Empty);

                    ZipStream.PutNextEntry(ZipEntry);

                    //设置压缩级别
                    ZipStream.SetLevel(iCompressionLevel);

                    //缓存大小
                    byte[] buffer = new byte[iBlockSize];

                    int sizeRead = 0;
                    try
                    {
                        do
                        {
                            // 读取文件内容
                            sizeRead = StreamToZip.Read(buffer, 0, buffer.Length);

                            // 压缩，写入ZipStream
                            ZipStream.Write(buffer, 0, sizeRead);
                        }
                        while (sizeRead > 0);
                    }
                    catch(Exception ex)
                    {
                        return null;
                    }

                    ZipStream.Finish();
                    ZipStream.Close();
                }

                return ZipFile.GetBuffer();
            }
        }

        /// <summary>
        /// 读取文件并压缩字节
        /// </summary>
        /// <param name="strFileName">需要压缩的文件</param>
        /// <param name="lFileStreamLength">文件字节数</param>
        /// <param name="iCompressionLevel">压缩等级（0 无 - 9 最高，默认 9）</param>
        /// <param name="iBlockSize">缓存大小（每次写入文件大小，默认1K 1024）</param>
        /// <returns></returns>
        public static byte[] CompressFile(
            string strFileName,
            out long lFileStreamLength,
            int iCompressionLevel = 9,
            int iBlockSize = 1024)
        {
            //如果文件没有找到，则报错
            if (!System.IO.File.Exists(strFileName))
            {
                throw new System.IO.FileNotFoundException("文件: " + strFileName + " 不存在!");
            }

            using (MemoryStream ZipFile = new MemoryStream())
            {
                using (ZipOutputStream ZipStream = new ZipOutputStream(ZipFile))
                {
                    using (System.IO.FileStream StreamToZip = new System.IO.FileStream(strFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        lFileStreamLength = StreamToZip.Length;

                        ZipEntry ZipEntry = new ZipEntry(string.Empty);

                        ZipStream.PutNextEntry(ZipEntry);

                        //设置压缩级别
                        ZipStream.SetLevel(iCompressionLevel);

                        //缓存大小
                        byte[] buffer = new byte[iBlockSize];

                        int sizeRead = 0;
                        try
                        {
                            do
                            {
                                // 读取文件内容
                                sizeRead = StreamToZip.Read(buffer, 0, buffer.Length);

                                // 压缩，写入ZipStream
                                ZipStream.Write(buffer, 0, sizeRead);
                            }
                            while (sizeRead > 0);
                        }
                        catch
                        {
                            return null;
                        }

                        StreamToZip.Close();
                    }

                    ZipStream.Finish();
                    ZipStream.Close();
                }

                return ZipFile.GetBuffer();
            }
        }

        /// <summary>
        /// ZIP:压缩单个文件
        /// </summary>
        /// <param name="FileToZip">需要压缩的文件（绝对路径）</param>
        /// <param name="ZipedFileName">压缩后的文件名称（文件名，默认同源文件同名）</param>
        /// <param name="IsEncrypt">是否加密（默认 不加密）</param>
        /// <param name="Password">压缩密码 默认为空</param>
        /// <param name="CompressionLevel">压缩等级（0 无 - 9 最高，默认 9）</param>
        /// <param name="iBlockSize">缓存大小（每次写入文件大小，默认5M 5242880）</param>
        public static void ZipFile(string FileToZip, string ZipedFileName = "", bool IsEncrypt = false, string Password = "", int CompressionLevel = 9, int iBlockSize = 5242880)
        {
            //如果文件没有找到，则报错
            if (!System.IO.File.Exists(FileToZip))
            {
                throw new System.IO.FileNotFoundException("文件: " + FileToZip + " 不存在!");
            }

            // 压缩文件文件名称（默认同源文件名称相同）
            if (string.IsNullOrEmpty(ZipedFileName))
            {
                ZipedFileName = Path.GetDirectoryName(FileToZip) + Path.GetFileNameWithoutExtension(FileToZip) + Path.GetExtension(FileToZip).Replace('.', '_') + ".zip";
            }

            using (System.IO.FileStream ZipFile = System.IO.File.Create(ZipedFileName))
            {
                using (ZipOutputStream ZipStream = new ZipOutputStream(ZipFile))
                {
                    using (System.IO.FileStream StreamToZip = new System.IO.FileStream(FileToZip, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        string fileName = Path.GetFileName(FileToZip);

                        ZipEntry ZipEntry = new ZipEntry(fileName);

                        if (IsEncrypt)
                        {
                            //压缩文件加密
                            ZipStream.Password = Password;
                        }

                        ZipStream.PutNextEntry(ZipEntry);

                        //设置压缩级别
                        ZipStream.SetLevel(CompressionLevel);

                        //缓存大小
                        byte[] buffer = new byte[iBlockSize];

                        int sizeRead = 0;

                        try
                        {
                            do
                            {
                                sizeRead = StreamToZip.Read(buffer, 0, buffer.Length);
                                ZipStream.Write(buffer, 0, sizeRead);
                            }
                            while (sizeRead > 0);
                        }
                        catch (System.Exception ex)
                        {
                            throw ex;
                        }

                        StreamToZip.Close();
                    }

                    ZipStream.Finish();
                    ZipStream.Close();
                }

                ZipFile.Close();
            }
        }

        /// <summary>
        /// ZIP：压缩文件夹
        /// </summary>
        /// <param name="DirectoryToZip">需要压缩的文件夹（绝对路径）</param>
        /// <param name="ZipedFileName">压缩后的文件名称（文件名，默认 同源文件夹同名）</param>
        /// <param name="IsEncrypt">是否加密（默认 加密）</param>
        public static void ZipDirectory(string DirectoryToZip, string ZipedFileName , bool IsEncrypt = false, string Password = "")
        {
            //如果目录不存在，则报错
            if (!System.IO.Directory.Exists(DirectoryToZip))
            {
                throw new System.IO.FileNotFoundException("指定的目录: " + DirectoryToZip + " 不存在!");
            }

            //文件名称（默认同源文件名称相同）
            if (string.IsNullOrEmpty(ZipedFileName))
            {
                ZipedFileName = Path.GetDirectoryName(DirectoryToZip).Substring(DirectoryToZip.LastIndexOf(Path.DirectorySeparatorChar) + 1) + ".Zip";
            }

            using (System.IO.FileStream ZipFile = System.IO.File.Create(ZipedFileName))
            {
                using (ZipOutputStream s = new ZipOutputStream(ZipFile))
                {
                    if (IsEncrypt)
                    {
                        //压缩文件加密
                        s.Password = Password;
                    }
                    ZipSetp(DirectoryToZip, s, "");
                }
            }
        }

        /// <summary>
        /// 递归遍历目录
        /// </summary>
        private static void ZipSetp(string strDirectory, ZipOutputStream s, string parentPath)
        {
            if (strDirectory[strDirectory.Length - 1] != Path.DirectorySeparatorChar)
            {
                strDirectory += Path.DirectorySeparatorChar;
            }

            Crc32 crc = new Crc32();

            string[] filenames = Directory.GetFileSystemEntries(strDirectory);

            foreach (string file in filenames)// 遍历所有的文件和目录
            {

                if (Directory.Exists(file))// 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                {
                    string pPath = parentPath + file.Substring(file.LastIndexOf("\\") + 1) + "\\";
                    ZipSetp(file, s, pPath);
                }
                else // 否则直接压缩文件
                {
                    //打开压缩文件
                    using (FileStream fs = File.OpenRead(file))
                    {
                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);

                        string fileName = parentPath + file.Substring(file.LastIndexOf("\\") + 1);
                        ZipEntry entry = new ZipEntry(fileName);

                        entry.DateTime = DateTime.Now;
                        entry.Size = fs.Length;

                        fs.Close();

                        crc.Reset();
                        crc.Update(buffer);

                        entry.Crc = crc.Value;
                        s.PutNextEntry(entry);

                        s.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }

        #endregion

        #region 解压缩

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="strFileName"></param>
        /// <param name="BlockSize"></param>
        public static void DecompressFile(byte[] input, string strFileName, int BlockSize = 5242880)
        {
            if (string.IsNullOrEmpty(strFileName))
            {
                throw new NullReferenceException("文件名不允许为空！");
            }

            // 目录不存在则创建目录
            string strPath = Path.GetDirectoryName(strFileName);
            if (!Directory.Exists(strPath))
            {
                Directory.CreateDirectory(strPath);
            }

            // 如果文件已存在，删除文件
            if (File.Exists(strFileName))
            {
                File.Delete(strFileName);
            }

            using (MemoryStream mem = new MemoryStream(input))
            {
                using (ZipInputStream zipfiles = new ZipInputStream(mem))
                {
                    ZipEntry theEntry;

                    while ((theEntry = zipfiles.GetNextEntry()) != null)
                    {
                        // 读取字节流中的内容并解压缩到文件
                        using (FileStream streamWriter = File.Create(strFileName))
                        {
                            int size = BlockSize;
                            byte[] data = new byte[BlockSize];
                            while (true)
                            {
                                size = zipfiles.Read(data, 0, data.Length);

                                if (size > 0)
                                {
                                    streamWriter.Write(data, 0, size);
                                }
                                else
                                {
                                    break;
                                }
                            }

                            // 释放资源
                            streamWriter.Close();
                        }
                    }

                    // 释放资源
                    zipfiles.Close();
                }

                // 释放资源
                mem.Close();
            }
        }

        public static byte[] DecompressBytes(byte[] input)
        {
            using (MemoryStream mem = new MemoryStream(input))
            using (ZipInputStream stm = new ZipInputStream(mem))
            using (MemoryStream mem2 = new MemoryStream())
            {
                ZipEntry entry = stm.GetNextEntry();
                if (entry != null)
                {
                    byte[] data = new byte[4096];

                    while (true)
                    {
                        int size = stm.Read(data, 0, data.Length);
                        if (size > 0)
                        {
                            mem2.Write(data, 0, size);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                using (BinaryReader r = new BinaryReader(mem2))
                {
                    byte[] c = new byte[mem2.Length];
                    mem2.Seek(0, SeekOrigin.Begin);
                    r.Read(c, 0, (int)mem2.Length);

                    return c;
                }
            }
        }

        /// <summary>
        /// ZIP:解压一个zip文件
        /// </summary>
        /// <param name="ZipFile">需要解压的Zip文件（绝对路径）</param>
        /// <param name="TargetDirectory">解压到的目录</param>
        /// <param name="Password">解压密码</param>
        /// <param name="OverWrite">是否覆盖已存在的文件</param>
        public static void UnZip(string ZipFile, string TargetDirectory = "", string Password = "", bool OverWrite = true, int BlockSize = 5242880)
        {
            if (string.IsNullOrEmpty(TargetDirectory))
            {
                TargetDirectory = Path.GetDirectoryName(ZipFile);
            }

            //如果解压到的目录不存在，则报错
            if (!System.IO.Directory.Exists(TargetDirectory))
            {
                throw new System.IO.FileNotFoundException("指定的目录: " + TargetDirectory + " 不存在!");
            }

            //目录结尾
            if (!TargetDirectory.EndsWith("\\"))
            {
                TargetDirectory = TargetDirectory + "\\";
            }

            using (ZipInputStream zipfiles = new ZipInputStream(File.OpenRead(ZipFile)))
            {
                zipfiles.Password = Password;
                ZipEntry theEntry;

                while ((theEntry = zipfiles.GetNextEntry()) != null)
                {
                    string directoryName = "";
                    string pathToZip = "";
                    pathToZip = theEntry.Name;

                    if (pathToZip != "")
                        directoryName = Path.GetDirectoryName(pathToZip) + "\\";

                    string fileName = Path.GetFileName(pathToZip);

                    Directory.CreateDirectory(TargetDirectory + directoryName);

                    if (fileName != "")
                    {
                        if ((File.Exists(TargetDirectory + directoryName + fileName) && OverWrite) || (!File.Exists(TargetDirectory + directoryName + fileName)))
                        {
                            using (FileStream streamWriter = File.Create(TargetDirectory + directoryName + fileName))
                            {
                                int size = BlockSize;
                                byte[] data = new byte[BlockSize];
                                while (true)
                                {
                                    size = zipfiles.Read(data, 0, data.Length);

                                    if (size > 0)
                                    {
                                        streamWriter.Write(data, 0, size);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                streamWriter.Close();
                            }
                        }
                    }
                }

                zipfiles.Close();
            }
        }

        #endregion
    }

    /// <summary>  
    /// 压缩和解压文件  
    /// </summary>  
    public class ZipClass
    {
        public static void ZipFileDownload(string[] files, string zipFileName)
        {
            MemoryStream ms = new MemoryStream();
            byte[] buffer = null;

            using (ZipFile file = ZipFile.Create(ms))
            {
                file.BeginUpdate();

                file.NameTransform = new MyNameTransfom();
                foreach (var item in files)
                {
                    if (File.Exists(item))
                        file.Add(item);

                }
                file.CommitUpdate();
                buffer = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(buffer, 0, buffer.Length);   //读取文件内容(1次读ms.Length/1024M)  
                ms.Flush();
                ms.Close();
            }
            System.Web.HttpContext.Current.Response.Clear();
            System.Web.HttpContext.Current.Response.Buffer = true;
            System.Web.HttpContext.Current.Response.ContentType = "application/x-zip-compressed";
            System.Web.HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=" + HttpUtility.UrlDecode(zipFileName));
            System.Web.HttpContext.Current.Response.BinaryWrite(buffer);
            System.Web.HttpContext.Current.Response.Flush();
            System.Web.HttpContext.Current.Response.End();
        }
        public class MyNameTransfom : ICSharpCode.SharpZipLib.Core.INameTransform
        {

            #region INameTransform 成员

            public string TransformDirectory(string name)
            {
                return null;
            }

            public string TransformFile(string name)
            {
                return Path.GetFileName(name);
            }

            #endregion
        }
        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="sourceFilePath"></param>
        /// <param name="destinationZipFilePath"></param>
        public static void CreateZip(string sourceFilePath, string destinationZipFilePath)
        {
            if (sourceFilePath[sourceFilePath.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                sourceFilePath += System.IO.Path.DirectorySeparatorChar;
            ZipOutputStream zipStream = new ZipOutputStream(File.Create(destinationZipFilePath));
            zipStream.SetLevel(9);  // 压缩级别 0-9
            CreateZipFiles(sourceFilePath, zipStream);
            zipStream.Finish();
            zipStream.Close();
        }

        /// <summary>
        /// 递归压缩文件
        /// </summary>
        /// <param name="sourceFilePath">待压缩的文件或文件夹路径</param>
        /// <param name="zipStream">打包结果的zip文件路径（类似 D:\WorkSpace\a.zip）,全路径包括文件名和.zip扩展名
        ///</param>
        /// <param name="staticFile"></param>
        private static void CreateZipFiles(string sourceFilePath, ZipOutputStream zipStream)
        {
            Crc32 crc = new Crc32();
            string[] filesArray = Directory.GetFileSystemEntries(sourceFilePath);
            foreach (string file in filesArray)
            {
                if (Directory.Exists(file))                     //如果当前是文件夹，递归
                {
                    CreateZipFiles(file, zipStream);
                }
                else                                            //如果是文件，开始压缩
                {
                    try
                    {
                        FileStream fileStream = File.OpenRead(file);
                        byte[] buffer = new byte[fileStream.Length];
                        fileStream.Read(buffer, 0, buffer.Length);
                        string tempFile = file.Substring(sourceFilePath.LastIndexOf("\\") + 1);
                        ZipEntry entry = new ZipEntry(tempFile);

                        entry.DateTime = DateTime.Now;
                        entry.Size = fileStream.Length;
                        fileStream.Close();
                        crc.Reset();
                        crc.Update(buffer);
                        entry.Crc = crc.Value;
                        zipStream.PutNextEntry(entry);
                        zipStream.Write(buffer, 0, buffer.Length);
                    }
                    catch
                    {
                        throw new Exception("请关闭需要下载的任务！");
                    }
                }
            }
        }

        /// <summary>  
        ///  压缩多个文件  
        /// </summary>  
        /// <param name="files">文件名</param>  
        /// <param name="ZipedFileName">压缩包文件名</param>  
        /// <returns></returns>  
        public static void Zip(string[] files, string ZipedFileName)
        {
            Zip(files, ZipedFileName, string.Empty);
        }

        public static void Zip(string[] files, string ZipedFileName, string Password)
        {
            files = files.Where(f => File.Exists(f)).ToArray();
            if (files.Length == 0) throw new FileNotFoundException("未找到指定打包的文件");
            ZipOutputStream s = new ZipOutputStream(File.Create(ZipedFileName));

            s.SetLevel(6);
            if (!string.IsNullOrEmpty(Password.Trim())) s.Password = Password.Trim();
            ZipFileDictory(files, s);
            s.Finish();
            s.Close();
        }

        private static void ZipFileDictory(string[] files, ZipOutputStream s)
        {
            ZipEntry entry = null;
            FileStream fs = null;
            Crc32 crc = new Crc32();
            try
            {
                //创建当前文件夹  
                entry = new ZipEntry("/");  //加上 “/” 才会当成是文件夹创建  
                s.PutNextEntry(entry);
                s.Flush();
                foreach (string file in files)
                {
                    //打开压缩文件  
                    fs = File.OpenRead(file);

                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    entry = new ZipEntry("/" + Path.GetFileName(file));
                    entry.DateTime = DateTime.Now;
                    entry.Size = fs.Length;
                    fs.Close();
                    crc.Reset();
                    crc.Update(buffer);
                    entry.Crc = crc.Value;
                    s.PutNextEntry(entry);
                    s.Write(buffer, 0, buffer.Length);
                }
            }
            finally
            { 
                if (fs != null)
                {
                    fs.Close();
                    fs = null;
                }
                if (entry != null)
                    entry = null;
                GC.Collect();
            }
        }
    }

}

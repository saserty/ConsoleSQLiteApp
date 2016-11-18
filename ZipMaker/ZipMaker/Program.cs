using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Threading;

namespace ZipMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\dev\tested";
            string fileName = "doc.txt";
            string fileZipLocation = @"D:\dev\tested";
            string folderPath = @"D:\dev\tested\fol";
            string zipPath = @"D:\dev\tested\doc.txt.zip";
            string zipOutputLocation = @"D:\dev\tested\out";

            Console.WriteLine();
            ZipFiles zf = new ZipFiles();
            zf.FileToZip(filePath, fileName, fileZipLocation);
            Thread.Sleep(5000);
            zf.ZipToFile(zipPath, zipOutputLocation);
            Thread.Sleep(5000);
            zf.FolderToZip(folderPath);

            Console.ReadLine();
        }
    }
}

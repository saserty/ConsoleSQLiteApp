using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace ZipMaker
{
    public class ZipFiles
    {
        public void FileToZip(string filePath, string fileName, string fileZipLocation)
        {
            #region Create a temp folder
            DirectoryInfo di = null;
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(filePath + "\\Temp"))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                di = Directory.CreateDirectory(filePath + "\\Temp");
                Console.WriteLine("Temp directory was created successfully at {0}.", Directory.GetCreationTime(filePath + "\\Temp"));
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
            #endregion

            #region Move file to temp folder
            try
            {
                System.IO.File.Move(filePath + "\\" + fileName, filePath + "\\Temp\\" + fileName);
                Console.WriteLine("File {0} was moved successfully at {1}.", fileName, Directory.GetCreationTime(filePath + "\\Temp"));
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
            #endregion

            #region Make zip of temp folder
            try
            {
                ZipFile.CreateFromDirectory(filePath + "\\Temp\\", filePath + "\\" + fileName + ".zip");
                Console.WriteLine("Archive of {0} was created successfully at {1}.", fileName, Directory.GetCreationTime(filePath + "\\Temp"));
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
            #endregion

            #region Delete temp folder
            // Delete the directory. --true to delete folder content
            try
            {
                di.Delete(true);
                Console.WriteLine("Temp directory was deleted successfully at {0}.", File.GetLastWriteTime(filePath + "\\" + fileName + ".zip"));
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
            #endregion
        }

        public void ZipToFile(string zipPath, string zipOutputLocation)
        {
            try
            {
                ZipFile.ExtractToDirectory(zipPath, zipOutputLocation);                
                Console.WriteLine("Archieve {0} was unzipped successfully at {1}.", Path.GetFileName(zipPath), Directory.GetCreationTime(zipPath));
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        public void FolderToZip(string folderPath)
        {
            try
            {
                ZipFile.CreateFromDirectory(folderPath + "\\", folderPath + ".zip");
                Console.WriteLine("Archive of {0} was created successfully at {1}.", folderPath, Directory.GetCreationTime(folderPath + ".zip"));
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
    }
}

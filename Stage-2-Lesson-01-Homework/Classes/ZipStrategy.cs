using Stage_2_Lesson_01_Homework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class ZipStrategy : IFileStrategy
    {
        public void Process(string filePath)
        {
            var folderPath = Path.GetDirectoryName(filePath);
            var backupFolder = Path.Combine(folderPath, "backup");

            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
                Console.WriteLine($"Folder created: {backupFolder}");
            }

            try
            {
                ZipFile.ExtractToDirectory(filePath, backupFolder);
                Console.WriteLine($"File {filePath} successfully opened in {backupFolder}. ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening Zip: {ex.Message}");
            }
        }
    }
}

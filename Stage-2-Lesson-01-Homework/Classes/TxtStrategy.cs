using Stage_2_Lesson_01_Homework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class TxtStrategy : IFileStrategy
    {
        public void Process(string filePath)
        {

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"{filePath} deleted.");
            }
            else
            {
                Console.WriteLine($"File not found at this address: {filePath}");
            }
        }
    }
}

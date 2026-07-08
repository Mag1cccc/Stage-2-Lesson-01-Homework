using Stage_2_Lesson_01_Homework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class JsonStrategy : IFileStrategy
    {
        public void Process(string filePath) 

        {
            if (File.Exists(filePath))
            {
                var content = File.ReadAllText(filePath);
                Console.WriteLine($"JSON file content: \n {content}");
            }
            else
            {
                Console.WriteLine($"File not found at this address: {filePath}");
            }
        }

    }

}

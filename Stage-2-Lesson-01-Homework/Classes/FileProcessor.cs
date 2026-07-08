using Stage_2_Lesson_01_Homework.interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class FileProcessor
    {
        private IFileStrategy Strategy;

        public void SetStrategy(IFileStrategy strategy)
        {
            Strategy = strategy;
        }

        public void Execute(string filePath) 
        {
            Strategy.Process(filePath);
        }
    }
}

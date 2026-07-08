using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class ReportHeader
    {
        public string GenerateHTML()
        {
            return "<header> My Header </header>";
        }

        public string GeneratePDF()
        {
            return "Header: I’m using Facade Pattern";
        }
    }
}

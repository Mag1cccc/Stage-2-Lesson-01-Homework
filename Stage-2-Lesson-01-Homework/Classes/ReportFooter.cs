using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class ReportFooter
    {
        public string GenerateHTML()
        {
            return "<footer> My Footer </footer>";
        }

        public string GeneratePDF()
        {
            return "Footer: Page 1";
        }
    }
}

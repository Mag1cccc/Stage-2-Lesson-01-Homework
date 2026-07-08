using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class ReportBody
    {
        public string GenerateHTML()
        {
            return "<body> \n Video provides a powerful way to help you prove your point. When you click \n Online Video, you can paste in the embed code for the video you want to add. \n</body>";
        }

        public string GeneratePDF()
        {
            return "Body: \nVideo provides a powerful way to help you prove your point. When you click\r\nOnline Video, you can paste in the embed code for the video you want to add.\r\nYou can also type a keyword to search online for the video that best fits your\r\ndocument. To make your document look professionally produced, Word provides";
        }
    }
}

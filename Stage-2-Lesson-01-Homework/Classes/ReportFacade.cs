using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class ReportFacade
    {
        private ReportHeader header;
        private ReportBody body;
        private ReportFooter footer;

        public ReportFacade()
        { 
            header = new ReportHeader();
            body = new ReportBody();
            footer = new ReportFooter();
        }
        public string GenerateHTMLReport() 
        {
            return header.GenerateHTML() + "\n" +
               body.GenerateHTML() + "\n" +
               footer.GenerateHTML();
        }

        public string GeneratePDFReport() {
            return header.GeneratePDF() + "\n" +
               body.GeneratePDF() + "\n" +
               footer.GeneratePDF();
        }
    }
}

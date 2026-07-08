using Stage_2_Lesson_01_Homework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class ArtDecoSofa : ISofa
    {
        public void sitOn() {
            Console.WriteLine("You can sit on ArtDeco Sofa");
        }

        public void lieDown()
        {
            Console.WriteLine("You can lie down on ArtDeco Sofa");
        }
    }
}

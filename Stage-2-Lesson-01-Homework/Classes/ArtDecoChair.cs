using Stage_2_Lesson_01_Homework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class ArtDecoChair : IChair
    {
        public void hasLegs()
        {
            Console.WriteLine("ArtDeco Chair has legs");
        }

        public void sitOn()
        {
            Console.WriteLine("You can sit on ArtDeco Chair");
        }
    }
}

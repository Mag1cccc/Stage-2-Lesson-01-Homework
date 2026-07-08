using Stage_2_Lesson_01_Homework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class ModernCoffeTable : ICoffeTable
    {
        public void hasLegs()
        {
            Console.WriteLine("Victorian Coffee Table has legs");
        }

        public void putOn()
        {
            Console.WriteLine("You can put things on Victorian Coffee Table");
        }
    }
}

using Stage_2_Lesson_01_Homework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class Actor : IPerfomer
    {
        public string Name { get; private set; }

        public Actor(string name) {
            Name = name;
        }

        public void Perform()
        {
            Console.WriteLine($"{Name} plays in a simple scene");
        }
    }
}

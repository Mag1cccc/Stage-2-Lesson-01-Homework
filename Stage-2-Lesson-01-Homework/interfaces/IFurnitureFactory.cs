using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.interfaces
{
    internal interface IFurnitureFactory
    {
        public IChair CreateChair();
        public ICoffeTable CreateCoffeTable();
        public ISofa CreateSofa();
    }
}

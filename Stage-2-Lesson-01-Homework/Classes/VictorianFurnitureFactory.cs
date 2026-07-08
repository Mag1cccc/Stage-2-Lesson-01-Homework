using Stage_2_Lesson_01_Homework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() {
            return new VIctorianChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new VictorianCoffeTable();
        }

        public ISofa CreateSofa() {
            return new VictorianSofa();
        }
        
    }
}

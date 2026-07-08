using Stage_2_Lesson_01_Homework.Classes;
using Stage_2_Lesson_01_Homework.interfaces;

namespace Stage_2_Lesson_01_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFurnitureFactory furnitureFactory = new VictorianFurnitureFactory();
            IChair chair = furnitureFactory.CreateChair();
            ICoffeTable coffeTable = furnitureFactory.CreateCoffeTable();
            ISofa sofa = furnitureFactory.CreateSofa();

            chair.hasLegs();
            chair.sitOn();

            coffeTable.hasLegs();
            coffeTable.putOn();

            sofa.sitOn();
            sofa.lieDown();
        }
    }
}

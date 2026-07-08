using Stage_2_Lesson_01_Homework.Classes;
using Stage_2_Lesson_01_Homework.interfaces;

namespace Stage_2_Lesson_01_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1 Abstract Factory design pattern (Creational)

            //IFurnitureFactory furnitureFactory = new VictorianFurnitureFactory();
            //IChair chair = furnitureFactory.CreateChair();
            //ICoffeTable coffeTable = furnitureFactory.CreateCoffeTable();
            //ISofa sofa = furnitureFactory.CreateSofa();

            //chair.hasLegs();
            //chair.sitOn();

            //coffeTable.hasLegs();
            //coffeTable.putOn();

            //sofa.sitOn();
            //sofa.lieDown();


            // Task 2 Proxy design pattern (Structural)

            //Actor actor = new Actor("John Doe");

            //IPerfomer scene = new Stuntman(actor, false);
            //scene.Perform();

            //IPerfomer secondScene = new Stuntman(actor, true);
            //secondScene.Perform();


            // Task 3 Facade design pattern (Structural);

            //var reportFacade = new ReportFacade();

            //var htmlReport = reportFacade.GenerateHTMLReport();
            //Console.WriteLine(htmlReport);

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("<----------------------------------------------------------------------------->");
            //Console.WriteLine("<----------------------------------------------------------------------------->");
            //Console.ResetColor();

            //var pdfReport = reportFacade.GeneratePDFReport();
            //Console.WriteLine(pdfReport);


            // Task 4 Strategy design pattern (Behavioral);

            var baseDir = AppContext.BaseDirectory;
            var projectDir = Path.GetFullPath(Path.Combine(baseDir, @"..\..\..\"));
            var myFile = Path.Combine(projectDir, "data.zip");

            var extension = Path.GetExtension(myFile).ToLower();

            FileProcessor processor = new FileProcessor();

            if (extension == ".json")
            {
                processor.SetStrategy(new JsonStrategy());
            }
            else if (extension == ".zip")
            {
                processor.SetStrategy(new ZipStrategy());
            }
            else if (extension == ".txt")
            {
                processor.SetStrategy(new TxtStrategy());
            }

            processor.Execute(myFile);


        }
    }
}

using Stage_2_Lesson_01_Homework.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2_Lesson_01_Homework.Classes
{
    internal class Stuntman : IPerfomer
    {
        private IPerfomer RealActor;
        private bool IsDangerousScene;

        public Stuntman(Actor actor, bool isDangerousScene)
        {
            RealActor = actor;
            IsDangerousScene = isDangerousScene;
        }

        public void Perform()
        {
            if (IsDangerousScene)
            {
                Console.WriteLine($"The scene is dangerous! A stuntman has joined in and is performing a difficult act.");
            }
            else
            {
                Console.WriteLine("The scene is simple.");
                RealActor.Perform();
            }
        }
    }
}

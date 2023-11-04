using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace LearningSharper5
{
    public class Program
    {
        // FUNCTIONS

        /*static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}",
                cc, (int)cc);
        }*/



        // END OF FUNCTIONS

        // Enumerate Types
        /*enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }*/

        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}",
                rect1.Area());
            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("Rect2.length : {0}",
                rect2.length);

            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
        };

            Console.WriteLine("# of Animals {0}",
                Animal.GetNumAnimals());

            Console.WriteLine("Area of Rectangle : {0}",
                ShapeMath.GetArea("rectangle", 5, 6));

            int? randNum = null;
            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }

            if(!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }

        }
        /*// Enumerated Types:
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);*/

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1) { length = l; width = w; }
            public double Area()
            {
                return length * width;
            }
        }
    }
}    

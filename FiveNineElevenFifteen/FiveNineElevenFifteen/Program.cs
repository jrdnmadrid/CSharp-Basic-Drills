using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveNineElevenFifteen
{
    class Program
    {
        protected internal static void Main(string[] args)
        {

            //Abstract Class: Much like an interface, but cannot be inherited. Shown in abstractriangle/equilateraltriangle classes. 
            //I also used "this." in the equilateraltriangle class. 
            EquilateralTriangle Triangle1 = new EquilateralTriangle();
            Triangle1.side = 5;
            Triangle1.height = 4;
            Console.WriteLine(Triangle1.CalculatePerimeter()); 
            Console.WriteLine(Triangle1.CalculateArea());

            //Interface: You can use multiple inheritance, as I did in square class, to put together multiple methods.
            Square Square1 = new Square();
            Square1.Length = 5;
            Square1.Width = 5;
            Console.WriteLine(Square1.CalculateArea());
            Console.WriteLine(Square1.CalculatePerimeter());

            //Nullable types. I chose an int that could be null

            Console.WriteLine("Pick a number");
            int? num1 = null; //It handles null automatically and prints out a number. If I changed this, it would print out 5. 
            int? num2 = 5;

            if(num1 == num2)
            {
                Console.WriteLine("Awesome! Self destruct sequence activated. ");
            }
            else
            {
                Console.WriteLine("Please type in 5 for num1");
            }

        }
    }
}

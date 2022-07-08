using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //Exercise 2-calling the method
        public static double AreaOfCircle(double radius)
        {
            return (Math.PI * radius * radius);
        }

        static void Main(string[] args)
        {
            //Exercise 1
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            //Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");

        }
        
    }
}
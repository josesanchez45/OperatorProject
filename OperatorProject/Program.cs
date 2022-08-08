using System;

namespace OperatorProject
{
    internal class Program
    {
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        public static void Main(string[] args)
        {
            //Excercise 1
            var a = 17;
            int b = 4;
            int addition = a + b;
            var quotient = a / b;
            int remainder = a % b;
            int subtraction = a - b;
            if (a == 17 && b == 4) ;
            Console.WriteLine($"{a}/{b} is {quotient} with remainder {remainder}");
            Console.WriteLine();
            Console.WriteLine("Please enter the radius of your circle:");
            var userinput= Console.ReadLine();
            var radius = double.Parse(userinput);
            Console.WriteLine($"Area of this circle is {AreaOfCircle(radius)}.");
        }
    }
}
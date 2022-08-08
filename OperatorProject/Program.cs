using System;

namespace OperatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Excercise 1
            var a = 17;
            int b = 4;
            int addition = a + b;
            var quotient = a/b;
            int remainder = a % b;
            int subtraction = a - b;
            if (a == 17 && b == 4) ;
            Console.WriteLine($"{ a}/{ b} is { quotient} with remainder {remainder}");  
        }
    }
}

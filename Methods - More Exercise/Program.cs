using System;

namespace Methods___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double a = 1;
            double b = 3;
            double c = 9;
            double d = 7;

            double firstLine = Math.Sqrt(Math.Pow(Math.Abs(a - c), 2) + Math.Pow(Math.Abs(b - d), 2));
            double ccc = Math.Pow(Math.Abs(b - d), 2);
            double aaa = Math.Pow(Math.Abs(a - c), 2);
            Console.WriteLine(ccc);
            Console.WriteLine(aaa);
            Console.WriteLine(firstLine);
        }
    }
}

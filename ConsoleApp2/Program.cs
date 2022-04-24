using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x11 = double.Parse(Console.ReadLine());
            double y11 = double.Parse(Console.ReadLine());
            double x12 = double.Parse(Console.ReadLine());
            double y12 = double.Parse(Console.ReadLine());
            double x21 = double.Parse(Console.ReadLine());
            double y21 = double.Parse(Console.ReadLine());
            double x22 = double.Parse(Console.ReadLine());
            double y22 = double.Parse(Console.ReadLine());

            PrintLine(x11, y11, x12, y12, x21, y21, x22, y22);
        }

        static void PrintLine(double x11, double y11, double x12, double y12, double x21, double y21, double x22, double y22)
        {
            double firstLine = Math.Sqrt(Math.Pow((x11 - x12), 2) + Math.Pow((y11 - y12), 2));
            double secondLine = Math.Sqrt(Math.Pow((x21 - x22), 2) + Math.Pow((y21 - y22), 2));

            if (firstLine >= secondLine)
            {
                CloseToZero(x11,y11,x12,y12);
            }
            else
            {
                CloseToZero(x21,y21,x22,y22);
            }
        }
        static void CloseToZero(double a, double b, double c, double d)
        {
            double first = Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
            double second = Math.Sqrt(Math.Pow(Math.Abs(c), 2) + Math.Pow(Math.Abs(d), 2));
            if (first > second)
            {
                Console.WriteLine($"({c}, {d})({a}, {b})");
            }
            else
            {
                Console.WriteLine($"({a}, {b})({c}, {d})");
            }
        }
    }
}

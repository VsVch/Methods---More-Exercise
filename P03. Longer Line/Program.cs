using System;

namespace P03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());


            PrintLongLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void PrintLongLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {

            double first = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1-y2), 2));
            double second = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3-y4), 2));

            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;

            if (first >= second)
            {
                CenterPoints(x1, y1, x2, y2);
            }
            else
            {
                CenterPoints(x3, y3, x4, y4);
            }


        }
        private static void CenterPoints(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double second = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (first <= second)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}

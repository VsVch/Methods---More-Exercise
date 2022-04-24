using System;

namespace P02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CloseToCenter(x1, y1, x2, y2);
        }

        private static void CloseToCenter(double x1, double y1, double x2, double y2)
        {
            double x = 0;
            double y = 0;
            if (Math.Abs(x1) <= Math.Abs(x2))
            {
                if (Math.Abs(y1) <= Math.Abs(y2))
                {
                    x = x1;
                    y = y1;
                }
                else if (Math.Abs(x1 + y1) <= Math.Abs(x2 + y2))
                {
                    x = x1;
                    y = y1;
                }
                else
                {
                    x = x2;
                    y = y2;
                }
            }
            else
            {
                if (Math.Abs(y1) <= Math.Abs(y2))
                {
                    x = x1;
                    y = y1;
                }
                else if (Math.Abs(x1 + y1) <= Math.Abs(x2 + y2))
                {
                    x = x1;
                    y = y1;
                }
                else
                {
                    x = x2;
                    y = y2;
                }
            }

            Console.WriteLine($"({x}, {y})");
        }
    }
}

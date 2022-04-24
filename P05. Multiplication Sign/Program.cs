using System;

namespace P05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            IsPositive(num1, num2, num3);
        }

        private static void IsPositive(double num1, double num2, double num3)
        {
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine($"zero");
            }
            else if (num1 > 0 && num2 > 0 && num3 > 0)
            {
                Console.WriteLine($"positive");
            }
            else if (num1 < 0)
            {
                if ((num2 > 0 && num3 < 0) || (num2 < 0 && num3 > 0))
                {
                    Console.WriteLine($"positive");
                }
                else if ((num2 > 0 && num3 > 0))
                {
                    Console.WriteLine($"negative");
                }
                else
                {
                    Console.WriteLine($"negative");
                }

            }
            else if (num2 < 0)
            {
                if ((num1 > 0 && num3 < 0) || (num1 < 0 && num3 > 0))
                {
                    Console.WriteLine($"positive");
                }
                else if ((num1 > 0 && num3 > 0))
                {
                    Console.WriteLine($"negative");
                }
                else
                {
                    Console.WriteLine($"negative");
                }

            }
            else if (num3 < 0)
            {
                if ((num2 > 0 && num1 < 0) || (num2 < 0 && num1 > 0))
                {
                    Console.WriteLine($"positive");
                }
                else if ((num2 > 0 && num1 > 0))
                {
                    Console.WriteLine($"negative");
                }
                else
                {
                    Console.WriteLine($"negative");
                }

            }
        }

    }
}

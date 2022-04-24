using System;

namespace P01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Check(input);
        }

        private static void Check(string input)
        {
            switch (input)
            {
                case "int": IntMultiply(input); break;
                case "real": DoubleMultiply(input); break;
                case "string": StringMultiply(input); break;
                default:
                    break;
            }
        }

        private static void DoubleMultiply(string input)
        {
            double num = double.Parse(Console.ReadLine());
            double sum = 0;
            sum = 1.5 * num;
            Console.WriteLine($"{sum:f2}");
        }

        private static void IntMultiply(string input)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            sum = num * 2;
            Console.WriteLine(sum);
        }

        private static void StringMultiply(string input)
        {
            string text = Console.ReadLine();
            Console.WriteLine($"${text}$");
        }
    }
}

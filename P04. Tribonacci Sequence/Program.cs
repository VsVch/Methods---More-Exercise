using System;

namespace P04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine($"1");
            }
            else if (number == 2)
            {
                Console.WriteLine($"1 1");
            }
            else if (number == 3)
            {
                Console.WriteLine($"1 1 2");
            }
            else
            {
                Console.Write($"1 1 2 ");
                PrintFibonachi(number);
            }
        }

        private static void PrintFibonachi(int number)
        {
            int first = 1;
            int second = 1;
            int third = 2;
            int four = 0;
            for (int i = 0; i < number - 3; i++)
            {
                four = first + second + third;
                first = second;
                second = third;
                third = four;
                Console.Write($"{four} ");
            }
        }
    }
}

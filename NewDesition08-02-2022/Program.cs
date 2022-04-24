using System;

namespace NewDesition08_02_2022
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Check(input);

            if (input == "int")
            {
                PrintSum(int value);
                int num = int.Parse(Console.ReadLine());
                int sum = num * 2;
                Console.WriteLine(sum);
            }
            else if (input == "real")
            {
                double num = double.Parse(Console.ReadLine());
                double sum = num * 1.5;
                Console.WriteLine($"{sum:f2}");
            }
            else if (input == "string")
            {
                string inp = Console.ReadLine();
                Console.WriteLine($"${inp}$");
            }



        }

    

    }
}

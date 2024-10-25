using System;

namespace CSA02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數字：");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (IsOdd(number))
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an even number.");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}

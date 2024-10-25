using System;

namespace CSA03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weeks = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            Console.WriteLine("請輸入一個數字 (0-6)：");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0 && n <= 6)
            {
                Console.WriteLine(weeks[n]);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
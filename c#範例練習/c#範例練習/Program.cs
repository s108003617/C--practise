using System;

namespace CSA01
{
    class P
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("請輸入兩個數字：");

            if (double.TryParse(Console.ReadLine(), out double num1) && double.TryParse(Console.ReadLine(), out double num2) )
            {
                if ((num1 % 2 == 0 && num2 % 2 == 0))
                {
                    double sum = num1 + num2;
                    Console.WriteLine($"兩個偶數相加的結果為：{sum}");
                }
                else if (num1 % 2 == 0)
                {
                    Console.WriteLine($"只有一個偶數 {num1}");
                }
                else if (num2 % 2 == 0)
                {
                    Console.WriteLine($"只有一個偶數 {num2}");
                }
                else
                {
                    Console.WriteLine("輸入的數字不符合要求，輸出結果為 0。");
                }
            }
        }
    }
}
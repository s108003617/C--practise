using System;

namespace CSA04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入第一個日期 (YYYYMMDD)：");
            string input1 = Console.ReadLine();

            Console.WriteLine("請輸入第二個日期 (YYYYMMDD)：");
            string input2 = Console.ReadLine();

            if (long.TryParse(input1, out long date1) && long.TryParse(input2, out long date2) && input1.Length == 8 && input2.Length == 8)
            {
                if (DateTime.TryParseExact(input1, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime dateTime1) &&
                    DateTime.TryParseExact(input2, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime dateTime2))
                {
                    TimeSpan timeSpan = dateTime2 - dateTime1;
                    Console.WriteLine($"日期相差 {timeSpan.Days} 天");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
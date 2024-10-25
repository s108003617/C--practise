//main 方法
using ConsoleApp;
using System;

namespace  ConsoleApp
{
    class Progarm
    {
        static void Main()
        {
            Person person1 = new Person(156, 21,"好爽");
          Console.WriteLine(person1.name);
            Console.WriteLine(person1.age);
            Console.WriteLine(person1.height);
        }
    }
}

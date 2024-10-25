//method 方法
using ConsoleApp;
using System;

Person person1 = new Person();
person1.height = 100;
person1.name = "小白白";
person1.age = 12;
Console.WriteLine(person1.Add(2,3,"qwd"));


Person person2 = new Person();
person2.height = 145;
person2.name = "小白";
person2.age = 19;
Console.WriteLine(person2.IsAdult());
System.Console.WriteLine("請輸入第一個數: ");
double num1 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("請輸入算式: ");
string por = System.Console.ReadLine();
System.Console.WriteLine("請輸入第二個數: ");
double num2 = System.Convert.ToDouble(System.Console.ReadLine());
{ 
if (por == "+") 
{ System.Console.WriteLine(num1 + num2); }
else if (por == "-")
{ System.Console.WriteLine(num1 - num2); }
else if (por == "*")
{ System.Console.WriteLine(num1 * num2); }  
else if (por == "/")
{ System.Console.WriteLine(num1 / num2); }
else
{ System.Console.WriteLine("erro"); }
}




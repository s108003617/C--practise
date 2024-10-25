//印星
for (int i = 0,b = 10 ;i< b ;i++)
{
    for(int j = 0 ;j<b -(i*2+1);j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}
System.Console.ReadLine();
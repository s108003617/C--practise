//猜數字遊戲

/*
int number = 50;
int guess;
int times = 0;

do
{
    System.Console.Write("請輸入 :");
    guess = System.Convert.ToInt32(System.Console.ReadLine());
    times++;

    if (guess < number)
    {
        System.Console.WriteLine("大一點");
    }
    else if (guess > number) 
    {
        System.Console.WriteLine("小一點");
    }
    else 
    {
        System.Console.WriteLine("恭喜你 答對了!");
    }
    
}
while (times < 3);

    System.Console.WriteLine("真可惜 差一點就答對了");
*/ //我自己寫

int number = 50;
int guess;
int guess_count = 0;
int guess_limit = 3;
bool win = false;

do
{
    System.Console.Write("請輸入 :");
    guess = System.Convert.ToInt32(System.Console.ReadLine());
    guess_count++;

    if (guess < number)
    {
        System.Console.WriteLine("大一點");
    }
    else if (guess > number)
    {
        System.Console.WriteLine("小一點");
    }
    else
    {
        System.Console.WriteLine("恭喜你 答對了!");
        win = true;
    }

}
while (guess != number && guess_count < guess_limit);

if (!win)
{
    System.Console.WriteLine("很抱歉 你輸了~");
}
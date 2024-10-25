
namespace ConsoleApp
{
    internal class Person
    {
        public double height;
        public int age;
        public string name;

        public void SayHi()//void不會回傳
        {
            Console.WriteLine("你好阿我叫" + name);
        }
        public bool IsAdult()
        {
            if(age>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Add(int num1, int num2,string qq)
        {
            return num1 + num2;
        }
    }
}

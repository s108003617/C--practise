
namespace ConsoleApp
{
    internal class Person
    {
        public double height;
        public int age;
        public string name;

        public Person(double height , int a ,string n) //不能回傳
        {
           this.height = height; 
           age = a;
           name = n;
        }
    }
}

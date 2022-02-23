using System;

namespace multilevel_inheritance
{
    class Grandfather
    {
        public string surname = "dawkar";
        public void work()
        {
            Console.WriteLine("he is farmer");
        }
    }
    class Father : Grandfather
    {
        public int age = 50;
        public void activity() 
        {
            Console.WriteLine("he is good swimer");
        }
    }
    class Son : Father
    {
        public string profetion = "engineer";
        public int expirience = 5;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create new obj s
            Son s = new Son();
            Console.WriteLine(" my surname is:"+ s.surname);
            Console.WriteLine("age of my father:"+s.age);
            Console.WriteLine("my father:");
            s.activity();
            Console.WriteLine("my grandfather:");
            s.work();

            Console.Read();
        }
    }
}

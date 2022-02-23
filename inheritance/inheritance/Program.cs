using System;

namespace inheritance

{
    class Person //parent class
    {
        public string FirstName = "pravita";  // Person field
        public string LastName = "dawkar";  // Person field
        public void run()             // Person method 
        {
            Console.WriteLine(" pravita is good in run");
        }
    }
    class Devloper:Person //child class
    { 
        public string Department = "IT ";// Devloper field
        public void coding()             // Person method 
        {
            Console.WriteLine(" she is a good in devlopment");
        }

    }
    class Program
    { 
        static void Main(string[] args)
        {
           //create a new obj -----single inheritance-----
            Devloper person1 = new Devloper();
            Console.WriteLine(" Fulname:" + person1.FirstName + " " + person1.LastName );
            person1.run();
            Console.WriteLine("she is from" + person1.Department);
            person1.coding();
            



        }
    }
    
}


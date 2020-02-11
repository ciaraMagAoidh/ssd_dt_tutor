using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            helloWorld();
            helloName();
            helloNameAge();
        }

        public void helloWorld(){
            Console.WriteLine("Hello World");
        }

        public void helloName(){
            string name = "";
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }

        public void helloNameAge(){
            string name = "";
            int age = 0;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            name = Convert.toInt32(Console.ReadLine());

            Console.WriteLine("You are {0} and you are {1} years old", name, Convert.toString(age));
        }
    }
}

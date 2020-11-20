using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Example!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Person me = new Person() { Name = name, ID = 1 };
            Console.WriteLine("Hello, " + me.Name + ", Welcome to the class.");

        }
    }
}

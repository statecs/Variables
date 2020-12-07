using System;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine(); //returns a string

            Console.WriteLine("Welcome {0}", name); //placeholder
            Console.WriteLine("Welcome" + name + ", welcome back!"); //Concanate the name
        }
    }
}

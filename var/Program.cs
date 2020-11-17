using System;

namespace var
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            string name = "Christopher";

            var fullName = "Jon Snow"; // C# define variable as string
            var testFloat = 1000f; //C# define variable as float
            var testDouble = 1000d; //C# define variable as double
            var testDecimal = 1000m; //C# define variable as decimal

            var test = 7.5; // C# define variable as double
            var testString = "This is a string"; // C# defines variable as string

            Console.WriteLine(test);

            var testX = x;
            var testY = name;

            Console.WriteLine(testX);
            Console.WriteLine(testY);

        }
    }
}

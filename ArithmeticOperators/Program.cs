using System;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 2;
            int result = 0;

            Console.WriteLine("Add: " + x + y); //Concatenate x+y in a string

            result = x + y; //Addition
            Console.WriteLine("Add: " + result); 

            result = x - y; //Subtraction
            Console.WriteLine("Sub: " + result); 

            result = x * y; //Multiplication
            Console.WriteLine("Multi: " + result); 

            result = x / y; //Division
            Console.WriteLine("Divi: " + result);

            result = x % y; //Remainder
            Console.WriteLine("Rem: " + result);
        }
    }
}

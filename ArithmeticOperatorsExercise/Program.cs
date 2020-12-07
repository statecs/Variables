using System;

namespace ArithmeticOperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;

            int result = 0;

            result = x + y;
            Console.WriteLine("" + x + " + " + y + " = " + result); //Concatenate
            Console.WriteLine("{0} + {1} = {2}", x, y, result); //Placeholder
           
            result = x - y;
            Console.WriteLine("{0} - {1} = {2}", x, y, result);

            result = x * y;
            Console.WriteLine("{0} * {1} = {2}", x, y, result);

            result = x / y;
            Console.WriteLine("{0} / {1} = {2}", x, y, result);

            result = x % y;
            Console.WriteLine("{0} % {1} = {2}", x, y, result);


        }
    }
}

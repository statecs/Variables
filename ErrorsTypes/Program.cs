using System;

namespace ErrorsTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            /* a = ""; b = 1; c = 0; //Trying to assign a string to integer. Syntax error */

            /* a = 0 b = 1; c = 0; //Violation of the rules. Syntax error */

            a = 0; b = 1; c = 0;
            c = b / a;

            Console.WriteLine(c); // Unhandled Exception. Attempted to divide by zero. 

        }
    }
}

using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 2; // used to store integer numbers (3 or 2000)
            x = 5; //Set and override value
            Console.WriteLine("Number is" + x);

            double double_num = 0.0d; // used to store floating point numbers
            float float_num = 0.0f; // used to store floating point numbers (3.5 or 9.8)
            decimal decimal_num = 0.0m; // used to store money values (2000€)


            double_num = 9.8d;
            float_num = 5.5f;
            decimal_num = 100.250m;

            Console.WriteLine("Double is" + double_num + " Float is" + float_num + " Decimal is" + decimal_num);

            char letter_a = 'a'; //Define a char variable
            string firstName = "Jon";
            string lastName = "Snow";

            Console.WriteLine("Hello, " + firstName + " " + lastName); //Hello, Jon Snow

            string FrstName, Lastname, House; //Declare the variable, with type:string

            FrstName = "Jon";
            Lastname = "Snow"; //Case-sensitive
            House = "Stark";

            Console.WriteLine("Hello, " + FrstName + Lastname + "of House" + House);
        }
    }
}

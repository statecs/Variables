using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int serialNo = 100;
            string accountNo = ""; //empty as we created it

            accountNo = serialNo.ToString(); // set the accountnumber to serialNo and ToString converts any number to a string

            Console.WriteLine(accountNo); //Now it's 100
        }
    }
}

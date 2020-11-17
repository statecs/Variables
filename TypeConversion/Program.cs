using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int serialNo = 100;
            string accountNo = ""; //empty as we created it
            float anyNo = 3.5f; // f = floating point

            accountNo = serialNo.ToString(); // set the accountnumber to serialNo and ToString converts any number to a string

            Console.WriteLine(accountNo); //Now it's 100

            serialNo = Convert.ToInt32(anyNo); //Convert float to int32 and round it to 4

            Console.WriteLine(serialNo);

            serialNo = (int)anyNo; // will ignore rounding, convert to 3

            Console.WriteLine(serialNo); 
        }
    }
}

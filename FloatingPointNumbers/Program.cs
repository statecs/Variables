using System;

namespace FloatingPointNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float f_no = 0.0f; //f = float number
            double d_no = 0.0d; // d = double variable
            decimal m_no = 0.0m; // m = decimal variable

            f_no = 1 / 3f;
            d_no = 1 / 3d;
            m_no = 1 / 3m;

            //Placeholder
            Console.WriteLine("Float no. is {0}", f_no);
            Console.WriteLine("Double no. is {0}", d_no);
            Console.WriteLine("Decimal no. is {0}", m_no);
        }
    }
}

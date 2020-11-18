using System;

namespace DataTypesInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primitive datatypes

            int xMax = int.MaxValue; // Max value (int) 2,147,483,647

            int xMin = int.MinValue; // Min value (int) -2,147,483,647

            Console.WriteLine(xMax);

            Console.WriteLine(xMin);

            uint y = 2147483648; // Convert to uint in order to take higher max-value

            Console.WriteLine(y);

            uint zMax = uint.MaxValue; //Max value for (unit) 4,294,967,295

            uint zMin = uint.MinValue; //Min value for (unit) 0

            Console.WriteLine(zMax);

            Console.WriteLine(zMin);

            Console.WriteLine(typeof(int).IsPrimitive); //True
            Console.WriteLine(typeof(float).IsPrimitive); //True
            Console.WriteLine(typeof(double).IsPrimitive); //True
            Console.WriteLine(typeof(char).IsPrimitive); //True

            Console.WriteLine(typeof(decimal).IsPrimitive); //False
            Console.WriteLine(typeof(string).IsPrimitive); //False
        }
    }
}

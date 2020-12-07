using System;

namespace DateTimeLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDateUnassigned = new DateTime(); //Default value of time. Did not assign any value
            DateTime myDate = new DateTime(1999,10,5); //Assigned value of year 1999, Month October and Day 5.

            DateTime todayDate = DateTime.Today; //Today date without time
            DateTime todayDateTime = DateTime.Now; //Today date with current time

            Console.WriteLine("Date {0}, {1}, {2}, {3}", myDateUnassigned, myDate, todayDate, todayDateTime);
        }
    }
}

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
            Console.WriteLine(todayDate.ToShortDateString()); // Will only display the date
            Console.WriteLine(todayDate.ToShortTimeString()); // Will only display the time
            Console.WriteLine(todayDate.ToLongDateString()); // Will show a different format, ex. Saturday, September 16, 2020

            Console.WriteLine(todayDate.AddDays(10)); // Will add 10 days from now
            Console.WriteLine(todayDate.AddYears(-6)); // Will remove 6 years from now

            //Regular expression
            string formattedDate = string.Format("Date is {0:yyyy MMMM dddd HH mm ss tt}", todayDateTime); //todayDateTime will be assigned in the placeholder {0} with format  YYYY = Year, MMMMM = Month, dddd = Day, HHH = Hour, mm = Minutes, ss = Seconds, tt = AM/PM
            Console.WriteLine(formattedDate); // Display Date
        }
    }
}

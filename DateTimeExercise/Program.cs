using System;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Format: 30-09-2020 01:15:55

            DateTime todayDate = DateTime.Now;
            string formattedDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}", todayDate);
            Console.WriteLine(formattedDate);

            //Second Format : Saturday of month September 2020

            string secondFormattedDate = string.Format("{0:dddd} of month {0:MMMM} {0:yyyy}", todayDate);
            Console.WriteLine(secondFormattedDate);

            /* Third Format
             * Day Saturday
             * Month September
             * Year 2020
             */

            string thirdFormattedDateDay = string.Format("{0:dddd}", todayDate);
            string thirdFormattedDateMonth = string.Format("{0:MMMM}", todayDate);
            string thirdFormattedDateYear = string.Format("{0:yyyy}", todayDate);
            Console.WriteLine("\n Day {0} \n Month {1} \n Year {2}", thirdFormattedDateDay, thirdFormattedDateMonth, thirdFormattedDateYear);

            /*            */
            /* Solution 2 */
            /*            */

            DateTime mydate = DateTime.Now;
            string formattedDated = "";
            //First Format: 30-09-2020 01:15:55

            formattedDated = string.Format("{0:dd-MM-yyyy HH:mm:ss}", mydate);
            Console.WriteLine(formattedDated);

            //Second Format : Saturday of month September 2020
            formattedDated = string.Format("{0:dddd 'of month' MMMM 'year' yyyy}", mydate);
            Console.WriteLine(formattedDated);

            /* Third Format
            * Day Saturday
            * Month September
            * Year 2020
            */

            formattedDated = string.Format("{0:'Day' dddd \n'Month' MMMM \n'Year' yyyy}", mydate); // \n escape sequences
            Console.WriteLine(formattedDated);

        }
    }
}

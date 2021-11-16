using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class SeasonFinder
    {
        public static void FourSeasons()
        {
            Console.WriteLine("Please give me month and a day.");
            Console.WriteLine("Give me the month number. (1-12)");
            int testMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me the day number. (1-31)");
            int testDay = int.Parse(Console.ReadLine());
            int testYear = 2000; // Sets the year to 2000

            try
            {
                DateTime testDate = new DateTime(testYear, testMonth, testDay);
                DateTime firstDayOfSpring = new DateTime(testYear, 3, 22);
                DateTime firstDayOfSummer = new DateTime(testYear, 6, 21);
                DateTime firstDayOfFall = new DateTime(testYear, 9, 22);
                DateTime firstDayOfWinter = new DateTime(testYear, 12, 21);

                if (testDate < firstDayOfSpring)
                {
                    Console.WriteLine("Winter");
                }
                else if (testDate < firstDayOfSummer)
                {
                    Console.WriteLine("Spring");
                }
                else if (testDate < firstDayOfFall)
                {
                    Console.WriteLine("Summer");
                }
                else if (testDate < firstDayOfWinter)
                {
                    Console.WriteLine("Fall");
                }
                else
                {
                    Console.WriteLine("Winter");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("You did not enter a valid month and day.");
                Console.WriteLine(e);                
            }
            


            
        }
    }
}

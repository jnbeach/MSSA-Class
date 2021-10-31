using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Student
    {
        public static void PassOrFail()
        {
            Console.WriteLine("What was your grade on Assignment 1? e.g. 50, 70, 100");
            decimal grade1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What was your grade on Assignment 2? e.g. 50, 70, 100");
            decimal grade2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What was your grade on Assignment 3? e.g. 50, 70, 100");
            decimal grade3 = decimal.Parse(Console.ReadLine());

            decimal gradeAverage = (grade1 + grade2 + grade3) / 3;
            if (gradeAverage >= 70)
            {
                Console.WriteLine("Congratulations, you passed. Your grade was ${0}%", gradeAverage);
            }
            else
            {
                Console.WriteLine("Oops, you failed. Your grade was {0}%", gradeAverage);
            }
        }
    }
}

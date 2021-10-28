﻿using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                Console.WriteLine("Please input an option number (1-6), 7 to exit.");
                Console.WriteLine("1: Calculate the income of an employee.");
                Console.WriteLine("2: Calculate if you passed or failed a class.");
                Console.WriteLine("3: Multiply two values.");
                Console.WriteLine("4: Divide one value by another.");
                Console.WriteLine("5: Compare two values and return the biggest value.");
                Console.WriteLine("6: Determine if a number is odd or even.");
                Console.WriteLine("7: Exit");

                string optionStr = Console.ReadLine();
                int option = int.Parse(optionStr);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("You have chosen option {0}", option);
                        EmployeeIncome();
                        flag = true;
                        break;
                    case 2:
                        Console.WriteLine("You have chosen option {0}", option);
                        PassOrFail();
                        flag = true;
                        break;
                    case 3:
                        Console.WriteLine("You have chosen option {0}", option);
                        Multiply2Values();
                        flag = true;
                        break;
                    case 4:
                        Console.WriteLine("You have chosen option {0}", option);
                        flag = true;
                        break;
                    case 5:
                        Console.WriteLine("You have chosen option {0}", option);
                        flag = true;
                        break;
                    case 6:
                        Console.WriteLine("You have chosen option {0}", option);
                        flag = true;
                        break;
                    case 7:
                        Console.WriteLine("You have chosen to exit.");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You did not select a valid option.");
                        break;
                }
            } while (flag);
        }

        private static void EmployeeIncome()
        {
            Console.WriteLine("How many hours per day do you work?");
            decimal hoursPerDay = decimal.Parse(Console.ReadLine());

            Console.WriteLine("How many days did you work this month?");
            decimal workDaysPerMonth = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What is your hourly wage?");
            decimal wagePerHour = decimal.Parse(Console.ReadLine());

            decimal dollarsPerMonth = wagePerHour * hoursPerDay * workDaysPerMonth;

            Console.WriteLine("Your monthly income is ${0}", dollarsPerMonth);
        }

        private static void PassOrFail()
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
        private static void Multiply2Values()
        {
            Console.WriteLine("Give me any number except for zero");
            float mult1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Give me any number except for zero");
            float mult2 = float.Parse(Console.ReadLine());
            float multAnswer = 0;

            if (mult1 == 0 || mult2 == 0)
            {
                Console.WriteLine("One of your numbers was zero, therefore the answer is zero.");
            }
            else
            {
                multAnswer = mult1 * mult2;
            }
            Console.WriteLine($"{mult1} x {mult2} = {multAnswer}", multAnswer);
        }
        private static void Divide2Values()
        {
            Console.WriteLine("Give me any number.");
            float div1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Give me any number except for zero");
            float div2 = float.Parse(Console.ReadLine());
            float divAnswer = 0;

            if (div2 == 0)
            {
                Console.WriteLine("Your second number was zero. I cannot divide by zero.");
            }
            else
            {
                divAnswer = div1 / div2;
            }
            Console.WriteLine($"{mult1} x {mult2} = {multAnswer}", multAnswer);
        }
    }
}
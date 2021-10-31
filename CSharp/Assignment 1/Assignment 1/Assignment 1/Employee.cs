using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Employee
    {
        public static void EmployeeIncome()
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
    }
}

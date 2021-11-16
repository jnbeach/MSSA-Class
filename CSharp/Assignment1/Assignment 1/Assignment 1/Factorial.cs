using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Factorial
    {
        public static void FactorialInput()
        {
            string doFlag = "y";
            do
            {
                Console.WriteLine("Please give me a positive integer.");
                int number1 = 0;
                try
                {
                    number1 = int.Parse(Console.ReadLine());
                    Exception negativeInt = new StackOverflowException("You entered a negative number!");
                    if (number1 < 0)
                    {
                        throw negativeInt;
                    }
                    int factResult = Factorial.FactorialCalc(number1);
                    Console.WriteLine($"{number1}! = {factResult}");
                    Console.WriteLine("Would you like to calculate another number? y/n");
                    doFlag = Console.ReadLine();
                    if (doFlag != "y")
                    {
                        Console.WriteLine("You either typed 'n' or another value. Exiting now");
                    }
                }
                catch (StackOverflowException stack)
                {
                    Console.WriteLine($"\n + {stack} \n");
                    Console.WriteLine("Your number wasn't positive! Please Enter a different number.");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("You didn't type an integer. Please enter a different number.");
                }
            } while (doFlag == "y");
        }
        public static int FactorialCalc(int number)
        {
            int result = 0;
                if (number == 0) {
                    result = 1;
                }
                else {
                    result = number * FactorialCalc(number - 1);
                }
                return result;
        }
    }
}

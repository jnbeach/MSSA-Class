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
            Console.WriteLine("Please give me a positive integer.");
            int number1 = 0;
            try
            {
                number1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("You didn't type an integer. Sorry. I assumed you typed 0");
            }
            int factResult = Factorial.FactorialCalc(number1);
            Console.WriteLine(factResult);
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

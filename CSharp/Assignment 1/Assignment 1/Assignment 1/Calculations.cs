using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Calculations
    {
        public static void Multiply2Values()
        {
            Console.WriteLine("Give me any number except for zero");
            float mult1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Give me any number to multiply it with except for zero");
            float mult2 = float.Parse(Console.ReadLine());
            float multAnswer = 0;

            if (mult1 == 0 || mult2 == 0)
            {
                Console.WriteLine("One of your numbers was zero, therefore the answer is zero.");
            }
            else
            {
                multAnswer = mult1 * mult2;
                Console.WriteLine($"{mult1} x {mult2} = {multAnswer}", multAnswer);
            }

        }
        public static void Divide2Values()
        {
            Console.WriteLine("Give me any number.");
            float div1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Give me any number to divide by except for zero");
            float div2 = float.Parse(Console.ReadLine());
            float divAnswer = 0;

            if (div2 == 0)
            {
                Console.WriteLine("Your second number was zero. I cannot divide by zero.");
            }
            else
            {
                divAnswer = div1 / div2;
                Console.WriteLine($"{div1} / {div2} = {divAnswer}", divAnswer);
            }

        }
        public static void Compare2Values()
        {
            Console.WriteLine("Give me any number.");
            float compare1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to compare it to.");
            float compare2 = float.Parse(Console.ReadLine());

            if (compare2 > compare1)
            {
                Console.WriteLine($"{compare2} was greater than {compare1}.");
            }
            else if (compare2 == compare1)
            {
                Console.WriteLine($"{compare2} was equal to {compare1}.");
            }
            else
            {
                Console.WriteLine($"{compare2} was less than {compare1}.");
            }
        }        

    }
}

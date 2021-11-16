using System;

namespace Hourglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Hourglasses");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Please give me an integer greater than 0, and I will print out an Hourglass of that size.");
            int maxSize = Convert.ToInt32(Console.ReadLine());
            int lineCounter = 0;
            for (int i = maxSize; i > 0; i -= 2)
            {
                Console.Write("\n");
                for (int k = 0; k < lineCounter; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                lineCounter++;
            }

            for (int i = maxSize; i > 0; i -= 2)
            {
                Console.Write("\n");
                for (int k = 0; k < lineCounter - 1; k++)
                {
                    Console.Write(" ");
                }
                for (int j = maxSize % 2; j < maxSize - i + 2; j++)
                {
                    Console.Write("*");
                }
                lineCounter--;
            }
        }
    }
}
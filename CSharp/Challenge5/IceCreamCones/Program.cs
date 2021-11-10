using System;

namespace IceCreamCones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Ice Cream Cones");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Please give me an integer greater than 0, and I will print out an ice cream cone of that size.");
            int maxSize = int.Parse(Console.ReadLine());
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
        }
    }
}

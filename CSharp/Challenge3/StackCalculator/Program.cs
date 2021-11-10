using System;
using System.Collections.Generic;

namespace StackCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Stack Calculator");
            Console.WriteLine("--------------------------------------");
            Stack<int> calcStack = new Stack<int>();
            Console.WriteLine("How many integers would you to input onto the stack?");
            int numsInStack = int.Parse(Console.ReadLine());
            int tempNum = 0;
            for (int i = 0; i < numsInStack; i++)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Please enter a number below (not 0 please):");
                tempNum = int.Parse(Console.ReadLine());
                calcStack.Push(tempNum);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("The stack is as follows:\n");
            foreach (int num in calcStack)
            {
                Console.Write($"{Convert.ToString(num)}; ");
            }
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Specify an operation to perform (+, -, *, /)");
            string operation = Console.ReadLine();
            float result;
            switch (operation)
            {
                case "+":
                    result = 0;
                    for (int i = 0; i < numsInStack; i++)
                    {
                        result += calcStack.Pop();
                    }
                    Console.WriteLine($"Result: {result}");
                    break;
                case "-":
                    result = calcStack.Pop();
                    for (int i = 0; i < numsInStack - 1; i++)
                    {
                        result -= calcStack.Pop();
                    }
                    Console.WriteLine($"Result: {result}");
                    break;
                case "*":
                    result = 1;
                    for (int i = 0; i < numsInStack; i++)
                    {
                        result *= calcStack.Pop();
                    }
                    Console.WriteLine($"Result: {result}");
                    break;
                case "/":
                    result = calcStack.Pop();
                    for (int i = 0; i < numsInStack - 1; i++)
                    {
                        result /= calcStack.Pop();
                    }
                    Console.WriteLine($"Result: {result}");
                    break;
                default:
                    Console.WriteLine("I did not understand your input. Exiting.");
                    Console.WriteLine("Press any key to continue:");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

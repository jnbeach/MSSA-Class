using System;
using System.Collections.Generic;

namespace BankQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Bank Queue");
            Console.WriteLine("--------------------------------------");
            Queue<string> bankQueue = new Queue<string>();
            Queue<int> bankQueueNumbers = new Queue<int>();
            int lineNumber = 0;
            displayMenu(ref bankQueue, ref bankQueueNumbers, ref lineNumber);
        }

        static void displayMenu(ref Queue<string> bankQueue, ref Queue<int> bankQueueNumbers, ref int lineNumber)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a person to the queue.");
                Console.WriteLine("2. Remove a person from the queue.");
                Console.WriteLine("3. Display the queue.");
                Console.WriteLine("0. Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        queueNextPerson(ref bankQueue, ref bankQueueNumbers, ref lineNumber);
                        break;
                    case 2:
                        seeNextPerson(ref bankQueue, ref bankQueueNumbers);
                        break;
                    case 3:
                        displayQueue(ref bankQueue, ref bankQueueNumbers);
                        break;
                    case 0:
                        Console.WriteLine("Exiting. Please press any key to continue.");
                        Console.ReadKey();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Input not understood. Exiting now. Press any key to continue.");
                        Console.ReadKey();
                        flag = false;
                        break;
                }
            } while (flag);
        }
        static void queueNextPerson(ref Queue<string> bankQueue, ref Queue<int> bankQueueNumbers, ref int lineNumber)
        {
            Console.WriteLine("You are next in line. Please enter your name:");
            string nextName = Console.ReadLine();
            bankQueue.Enqueue(nextName);
            lineNumber++;
            bankQueueNumbers.Enqueue(lineNumber);
            Console.WriteLine($"\nThank you {nextName}. You are entered into the queue.");
            Console.WriteLine($"\nYour number is: {lineNumber}. Please have a seat until your number is called.");
            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        static void seeNextPerson(ref Queue<string> bankQueue, ref Queue<int> bankQueueNumbers)
        {

            Console.WriteLine($"Hello, {bankQueue.Peek()} (Number:{bankQueueNumbers.Peek()}). You are next. Please come up to the next available representative.");
            bankQueue.Dequeue();
            bankQueueNumbers.Dequeue();
            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        static void displayQueue(ref Queue<string> bankQueue, ref Queue<int> bankQueueNumbers)
        {

            Console.WriteLine("Displaying queue:");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < bankQueue.Count; i++)
            {
                Console.WriteLine($"{Convert.ToString(bankQueueNumbers.ToArray()[i])}: {bankQueue.ToArray()[i]}");
            }
            Console.WriteLine("----------------------------------");
        }
    }
}

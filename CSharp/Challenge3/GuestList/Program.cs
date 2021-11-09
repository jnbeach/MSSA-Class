using System;
using System.Collections;
using System.Collections.Generic;

namespace GuestList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Guest List");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Let's make a list of guests for your super awesome party!");
            Console.WriteLine("Please select an option below:");
            Console.WriteLine("1. Generate guest list using lists.");
            Console.WriteLine("2. Generate guest list using array of strings.");
            Console.WriteLine("0. Exit");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    guestListWithList();
                    break;
                case 2:
                    guestListWithArray();
                    break;
                case 0:
                    Console.WriteLine("Exiting now... Press any key to exit.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Exiting now... Press any key to exit.");
                    Console.ReadKey();
                    break;
            }

        }
        static void guestListWithList()
        {
            string addMoreGuests = "y";
            List<string> guestList = new List<string>();
            do
            {
                Console.WriteLine("How many guests would you like to add?");
                int guestsToAdd = int.Parse(Console.ReadLine());
                string guestInput = "";
                for (int i = 0; i < guestsToAdd; i++)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Please input a name:");
                    guestInput = Console.ReadLine();
                    guestList.Add(guestInput);
                    Console.WriteLine($"{guestInput} has been added to the guest list.");
                }
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("All guests have been added. Printing the full guest list:\n");
                foreach (string guest in guestList)
                {
                    Console.Write($"{guest} ");
                }
                Console.WriteLine("\n--------------------------------------");
                Console.WriteLine("\nWould you like to add more guests? y/n");
                addMoreGuests = Console.ReadLine();
                if (addMoreGuests != "y" && addMoreGuests != "n")
                {
                    Console.WriteLine("Sorry, I didn't understand that. I assume you want to add more guests.");
                }
            } while (addMoreGuests != "n");
        }
        static void guestListWithArray()
        {
            string addMoreGuests = "y";
            string[] guestList = new string[0];
            do
            {
                Console.WriteLine("How many guests would you like to add?");
                int guestsToAdd = int.Parse(Console.ReadLine());
                string guestInput = "";
                for (int i = 0; i < guestsToAdd; i++)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Please input a name:");
                    guestInput = Console.ReadLine();
                    // Can't 'add' elements to an array like in javascript. Have to resize and then set the new element to a new value.
                    Array.Resize(ref guestList, guestList.Length + 1);
                    guestList[guestList.Length - 1] = guestInput;
                    Console.WriteLine($"{guestInput} has been added to the guest list.");
                }
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("All guests have been added. Printing the full guest list:\n");
                foreach (string guest in guestList)
                {
                    Console.Write($"{guest} ");
                }
                Console.WriteLine("\n--------------------------------------");
                Console.WriteLine("\nWould you like to add more guests? y/n");
                addMoreGuests = Console.ReadLine();
                if (addMoreGuests != "y" && addMoreGuests != "n")
                {
                    Console.WriteLine("Sorry, I didn't understand that. I assume you want to add more guests.");
                }
            } while (addMoreGuests != "n");
        }
    }
}

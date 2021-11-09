using System;
using System.Collections.Generic;

namespace EnglishSpanishDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Mini Spanish Dictionary");
            Console.WriteLine("--------------------------------------");
            Dictionary<string, string> engToSpan = makeDictionary();
            displayMenu(ref engToSpan);
        }
        static Dictionary<string, string> makeDictionary()
        {
            Dictionary<string, string> tempDictionary = new Dictionary<string, string>();

            tempDictionary.Add("song", "canción");
            tempDictionary.Add("heart", "corazón");
            tempDictionary.Add("music", "música");
            tempDictionary.Add("guitar", "guitarra");
            tempDictionary.Add("rhythm", "ritmo");
            tempDictionary.Add("drums", "tambores");
            tempDictionary.Add("bass", "bajo");
            Console.WriteLine("List of Entries");
            Console.WriteLine("--------------------------------------");
            displayDictionary(ref tempDictionary);
            return tempDictionary;
        }
        static void displayDictionary(ref Dictionary<string, string> engToSpan)
        {
            foreach (KeyValuePair<string, string> kvp in engToSpan)
            {
                Console.WriteLine(kvp.Key);
            }
            Console.WriteLine("--------------------------------------");
        }
        static void displayMenu(ref Dictionary<string, string> engToSpan)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Would you like to look up or add words?");
                Console.WriteLine("1. Look up words");
                Console.WriteLine("2. Add words");
                Console.WriteLine("0. Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        lookUpWords(ref engToSpan);
                        break;
                    case 2:
                        addWords(ref engToSpan);
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
        static void lookUpWords(ref Dictionary<string, string> engToSpan)
        {
            string lookUpAnotherWord = "y";
            do
            {
                try
                {
                    displayDictionary(ref engToSpan);
                    Console.WriteLine("Which word would you like to look up?");
                    Console.WriteLine("--------------------------------------");
                    string wordToLookUp = Console.ReadLine().ToLower();
                    Console.WriteLine($"{wordToLookUp}: {engToSpan[wordToLookUp]}");
                }
                catch (System.Collections.Generic.KeyNotFoundException keyNotFound)
                {
                    Console.WriteLine("Sorry! That word does not exist.");
                }
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Would you like to look up another word? (y/n)");
                if (lookUpAnotherWord != "y" && lookUpAnotherWord != "n")
                {
                    Console.WriteLine("Sorry, I didn't understand that.");
                }
                lookUpAnotherWord = Console.ReadLine();
                Console.WriteLine("--------------------------------------");
            } while (lookUpAnotherWord == "y");

        }
        static void addWords(ref Dictionary<string, string> engToSpan)
        {
            string addAnotherWord = "y";
            do
            {
                Console.WriteLine("Please give me an English Word:");
                string newKey = Console.ReadLine().ToLower();
                Console.WriteLine("Please give me the Spanish translation:");
                string newValue = Console.ReadLine().ToLower();
                engToSpan.Add(newKey, newValue);
                Console.WriteLine($"{newKey}: {newValue} has been added.");
                Console.WriteLine("--------------------------------------");
                displayDictionary(ref engToSpan);
                Console.WriteLine("Would you like to add another word? (y/n)");
                if (addAnotherWord != "y" && addAnotherWord != "n")
                {
                    Console.WriteLine("Sorry, I didn't understand that.");
                }
                addAnotherWord = Console.ReadLine();
                Console.WriteLine("--------------------------------------");
            } while (addAnotherWord == "y");

        }
    }
}

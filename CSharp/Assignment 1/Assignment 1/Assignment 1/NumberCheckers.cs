using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class NumberCheckers
    {
        public static void EvenOrOdd()
        {
            Console.WriteLine("Give me any integer.");
            int number1 = int.Parse(Console.ReadLine());

            int evenOrOdd = number1 % 2;

            if (evenOrOdd == 1)
            {
                Console.WriteLine($"{number1} is an odd number");
            }
            else
            {
                Console.WriteLine($"{number1} is an even number");
            }
        }
        public static void NumberGuesser()
        {

            Console.WriteLine("I am coming up with a number between 1 and 100!");
            Random randConstructor = new Random();
            int compInt = randConstructor.Next(1, 100);

            //The code below generates hint messages for the user based on what the number is.

            string hintMessage1 = "";
            string hintMessage2 = "";
            int finderCounter = 10;
            bool finderFlag = true;
            while (finderCounter <= 100 && finderFlag)
            {
                if (compInt < finderCounter)
                {
                    hintMessage1 = $"Hint: The number is between {finderCounter-9} and {finderCounter}.";
                    hintMessage2 = $"Hint: The number is between {finderCounter-5} and {finderCounter}.";
                    finderFlag = false;
                }
                finderCounter += 10;
            }

            Console.WriteLine("Number generated!");

            // Guess counter keeps track of the number of guesses.
            int guessCounter = 0;

        GuessStart:
            Console.WriteLine("Please guess an integer between 1 and 100.");
            int guess = int.Parse(Console.ReadLine());
            guessCounter += 1;

            if (guess == compInt)
            {
                Console.WriteLine("Congrats! That number was correct!");
            }
            else if (guessCounter < 3)
            {
                Console.WriteLine("That was incorrect. Guess again!");
                switch (guessCounter)
                {
                    case 1:
                        Console.WriteLine(hintMessage1);
                        break;
                    case 2:
                        Console.WriteLine(hintMessage2);
                        break;
                    default:
                        break;
                }
                goto GuessStart;
            }
            else
            {
                Console.WriteLine("Sorry you lose! The correct number was {0} \nYou have used up all of your guesses!", compInt);
            }

        }
        public static void PrimeNumberChecker()
        {
            Console.WriteLine("Give me any integer and I will tell you if it is a prime number.");
            int number1 = int.Parse(Console.ReadLine());
            int primeChecker = 0;
            bool isPrime = true;
            int divisibleBy = 1;
            for (int i = 2; i < number1; i++)
            {
                primeChecker = number1 % i;
                if (primeChecker == 0)
                {
                    isPrime = false;
                    divisibleBy = i;
                    goto PrintPrimeResult;
                }
            }

        PrintPrimeResult:
            if (isPrime == true)
            {
                Console.WriteLine($"{number1} is a prime number!");
            }
            else
            {
                Console.WriteLine($"{number1} is not a prime number. The lowest number it was divisible by was {divisibleBy}");
            }
        }
    }
}

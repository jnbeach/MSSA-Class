using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Calculations
    {
        public void Multiply2Values()
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
        public void Divide2Values()
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
        public void Compare2Values()
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
        public void CubeValue()
        {
            Console.WriteLine("Give me any number:");
            double input1 = double.Parse(Console.ReadLine());
            double cubeResult = Math.Pow(input1, 3);
            Console.WriteLine($"The cube of {input1} is {cubeResult}");            
        }
        public void AverageOfInts()
        {
            Console.WriteLine("How many integers will you give me?");
            int numOfInts = int.Parse(Console.ReadLine());
            int tempSum = 0;
            for (int i = 0; i < numOfInts; i++)
            {
                Console.WriteLine("Give me an integer");
                tempSum += int.Parse(Console.ReadLine());
            }
            float average = tempSum / numOfInts;
            Console.WriteLine($"The average of the {numOfInts} number(s) that you gave me is: {average}");
        }

        public void MultiplicationTable()
        {
            Console.WriteLine("Give me an integer and I will print out a multiplication table.");
            int maxNumber = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("");
                for (int j = 1; j <= maxNumber; j++)
                {
                    Console.Write($"{j*i}\t");
                }
            }
        }

        public void AlphaChecker()
        {
            Console.WriteLine("Give me a 3 letter string to check for CONSECUTIVE alphabetization.");
            string userInput = Console.ReadLine();
            //Lowercase everything so that the unicode can just be compared.
            userInput = userInput.ToLower();
            char char1 = Convert.ToChar(userInput[0]);
            //Apparently you can typecast by using the below syntax?
            int char1Int = (int)char1;
            char char2 = Convert.ToChar(userInput[1]);
            int char2Int = (int)char2;
            char char3 = Convert.ToChar(userInput[2]);
            int char3Int = (int)char3;

            Console.WriteLine($"Char values: {char1Int} {char2Int} {char3Int}");
            
            if (char1Int == char2Int -1 && char1Int == char3Int-2)
            {
                Console.WriteLine("This string is alphabetized with no missing character in between!");
            }
            else
            {
                Console.WriteLine("This string is not CONSECUTIVELY alphabetized!");
            }
        }
    }
}

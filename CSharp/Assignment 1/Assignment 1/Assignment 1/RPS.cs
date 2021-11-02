using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class RPS
    {
        public static void RockPaperScissor()
        {
            string playAgain = "y";
            do
            {
                Console.WriteLine("Let's play Rock, Paper, Scissors! Type r, p, or s");
                try
                {
                    string playerMove = Console.ReadLine();

                    string[] choices = { "r", "p", "s" };

                    Random randChoice = new Random();
                    var compChoice = randChoice.Next(0, 2);
                    string compMove = choices[compChoice];

                    if (compMove == playerMove)
                    {
                        Console.WriteLine("Computer picked {0}. That's a tie!", compMove);
                    }
                    else if (compMove == "r" && playerMove == "p")
                    {

                        Console.WriteLine("Computer picked {0}. You win.", compMove);
                    }
                    else if (compMove == "p" && playerMove == "s")
                    {
                        Console.WriteLine("Computer picked {0}. You win.", compMove);
                    }
                    else if (compMove == "s" && playerMove == "r")
                    {
                        Console.WriteLine("Computer picked {0}. You win.", compMove);
                    }
                    else
                    {
                        Console.WriteLine("Computer picked {0}. You lose.", compMove);
                    }
                    Console.WriteLine("Would you like to play again? y/n");
                    playAgain = Console.ReadLine();
                    if (playAgain != "y")
                    {
                        Console.WriteLine("Thanks for playing! Press any key to go back.");
                        Console.ReadKey();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You definitely messed up. Here is your error.");
                    Console.WriteLine(e);                    
                }
            } while (playAgain == "y");
        }
    }
}

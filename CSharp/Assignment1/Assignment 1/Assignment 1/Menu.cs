using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Menu
    {
        public static void DisplayMenu()
        {
            bool flag = false;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("\n(=^.^=)");
                Console.WriteLine("\n Please input an option number (1-12), 0 to exit.");
                Console.WriteLine("1: Calculate the income of an employee.");
                Console.WriteLine("2: Calculate if you passed or failed a class.");
                Console.WriteLine("3: Multiply two values.");
                Console.WriteLine("4: Divide one value by another.");
                Console.WriteLine("5: Compare two values and return the biggest value.");
                Console.WriteLine("6: Determine if a number is odd or even.");
                Console.WriteLine("7: Number Guesser");
                Console.WriteLine("8: Prime Number Checker");
                Console.WriteLine("9: Factorial Calculator");
                Console.WriteLine("10: What Season Is It?");
                Console.WriteLine("11: Play Rock Paper Scissors");
                Console.WriteLine("12: Swap Inputs");
                Console.WriteLine("13: Cube of a Number");
                Console.WriteLine("14: Average of a Number of Integers");
                Console.WriteLine("15: Generate Multiplication Table");
                Console.WriteLine("16: Alphabetization Detector");
                Console.WriteLine("0: Exit");

                string optionStr = Console.ReadLine();
                int option = int.Parse(optionStr);

                Employee dummyEmployee = new Employee();
                Student dummyStudent = new Student();
                Calculations calculator = new Calculations();
                NumberCheckers numberChecker = new NumberCheckers();

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        dummyEmployee.EmployeeIncome();
                        Console.WriteLine("");
                        flag = true;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        dummyStudent.PassOrFail();
                        Console.WriteLine("");
                        flag = true;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        calculator.Multiply2Values();
                        Console.WriteLine();
                        flag = true;
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        calculator.Divide2Values();
                        Console.WriteLine("");
                        flag = true;
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        calculator.Compare2Values();
                        Console.WriteLine("");
                        flag = true;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        numberChecker.EvenOrOdd();
                        Console.WriteLine("");
                        flag = true;
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        numberChecker.NumberGuesser();
                        Console.WriteLine("");
                        flag = true;
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        numberChecker.PrimeNumberChecker();
                        Console.WriteLine("");
                        flag = true;
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        Factorial.FactorialInput();
                        Console.WriteLine("");
                        Console.ReadKey();
                        flag = true;
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        SeasonFinder.FourSeasons();
                        Console.WriteLine("");
                        Console.ReadKey();
                        flag = true;
                        break;
                    case 11:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        RPS.RockPaperScissor();
                        Console.WriteLine("");
                        Console.ReadKey();
                        flag = true;
                        break;
                    case 12:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        Swap.GetInputsAndSwap();
                        Console.WriteLine("");
                        Console.ReadKey();
                        flag = true;
                        break;
                    case 13:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        calculator.CubeValue();
                        Console.WriteLine("");
                        Console.ReadKey();
                        flag = true;
                        break;
                    case 14:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        calculator.AverageOfInts();
                        Console.WriteLine("");
                        Console.ReadKey();
                        flag = true;
                        break;
                    case 15:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        calculator.MultiplicationTable();
                        Console.WriteLine("");
                        Console.ReadKey();
                        flag = true;
                        break;
                    case 16:
                        Console.Clear();
                        Console.WriteLine("You have chosen option {0} \n", option);
                        calculator.AlphaChecker();
                        Console.WriteLine("");
                        Console.ReadKey();
                        flag = true;
                        break;
                    case 0:
                        Console.WriteLine("You have chosen to exit.");
                        Console.WriteLine("");
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("You did not select a valid option.");
                        Console.WriteLine("");
                        break;
                }
            } while (flag);
        }
    }
}

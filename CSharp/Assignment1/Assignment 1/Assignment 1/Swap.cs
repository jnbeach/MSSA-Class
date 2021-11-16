using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Swap
    {
        public static void GetInputsAndSwap()
        {
            Console.WriteLine("Please enter number 1");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 2");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Swap.SwapInputs(ref input1,ref input2);
        }

        public static void SwapInputs(ref int input1, ref int input2)
        {
            int tempinput1 = input1;
            Console.WriteLine("Original values:");
            Console.WriteLine($"Input 1: {input1} Input 2: {input2}");
            input1 = input2;
            input2 = tempinput1;

            Console.WriteLine("Input 1 has been swapped with Input 2.");
            Console.WriteLine($"Input 1 is now: {input1} Input 2 is now: {input2}");
        }
    }
}
using System;

namespace GenericCalcClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calc<int> intCalc = new Calc<int>();
            Calc<float> floatCalc = new Calc<float>();
            Calc<decimal> decimalCalc = new Calc<decimal>();

        }
    }
}

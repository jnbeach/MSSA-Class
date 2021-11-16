using System;

namespace GenericCalcClass
{
    class Calc<T> where T : struct
    {

        public static T Add<T, T>(T number1, T number2)
        {
            T sum = number1 + number2;
            return sum;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork7_Algorithm
{
    internal class NumberReverser
    {
        public static int Reverse(int number)
        {
            bool isNegative = number < 0;
            number = Math.Abs(number);
            int reversed = 0;

            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            return isNegative ? -reversed : reversed;
        }
    }
}
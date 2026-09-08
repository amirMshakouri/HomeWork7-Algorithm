using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork7_Algorithm
{
    internal class Task1_DigitCounter
    {
        public static int CountDigits(int number)
        {
            if (number == 0)
                return 1;

            int count = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                number /= 10;
                count++;
            }

            return count;
        }
    }
}
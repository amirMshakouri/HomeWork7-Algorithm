using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork7_Algorithm
{
    
        internal class DigitSum
        {
            public static int SumDigits(int number)
            {
                number = Math.Abs(number);
                int sum = 0;

                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                return sum;
            }
        }
    
}

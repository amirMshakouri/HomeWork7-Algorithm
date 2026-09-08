using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork7_Algorithm
{
    internal class BinaryConverter
    {
        public static string ToBinary(int number)
        {
            if (number == 0)
                return "0";

            string result = "";

            while (number > 0)
            {
                result = (number % 2) + result;
                number /= 2;
            }

            return result;
        }
    }
}

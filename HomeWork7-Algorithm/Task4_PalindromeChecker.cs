using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork7_Algorithm
{
    internal class PalindromeChecker
    {
        public static bool IsPalindrome(int number)
        {
            int original = number;
            int reversed = NumberReverser.Reverse(number);

            return original == reversed;
        }
    }
}
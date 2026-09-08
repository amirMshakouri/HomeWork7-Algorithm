using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace HomeWork7_Algorithm
{
    internal class DuplicateChecker
    {
        public static bool HasDuplicates(int[] numbers)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int number in numbers)
            {
                if (!seen.Add(number))
                    return true;
            }

            return false;
        }
    }
}
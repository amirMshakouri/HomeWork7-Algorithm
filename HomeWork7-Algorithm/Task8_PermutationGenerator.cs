using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.Generic;

namespace HomeWork7_Algorithm
{
    internal class PermutationGenerator
    {
        public static List<string> GeneratePermutations(string input)
        {
            List<string> result = new List<string>();
            Permute("", input, result);
            return result;
        }

        private static void Permute(string prefix, string remaining, List<string> result)
        {
            if (remaining.Length == 0)
            {
                result.Add(prefix);
                return;
            }

            for (int i = 0; i < remaining.Length; i++)
            {
                string newRemaining = remaining.Remove(i, 1);
                Permute(prefix + remaining[i], newRemaining, result);
            }
        }
    }
}
namespace HomeWork7_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digits of 12345: " + Task1_DigitCounter.CountDigits(12345));
            Console.WriteLine("Is 7 prime? " + PrimeChecker.IsPrime(7));
            Console.WriteLine("Sum of digits of -123: " + DigitSum.SumDigits(-123));
            Console.WriteLine("Is 1331 palindrome? " + PalindromeChecker.IsPalindrome(1331));
            Console.WriteLine("GCD of 48,18: " + GcdCalculator.FindGcd(48, 18));
            Console.WriteLine("Reverse of 1234: " + NumberReverser.Reverse(1234));
            Console.WriteLine("Binary of 10: " + BinaryConverter.ToBinary(10));

            Console.WriteLine("Permutations of ABC:");
            foreach (var p in PermutationGenerator.GeneratePermutations("ABC"))
                Console.Write(p + " ");
            Console.WriteLine();

            int[] arr = { 1, 2, 3, 4, 2 };
            Console.WriteLine("Has duplicates? " + DuplicateChecker.HasDuplicates(arr));
        }
    }
}

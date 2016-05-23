namespace Problem25
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEevenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEevenDigit(int n)
        {
            string number = Convert.ToString(n);
            return number.Any(item => int.Parse(item.ToString()) % 2 == 0);
        }

        private static bool IsPalindrome(int n)
        {
            string number = Convert.ToString(n);
            return !number.Where((t, i) => t != number[number.Length - 1 - i]).Any();
        }

        private static bool SumOfDigits(int n)
        {
            char[] arr = n.ToString().ToCharArray();
            int sum = arr.Sum(item => int.Parse(item.ToString()));
            return sum % 7 == 0;
        }
    }
}
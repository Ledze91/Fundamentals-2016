namespace Problem24
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main()
        {
            int startIndex = int.Parse(Console.ReadLine());
            int stopIndex = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Join(", ", FindPrimesInRange(startIndex, stopIndex)));
        }

        private static List<int> FindPrimesInRange(int startIndex, int stopIndex)
        {
            List<int> result = new List<int>();
            for (int i = startIndex; i <= stopIndex; i++)
            {
                if (isPrime(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private static bool isPrime(long n)
        {
            bool isPrime = !(n == 0 || n == 1);

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
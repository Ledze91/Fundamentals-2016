namespace Problem23
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(n));
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
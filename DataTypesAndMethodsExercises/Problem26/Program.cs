namespace Problem26
{
    using System;
    using System.Numerics;

    internal class Program
    {
        private static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }

        private static BigInteger Factorial(BigInteger n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
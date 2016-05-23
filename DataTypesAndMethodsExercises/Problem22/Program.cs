namespace Problem22
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(fib(input));
        }

        private static int fib(int input)
        {
            int fib = 1;
            int b = 1;
            for (int i = 0; i < input; i++)
            {
                int a = fib;
                fib = b;
                b = a + b;
            }
            return fib;
        }
    }
}
namespace Problem07
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int a1 = b;
            int b1 = a;
            Console.WriteLine("Before:\na = {0}\nb = {1}\nAfter:\na = {2}\nb = {3}"
                , a, b, a1, b1);
        }
    }
}
namespace Problem15
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool precision = Math.Abs(a - b) < 0.000001;
            Console.WriteLine(precision);
        }
    }
}
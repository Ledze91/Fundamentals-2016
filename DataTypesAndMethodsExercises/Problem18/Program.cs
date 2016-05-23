namespace Problem18
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            string name = Console.ReadLine();

            Print(name);
        }

        private static void Print(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
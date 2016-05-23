namespace Problem14
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string hexa = input.ToString("X");
            string binary = Convert.ToString(input, 2);
            Console.WriteLine($"{hexa}\r\n{binary}");
        }
    }
}
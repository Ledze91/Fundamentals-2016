namespace Problem04
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            int output = (Convert.ToInt32(input, 16));
            Console.WriteLine(output);
        }
    }
}
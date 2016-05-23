namespace Problem21
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            reverseMethod(input);
        }

        private static void reverseMethod(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
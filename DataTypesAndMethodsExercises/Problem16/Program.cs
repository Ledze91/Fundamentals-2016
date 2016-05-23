namespace Problem16
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            int startIndex = int.Parse(Console.ReadLine());
            int stopIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= stopIndex; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
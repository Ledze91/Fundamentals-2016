namespace Problem05
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            bool output = (Convert.ToBoolean(input));
            if (output == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
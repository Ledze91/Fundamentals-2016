namespace Problem17
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                long longNum = long.Parse(input);
                Console.WriteLine($"{longNum} can fit in:");
                if (longNum >= sbyte.MinValue && longNum <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (longNum >= byte.MinValue && longNum <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (longNum >= short.MinValue && longNum <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (longNum >= ushort.MinValue && longNum <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (longNum >= int.MinValue && longNum <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (longNum >= uint.MinValue && longNum <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (longNum >= long.MinValue && longNum <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}
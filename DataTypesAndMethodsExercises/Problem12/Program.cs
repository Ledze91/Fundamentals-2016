namespace Problem12
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = (2 * width) + (2 * height);
            double area = width * height;
            double diagonal = Math.Sqrt(width * width + height * height);
            Console.WriteLine("{0}\n{1}\n{2}", perimeter, area, diagonal);
        }
    }
}
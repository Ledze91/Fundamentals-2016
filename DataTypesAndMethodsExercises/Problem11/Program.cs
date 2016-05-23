namespace Problem11
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float hourTime = hours + minutes / 60.0f + seconds / 3600.0f;
            float kilometerSpeed = (distance / 1000.0f) / hourTime;
            float milesSpeed = (distance / 1609.0f) / hourTime;
            float metersSpeed = kilometerSpeed / 3.6f;
            Console.WriteLine("{0}\n{1}\n{2}", metersSpeed, kilometerSpeed, milesSpeed);
        }
    }
}
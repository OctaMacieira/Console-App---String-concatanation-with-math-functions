using System;
using System.Globalization;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, area, pi;

            pi = 3.14159;

            r = double.Parse(Console.ReadLine());

            area = pi * (4.0 / 3) * Math.Pow(r, 3.0);

            Console.WriteLine("VOLUME = " + area.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

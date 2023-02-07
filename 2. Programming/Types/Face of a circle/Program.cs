using System;

namespace Face_of_a_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(Math.PI * r * r):f12}");
        }
    }
}

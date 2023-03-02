using System;

namespace Check_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (long.TryParse(input, out _)) Console.WriteLine("integer");
            else Console.WriteLine("floating-point");
        }
    }
}

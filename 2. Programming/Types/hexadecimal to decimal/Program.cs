using System;

namespace hexadecimal_to_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hexa = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexa, 16));
        }
    }
}

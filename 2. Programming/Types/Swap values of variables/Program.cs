using System;

namespace Swap_values_of_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;

            c = a;
            a= b;
            b= c;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {c}");
            Console.WriteLine($"b = {a}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}

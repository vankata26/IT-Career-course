using System;

namespace Reverse_an_array_of_character_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}

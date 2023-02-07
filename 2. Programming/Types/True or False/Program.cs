using System;

namespace True_or_False
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text == "True") Console.WriteLine("Yes");
            else if (text == "False") Console.WriteLine("No");
        }
    }
}

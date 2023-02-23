using System;
using System.Linq;

namespace Warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            long[] count = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string command = Console.ReadLine();
            while (command != "done")
            {
                int index = Array.IndexOf(names, command);
                if (index >= 0) Console.WriteLine($"{names[index]} costs: {price[index]}; Available quantity: {count[index]}")

                command = Console.ReadLine();
            }
        }
    }
}

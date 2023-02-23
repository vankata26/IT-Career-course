using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            list.Reverse();

            Console.WriteLine(string.Join("; ", list));
        }
    }
}

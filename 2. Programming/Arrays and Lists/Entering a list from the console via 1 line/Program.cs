using System;
using System.Collections.Generic;
using System.Linq;

namespace Entering_a_list_from_the_console_via_1_line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"nums{{{i}}} = {list[i]}");
        }
    }
}

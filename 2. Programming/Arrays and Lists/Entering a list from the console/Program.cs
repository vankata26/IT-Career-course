using System;
using System.Collections.Generic;
using System.Linq;

namespace Entering_a_list_from_the_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++) list.Add(int.Parse(Console.ReadLine()));

            for (int i = 0; i < list.Count; i++) Console.WriteLine($"list{{{i}}} = {list[i]}");
        }
    }
}

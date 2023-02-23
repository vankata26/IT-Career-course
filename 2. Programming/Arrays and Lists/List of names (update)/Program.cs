using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_names__update_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();

            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                string[] names = list[i].Split();
                Console.WriteLine($"{names[1]} {names[0]}");
            }
        }
    }
}

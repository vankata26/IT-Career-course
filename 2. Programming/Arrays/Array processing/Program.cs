using System;
using System.Diagnostics;
using System.Linq;

namespace Array_processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string commandName = command[0];

                if (commandName == "Reverse") Array.Reverse(words);
                else if (commandName == "Distinct") words = words.Distinct().ToArray();
                else if (commandName == "Replace")
                {
                    int index = int.Parse(command[1]);
                    string newValue = command[2];

                    words[index] = newValue;
                }
            }
            Console.WriteLine(string.Join(" ",words));
        }
    }
}

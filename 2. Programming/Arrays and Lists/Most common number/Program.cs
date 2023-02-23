using System;
using System.Linq;

namespace Most_common_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = 0, maxValue = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                        count++;
                }

                if (count > max)
                {
                    max = count;
                    maxValue = numbers[i];
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}

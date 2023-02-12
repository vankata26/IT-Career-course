using System;
using System.Linq;

namespace Rotate_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];

            for (int i = 0; i < k; i++)
            { 
                Rotate(numbers);
                for (int i1 = 0; i1 < numbers.Length; i1++)
                    sum[i1] += numbers[i1];
            }

            Console.WriteLine(string.Join(" ",sum));
        }
        static void Rotate(int[] numbers)
        {
            int last = numbers[numbers.Length - 1];

            for (int i = numbers.Length - 1; i >= 1; i--)
                numbers[i] = numbers[i - 1];
            numbers[0] = last;
        }
    }
}

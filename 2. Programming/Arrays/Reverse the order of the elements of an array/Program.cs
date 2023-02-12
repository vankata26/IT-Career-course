using System;

namespace Reverse_the_order_of_the_elements_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

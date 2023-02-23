using System;

namespace Set_of_the_sums_of_the_last_K_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            numbers[0] = 1;
            numbers[1] = 1;

            for (int i = 2; i < n; i++)
            {
                int sum = 0;
                for (int i1 = 1; i1 <= Math.Min(i, k); i1++)
                {
                    sum += numbers[i - i1];
                }
                numbers[i] = sum;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

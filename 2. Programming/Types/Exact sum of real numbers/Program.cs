﻿using System;

namespace Exact_sum_of_real_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());

                sum += numbers;
            }
            Console.WriteLine(sum);
        }
    }
}

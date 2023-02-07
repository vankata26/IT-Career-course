using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;

namespace MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());
            double price = 0;
            double transport = 0;

            if (category == "vip") price = 499.99;
            else if (category == "normal") price = 249.99;

            if (people <= 4) transport = buget * 0.75;
            else if (people <= 9) transport = buget * 0.6;
            else if (people <= 24) transport = buget * 0.5;
            else if (people <= 49) transport = buget * 0.4;
            else if (people >= 50) transport = buget * 0.25;
            buget -= transport;
            double sum = people * price;

            if (buget >= sum)
            {
                double leftMoney = Math.Abs(buget - sum);
                Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
            }
            else
            {
                double diff = Math.Abs(buget - sum);
                Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
            }
        }
    }
}

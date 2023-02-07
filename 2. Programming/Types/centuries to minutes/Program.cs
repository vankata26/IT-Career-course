using System;

namespace Centuries_to_minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte c = byte.Parse(Console.ReadLine());
            uint y = (uint)(100U * c);
            uint d = (uint)(y * 365.2422);
            ulong h = 24UL * d;
            ulong m = 60UL * h;
            ulong s = 60UL * m;
            Console.WriteLine($"{c} centuries = {y} years = {d} days = {h} hours = {m} minutes");
        }
    }
}

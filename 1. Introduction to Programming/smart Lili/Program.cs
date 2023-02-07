using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace troll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());//vuzrast
            double cenaPeralnq = double.Parse(Console.ReadLine());
            int edinichnaCena = int.Parse(Console.ReadLine());

            double sum = 0;
            int pari = 0;
            int sumIgrachki = 0;
            int broiIgrachki = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    pari += 10;
                    sum += pari - 1;
                }
                else broiIgrachki++;
            }
            sumIgrachki = broiIgrachki * edinichnaCena;
            sum += sumIgrachki;
            if (sum >= cenaPeralnq)
            {
                double ostatuk = sum - cenaPeralnq;
                Console.WriteLine($"Yes! {ostatuk:f2}");
            }
            else if (sum < cenaPeralnq)
            {
                double ostatuk2 = cenaPeralnq - sum;
                Console.WriteLine($"No! {ostatuk2:f2}");
            }
        }
    }
}

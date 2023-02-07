using System.Diagnostics.CodeAnalysis;

double budget = double.Parse(Console.ReadLine());
int video = int.Parse(Console.ReadLine());
int procesors = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

double sumVideo = video * 250;
double sumProcesors = (sumVideo * 0.35) * procesors;
double sumRam = (sumVideo * 0.1) * ram;

double allSum = sumVideo + sumProcesors + sumRam;
if (video > procesors)
{
    double discount = allSum * 0.15;
    allSum -= discount;
}
if (allSum < budget)
{
    double moneyLeft = budget - allSum;
    Console.WriteLine($"You have {moneyLeft:f2} leva left!");
}
else if (allSum > budget)
{
    double moneyNeed = budget - allSum;
    Console.WriteLine($"Not enough money! You need {-moneyNeed:f2} leva more!");
}

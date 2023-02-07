using System.Xml.Schema;

double priceForTrip = double.Parse(Console.ReadLine());
int puzzle = int.Parse(Console.ReadLine());
int doll = int.Parse(Console.ReadLine());
int bear = int.Parse(Console.ReadLine());
int mini =int.Parse(Console.ReadLine());
int truk = int.Parse(Console.ReadLine());
double broika = puzzle + doll + bear + mini + truk;

double sumPuzzle = puzzle * 2.6;
double sumDoll = doll * 3;
double sumBear = bear * 4.1;
double sumMini = mini * 8.2;
double sumTruk = truk * 2;
double sumAll = sumPuzzle + sumDoll + sumBear + sumMini + sumTruk;

double fullPrice = sumAll;

if (broika > 50)
{
    double discount = sumAll * 0.25;
    fullPrice = fullPrice - discount;
}
    double rent = fullPrice * 0.1;
    fullPrice = fullPrice - rent;
if (fullPrice - priceForTrip > 0)
{
    double leftMoney = fullPrice - priceForTrip;
    Console.WriteLine($"Yes! {leftMoney} lv left.");
}
else if (fullPrice - priceForTrip < 0) 
{
   double needMoney = fullPrice - priceForTrip;
    Console.WriteLine($"Not enough money! {-needMoney:f2} lv needed.");
}

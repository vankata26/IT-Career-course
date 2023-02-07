double budget = double.Parse(Console.ReadLine());
int statistics = int.Parse(Console.ReadLine());
double priceForDress = double.Parse(Console.ReadLine());

double decor = budget * 0.1;
double dressPrice = statistics * priceForDress;

if (statistics > 150) 
{ 
    double discount = dressPrice * 0.1;
    dressPrice -= discount;
}

double allSum = dressPrice + decor;

if (allSum > budget)
{
    double needMoney = budget - allSum;
    Console.WriteLine("Not enough momey");
    Console.WriteLine($"Wingard needs {-needMoney:f2} leva more.");
}
else if (allSum < budget)
{
    double leftMoney = budget - allSum;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingrad starts filming with {leftMoney:f2} leva left.");
}
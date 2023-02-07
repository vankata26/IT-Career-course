string name = Console.ReadLine();
double episodeTime = double.Parse(Console.ReadLine());
int breakTIme = int.Parse(Console.ReadLine());

double lunch = breakTIme * 0.125;
double reset = breakTIme * 0.25;
double resetLunch = lunch + reset;

double remaining = breakTIme - resetLunch;

if (remaining >= episodeTime)
{
    remaining -= episodeTime;
    Console.WriteLine($"You have enough time to watch {name} and left with {remaining} minutes free time.");
}
else 
{
    episodeTime -= remaining;
    Console.WriteLine($"You don't have enough time to watch {name}, you need {episodeTime} more minutes.");
}

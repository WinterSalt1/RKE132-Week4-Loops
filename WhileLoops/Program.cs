
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; // bool - true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"CPU has generated {cpuRandom}.");
    Console.WriteLine("Make a Guess. Enter a Number 1 - 3");
    int userNumber = Int32.Parse(Console.ReadLine());

    
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratsulations, you won!");
        //loopActive = false;
        break;

    }
    else
    {
        Console.WriteLine("Oops. Try again.");
    }
}

Console.WriteLine("Have a Nice Day :D");
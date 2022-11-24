

int sum = 0;

for(int i = 1; i < 4; i++) //i-- = i - 1
{

    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current Total: {sum}");
    sum = sum + i; //sum += i;

}
Console.WriteLine($"Final Total: {sum}");
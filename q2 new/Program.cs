int fizzwhizbuzzCount = 0;
int bongCount = 0;
int fizzCount = 0;
int fizzwhizCount = 0;



for (int x = 1; x <= 16; x++)
{

    if (x % 8 == 0)
    {
        fizzwhizbuzzCount++;
    }
    else if (x % 4 == 0)
    {
        fizzwhizCount++;
    }
    else if (x % 2 == 0)
    {
        fizzCount++;
    }
    else
    {
        bongCount++;
    }


}

Console.WriteLine($"Fizz: {fizzCount}");
Console.WriteLine($"FizzWhiz: {fizzwhizCount}");
Console.WriteLine($"FizzWhizBuzz: {fizzwhizbuzzCount}");
Console.WriteLine($"Bong: {bongCount}");
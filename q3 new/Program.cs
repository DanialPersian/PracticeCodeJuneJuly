using System;

class FizzWhizBuzzBong
{
    static void Main(string[] args) //here is the main method 
    {
        // Define the range
        int start = 1;
        int end = 12;

        // Initialize counters
        int fizzwhizbuzzCount = 0;
        int bongCount = 0;
        int fizzCount = 0;
        int fizzwhizCount = 0;

        // Play the game for each number in the range
        for (int i = start; i <= end; i++)
        {
            GetFizzWhizBuzzBong(i, ref fizzwhizbuzzCount, ref bongCount, ref fizzCount, ref fizzwhizCount);
        }

        // Print the results
        
        Console.WriteLine($"Fizz: {fizzCount}");
        Console.WriteLine($"FizzWhiz: {fizzwhizCount}");
        Console.WriteLine($"FizzWhizBuzz: {fizzwhizbuzzCount}");
        Console.WriteLine($"Bong: {bongCount}");
    }

    static void GetFizzWhizBuzzBong(int x, ref int fizzwhizbuzz, ref int bong, ref int fizz, ref int fizzwhiz)
    {
        if (x % 8 == 0)
        {
            fizzwhizbuzz++;
        }
        else if (x % 4 == 0)
        {
            fizzwhiz++;
        }
        else if (x % 2 == 0)
        {
            fizz++;
        }
        else
        {
            bong++;
        }
    }
}

//If the largest number amongst {2,4,8} which can divide x is "2,"  then we count it as an instance of "Fizz."
//meaning that out of 2,4,8 the number that can divide it is 2 then its fizz - doesn't mean if all of them can divide it , meaning if just 2 can divide it out of all of them 
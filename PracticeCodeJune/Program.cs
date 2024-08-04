using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string question = "ab1cd23ef4gh";

        // Define the consonants
        HashSet<char> consonants = new HashSet<char>
        {
            'b', 'c', 'd','f','g', 'h','j', 'k', 'l','m','n','p','q','r','s','t','v','w','x','y','z'
        };

        int sumNumbers = 0;
        int consonantCount = 0;

        foreach (char c in question)
        {
            // Check if the character is a digit
            if (char.IsDigit(c))
            {
                sumNumbers += c - '0';
            }
            // Check if the character is a consonant
            else if (consonants.Contains(char.ToLower(c)))
            {
                consonantCount++;
            }
        }

        int result = sumNumbers * consonantCount;
        Console.WriteLine(result);
    }
}

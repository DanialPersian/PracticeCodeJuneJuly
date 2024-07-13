using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"dogOwners2.txt");
        int amount = 0;

        foreach (string line in lines)
        {
            string[] values = line.Split(new char[] { ':', '[', ',', ']' }, StringSplitOptions.RemoveEmptyEntries);
            int redCollarCount = 0;

            
            for (int i = 2; i < values.Length; i += 2)
            {
                string collarColor = values[i].Trim(); 

                if (collarColor == "Red")
                {
                    redCollarCount++;
                }
            }

            if (redCollarCount >= 2)
            {
                Console.WriteLine(line);
                amount++;
            }
        }

        Console.WriteLine(amount);
    }
}s
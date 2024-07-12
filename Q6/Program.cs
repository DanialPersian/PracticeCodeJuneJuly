//get the lines out of the files 

string[] lines = File.ReadAllLines(@"dogOwners.txt");

//Dangelo Broomfield:[BRUISER:Blue,OTIS:Orange,KLARK:Black,NEVE:White,HENRY:Orange]
//     1                2     3    4     5     6      7    8    9      10   11

int amount = 0;

foreach (string line in lines)
{
    string[] values = line.Split(new char[] { ':', '[', ',', ']' }, StringSplitOptions.RemoveEmptyEntries);

    // Initialize the red collar count
    int redCollarCount = 0;

    // Start from index 2 and step by 2 to get all the collar colors
    for (int i = 2; i < values.Length; i += 2)
    {
        if (values[i] == "Red")
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

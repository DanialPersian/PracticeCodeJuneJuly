int[,] positions = { { 1, 2, 3, 4}, { 10, 11, 12, 5}, { 9, 8, 7, 6} };

int[,] values = new int[3, 3]; // meaning 3 rows and 4 columns
Random rng = new Random(123);
for (int i = 0; i < 50; i++)
{
    values[rng.Next(0,3 ), rng.Next(0, 3)] = rng.Next(1, 1000);
}//all of the above is included with the question 

for (int rowIndex = 0; rowIndex < positions.GetLength(0); rowIndex++)
{
    for (int columnIndex = 0; columnIndex < positions.GetLength(1); columnIndex++)
    {
        Console.Write(values[rowIndex, columnIndex] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int rowIndex = 0; rowIndex < values.GetLength(0); rowIndex++)
{
    for(int columnIndex = 0; columnIndex < values.GetLength(1); columnIndex++)
    {
           Console.Write(values[rowIndex, columnIndex] + " ");
    }
    Console.WriteLine();
}
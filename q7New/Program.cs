int[,] grid = { { 1, 6, 4, 9, 4 }, { 4, 3, 8, 5, 6 }, { 2, 5, 5, 4, 7 }, { 3, 4, 8, 5, 1 } };
List<int> numbers = new List<int>();



for (int rowIndex = 0; rowIndex < grid.GetLength(0); rowIndex++)
{
    for (int columnIndex = 0; columnIndex < grid.GetLength(1); columnIndex++)
    {
        
        numbers.Add(grid[rowIndex, columnIndex]);
    }
    int largestNumber = FindLargestNumberWithFourLargerNeighbours(grid);
    Console.WriteLine("The largest number with four larger neighbors is: " + largestNumber);
}

static int FindLargestNumberWithFourLargerNeighbours(int[,] grid)
{
    int maxNumber = int.MinValue;
    int DanialRows = grid.GetLength(0);
    int DanialColumns = grid.GetLength(1);

    //iterating through the grid , skipping edges

    for(int i = 1; i < DanialRows - 1; i++)
    {
        for (int k = 1; k < DanialColumns -1; k ++)
        {
            int DanialCurrentNumber = grid[i, k];
            //checking if all four numbers are larger
            if(grid[i - 1, k] > DanialCurrentNumber && grid[i + 1, k] > DanialCurrentNumber && grid[i, k - 1] > DanialCurrentNumber && grid[i, k + 1] > DanialCurrentNumber)
            {
                if(DanialCurrentNumber > maxNumber)
                {
                    maxNumber = DanialCurrentNumber;
                }
            }
            
        }
    }
    return maxNumber;
}
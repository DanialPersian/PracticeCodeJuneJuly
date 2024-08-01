int[,] grid = { { 1, 6, 4 }, { 4, 3, 8 }, { 2, 5, 5 } };
List<int> numbers = new List<int>();



for (int rowIndex = 0; rowIndex < grid.GetLength(0); rowIndex++)
{
    for (int columnIndex = 0; columnIndex < grid.GetLength(1); columnIndex++)
    {
        
        numbers.Add(grid[rowIndex, columnIndex]);
    }
}

static int FindLargestNumberWithFourLargerNeighbours(int[,] grid)
{
    int maxNumber = int.MinValue;
    int DanialRows = grid.GetLength(0);
    int DanialColumns = grid.GetLength(1);

    //iterating through the grid , skipping edges

    for(int i = 1; i < DanialRows - 1; i++)
    {

    }
}
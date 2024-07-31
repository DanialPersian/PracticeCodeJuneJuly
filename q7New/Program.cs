int[,] grid = { { 1, 6, 4 }, { 4, 3, 8 }, { 2, 5, 5 } };

int[,] values = new int[3, 3]; // meaning 3 rows and 3 columns

for(int rowIndex = 0; rowIndex < grid.GetLength(0); rowIndex++)
{
    for (int columnIndex = 0; columnIndex < grid.GetLength(1); columnIndex++)
    {
        List<int> numbers = new List<int>();
        numbers.Add(grid[rowIndex, columnIndex]);
    }
}
int[] sizes = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = sizes[0];
int cols = sizes[1];

string[,] matrix =  new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] rowArray = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowArray[col];
    }
}

int squaresCounter = 0;
for (int row = 0; row < rows - 1; ++row)
{
    for (int col = 0; col < cols - 1; col++)
    {
        if (matrix[row,col] == matrix[row, col+1] && matrix[row,col] == matrix[row + 1, col] && matrix[row,col] == matrix[row+1, col + 1])
        {
            squaresCounter++;
        }
    }
}

Console.WriteLine(squaresCounter);
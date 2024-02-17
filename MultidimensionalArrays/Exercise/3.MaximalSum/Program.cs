int[] sizes = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = sizes[0];
int cols = sizes[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] rowArray = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row,col] = rowArray[col];
    }
}

int maxSum = int.MinValue;
int maxSumRow = 0;
int maxSumCol = 0;

for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0;col < cols - 2; col++)
    {
        int currentSum = 0;
        for (int i = 0; i <= 2; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                currentSum += matrix[row + i,col + j];
            }
        }

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            maxSumRow = row;
            maxSumCol = col;
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");

for (int row = maxSumRow; row < maxSumRow + 3; row++)
{
    for ( int col = maxSumCol; col < maxSumCol + 3; col++)
    {
        Console.Write(matrix[row,col] + " ");
    }
    Console.WriteLine();
}


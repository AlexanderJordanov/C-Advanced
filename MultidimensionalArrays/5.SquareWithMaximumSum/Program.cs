int[] matrixArgs = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = matrixArgs[0];
int cols = matrixArgs[1];

int[,] matrix = ReadMatrix (rows, cols, ", ");
int maxSum = 0;
int maxSumRow = 0;
int maxSumCol = 0;

for (int row  = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        int sum = 0;

        if (row + 1 >= matrix.GetLength(0) || col + 1 >= matrix.GetLength(1))
        {
            continue;
        }
        else
        {
            sum += matrix[row, col];
            sum += matrix[row + 1, col];
            sum += matrix[row, col + 1];
            sum += matrix[row + 1, col + 1];
        }

        if (sum > maxSum)
        {
            maxSum = sum;
            maxSumRow = row;
            maxSumCol = col;
        }
    }
}

Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol + 1]}");
Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol]} {matrix[maxSumRow + 1, maxSumCol + 1]}");
Console.WriteLine(maxSum);



int[,] ReadMatrix(int rows, int cols, string separator)
{
    int[,] matrix = new int[rows, cols];   

    for (int row = 0; row < rows; row++)
    {
        int[] rowArray = Console.ReadLine()
            .Split(separator) 
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowArray[col];
        }
    }

    return matrix;
}
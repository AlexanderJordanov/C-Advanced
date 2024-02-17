int[] matrixArgs = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = matrixArgs[0];
int cols = matrixArgs[1];

int[,] matrix = ReadMatrix(rows, cols, ", ");
int nBox = int.Parse(Console.ReadLine());
int maxSum = 0;
int maxSumRow = 0;
int maxSumCol = 0;

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        for (int rowN = 0; rowN < nBox; rowN++)
        {
            for (int colN = 0; colN < nBox; colN++)
            {
                int sum = 0;

                if (row + nBox - 1 >= matrix.GetLength(0) || col + nBox - 1 >= matrix.GetLength(1))
                {
                    continue;
                }
                else
                {
                    sum += matrix[row, col];
                    sum += matrix[row + rowN, col];
                    sum += matrix[row, col + colN];
                    sum += matrix[row + rowN, col + colN];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxSumRow = row;
                    maxSumCol = col;
                }
            }
        }
       
    }
}
for (int n = maxSumRow; n < maxSumRow + nBox; n++)
{
    for (int j = maxSumCol; j < maxSumCol + nBox; j++)
    {
        Console.Write(matrix[n, j] + " ");
    }
    Console.WriteLine();
}

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
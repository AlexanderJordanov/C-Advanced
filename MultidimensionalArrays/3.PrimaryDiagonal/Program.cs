int n = int.Parse(Console.ReadLine());

int[,] matrix = ReadMatrix(n, n, " ");

int sum = 0;

for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        if (row == col)
        {
            sum += matrix[row,col];
        }
    }
}

Console.WriteLine(sum);



static int[,] ReadMatrix(int rows, int cols, string separator)
{
    int[,] matrix = new int[rows, cols];
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int[] rowArray = Console.ReadLine()
            .Split(separator)
            .Select(int.Parse)
            .ToArray();
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = rowArray[col];
        }
    }
    return matrix;
}
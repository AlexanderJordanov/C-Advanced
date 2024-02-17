int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

int primeSum = 0;
int secondarySum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowArray = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = rowArray[col];
        if (row == col)
        {
            primeSum += matrix[row, col];
        } 
    }
}

for (int row = 0; row < size; row++)
{
    secondarySum += matrix[row, size - 1 - row];
}
Console.WriteLine(Math.Abs(primeSum - secondarySum));

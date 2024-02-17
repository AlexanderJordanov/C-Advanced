int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
char [] snake = Console.ReadLine().ToCharArray();

int rows = dimensions[0] ;
int cols = dimensions[1] ;
char[,]matrix = new char[rows, cols];
Queue<char> snakeQueue = new Queue<char>();

for (int i = 0; i < snake.Length ; i++)
{
    snakeQueue.Enqueue(snake[i]);
}

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            char symbols = snakeQueue.Dequeue();
            snakeQueue.Enqueue(symbols);
            matrix[row, col] = symbols;
        }
    }
    else
    {
        for (int col = dimensions[1] - 1; col >= 0; col--)
        {
            char symbols = snakeQueue.Dequeue();
            snakeQueue.Enqueue(symbols);
            matrix[row, col] = symbols;
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}
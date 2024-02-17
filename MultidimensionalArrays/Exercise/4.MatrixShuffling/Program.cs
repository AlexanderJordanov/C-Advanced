int[] sizes = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = sizes[0];
int cols = sizes[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] rowArray = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowArray[col];
    }
}

string input = string.Empty;

while ((input = Console.ReadLine()) != "END")
{
    string[] commandArgs = input.Split();

    string command = commandArgs[0];

    if (command == "swap" && commandArgs.Length == 5)
    {
        int row1 = int.Parse(commandArgs[1]);
        int col1 = int.Parse(commandArgs[2]);
        int row2 = int.Parse(commandArgs[3]);
        int col2 = int.Parse(commandArgs[4]);

        if (row1 >= 0 && row1 < matrix.GetLength(0) 
            && col1 >= 0 && col1 < matrix.GetLength(1)
            && row2 >= 0 && row2 < matrix.GetLength(0)
            && col2 >= 0 && col2 < matrix.GetLength(1))
        {
            string temp = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = temp;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        } 

        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}
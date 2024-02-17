int rows = int.Parse(Console.ReadLine());
int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] rowArray = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    jaggedArray[row] = rowArray;
}

for (int row = 0; row < rows - 1; row++)
{
    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] *= 2;
            jaggedArray[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] /= 2;
        }
        for (int col = 0; col < jaggedArray[row + 1].Length; col++)
        {
            jaggedArray[row + 1][col] /= 2;
        }
    }
}
string command = string.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    command = commandArgs[0];
    int commandRow = int.Parse(commandArgs[1]);
    int commandCol = int.Parse(commandArgs[2]);
    int commandValue = int.Parse(commandArgs[3]);

    if (command == "Add")
    {
        if (commandRow <= rows && commandRow >= 0 && commandCol <= jaggedArray[commandRow].Length && commandCol >= 0)
        {
            jaggedArray[commandRow][commandCol] += commandValue;
        }
    }
    else if (command == "Subtract")
    {
        if (commandRow < rows && commandRow >= 0 && commandCol < jaggedArray[commandRow].Length && commandCol >= 0)
        {
            jaggedArray[commandRow][commandCol] -= commandValue;
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write(jaggedArray[row][col] + " ");
    }
    Console.WriteLine();
}
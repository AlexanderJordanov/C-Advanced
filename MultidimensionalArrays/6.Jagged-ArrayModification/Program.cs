int rows = int.Parse(Console.ReadLine());

int[][] array = new int[rows][];

for (int row = 0; row < rows; row++)
{
    array[row] = Console.ReadLine()
        .Split()
        .Select(int.Parse) 
        .ToArray();
}

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    string[] commandArgs = command.Split();
    int row = int.Parse(commandArgs[1]);
    int col = int.Parse(commandArgs[2]);
    int value = int.Parse(commandArgs[3]);

    if (row < 0 || row >= array.Length || array[row].Length <= col || col < 0)
    {
        Console.WriteLine("Invalid coordinates");
        continue;
    }
    if (commandArgs[0] == "Add")
    {
            array[row][col] += value;      
    }
    else
    {
            array[row][col] -= value;             
    }
}

for (int row = 0; row < array.Length; row++)
{
    for (int col = 0; col < array[row].Length; col++)
    {
        Console.Write(array[row][col] +" ");
    }
    Console.WriteLine();
}
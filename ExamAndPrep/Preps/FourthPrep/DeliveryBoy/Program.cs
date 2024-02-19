int[] dimensions = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
char[,] field = new char[dimensions[0], dimensions[1]];
int boyRow = 0;
int boyCol = 0;
int startingRow = 0;
int startingCol = 0;
int houses = 0;
for (int row = 0; row < dimensions[0]; row++)
{
    string matrixRow = Console.ReadLine();
    for (int col = 0; col < dimensions[1]; col++)
    {
        field[row, col] = matrixRow[col];
        if (field[row, col] == 'B')
        {
            boyRow = row;
            boyCol = col;
            startingRow = row;
            startingCol = col;
        }
        else if (field[row, col] == 'A')
        {
            houses++;
        }
    }
}
while (true)
{
    string command = Console.ReadLine();
    if (field[boyRow, boyCol] != 'R')
    {
        field[boyRow, boyCol] = '.';
    }
    if (command == "up")
    {        
        boyRow--;
        if (boyRow < 0)
        {
            field[startingRow, startingCol] = ' ';
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
        if (field[boyRow, boyCol] == '*')
        {
            boyRow++;
            continue;
        }
    }
    else if (command == "down")
    {
        boyRow++;
        if (boyRow > dimensions[0] - 1)
        {
            field[startingRow, startingCol] = ' ';
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
        if (field[boyRow, boyCol] == '*')
        {
            boyRow--;
            continue;
        }
    }
    else if (command == "left")
    {
        boyCol--;
        if (boyCol < 0)
        {
            field[startingRow, startingCol] = ' ';
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
        if (field[boyRow, boyCol] == '*')
        {
            boyCol++;
            continue;
        }
    }
    else if (command == "right")
    {
        boyCol++;
        if (boyCol > dimensions[1] - 1)
        {
            field[startingRow, startingCol] = ' ';
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
        if (field[boyRow, boyCol] == '*')
        {
            boyCol--;
            continue;
        }
    }
    if (field[boyRow, boyCol] != '-')
    {
        if (field[boyRow, boyCol] == 'P')
        {
            field[boyRow, boyCol] = 'R';
            Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        }
        else if (field[boyRow, boyCol] == 'A')
        {
            houses--;
            field[boyRow, boyCol] = 'P';
            Console.WriteLine("Pizza is delivered on time! Next order...");
        }
    }
    else
    {
        field[boyRow, boyCol] = 'B';
    }
    if (houses == 0)
    {
        field[startingRow, startingCol] = 'B';
        break;
    }
}
for (int i = 0; i < dimensions[0]; i++)
{
    for (int j = 0; j < dimensions[1]; j++)
    {
        Console.Write(field[i, j]);
    }
    Console.WriteLine();
}
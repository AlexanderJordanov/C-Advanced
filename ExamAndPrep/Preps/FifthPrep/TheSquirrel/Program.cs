int sizes = int.Parse(Console.ReadLine());
char[,] field = new char[sizes, sizes];
string[] direction = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
int squirrelRow = 0;
int squirrelCol = 0;

for (int row = 0; row < sizes; row++)
{
    string fieldRow = Console.ReadLine();
    for (int col = 0; col < sizes; col++)
    {
        if (fieldRow[col] == 's')
        {
            squirrelRow = row;
            squirrelCol = col;
        }
        field[row, col] = fieldRow[col];
    }
}
int collectedHazelnuts = 0;
for (int i = 0; i < direction.Length; i++)
{
    field[squirrelRow, squirrelCol] = '*';
    string command = direction[i];
    if (command == "up")
    {
        squirrelRow--;
        if (squirrelRow < 0)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {collectedHazelnuts}");
            return;
        }
    }
    else if (command == "down")
    {
        squirrelRow++;
        if (squirrelRow > sizes - 1)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {collectedHazelnuts}");
            return;
        }
    }
    else if (command == "left")
    {
        squirrelCol--;
        if (squirrelCol < 0)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {collectedHazelnuts}");
            return;
        }
    }
    else if (command == "right")
    {
        squirrelCol++;
        if (squirrelCol > sizes - 1)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {collectedHazelnuts}");
            return;
        }
    }

    if (field[squirrelRow, squirrelCol] != '*')
    {
        if (field[squirrelRow, squirrelCol] == 'h')
        {
            collectedHazelnuts++;
            if (collectedHazelnuts == 3)
            {
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                Console.WriteLine($"Hazelnuts collected: {collectedHazelnuts}");
                return;
            }
        }
        else
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {collectedHazelnuts}");
            return;
        }
    }
    field[squirrelRow, squirrelCol] = 's';
}
if (collectedHazelnuts < 3)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}
Console.WriteLine($"Hazelnuts collected: {collectedHazelnuts}");
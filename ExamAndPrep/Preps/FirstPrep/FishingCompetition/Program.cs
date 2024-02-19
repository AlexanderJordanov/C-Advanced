int size = int.Parse(Console.ReadLine());
char [,] matrix = new char[size,size];
for (int row = 0; row < size; row++)
{
    string matrixRow = Console.ReadLine();
    for (int col = 0; col < size; col++)
    {
        matrix[row,col] = matrixRow[col];
    }
}
int currentRow = 0;
int currentCol = 0;
for (int row = 0;row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row,col] == 'S')
        {
            currentRow = row;
            currentCol = col;
        }
    }
}
int collectedFishes = 0;
string command;
while ((command = Console.ReadLine()) != "collect the nets")
{
    matrix[currentRow, currentCol] = '-';
    if (command == "up")
    {
        currentRow--;
        if (currentRow < 0) 
        {
            currentRow = size - 1;
        }
    }
    else if (command == "down")
    {
        currentRow++;
        if (currentRow > size-1)
        {
            currentRow = 0;
        }
    }
    else if (command == "left")
    {
        currentCol--;
        if (currentCol < 0)
        {
            currentCol = size-1;
        }
    }
    else if (command == "right")
    {
        currentCol++;
        if (currentCol > size-1)
        {
            currentCol = 0;
        }
    }

    if (matrix[currentRow,currentCol] != '-')
    {
        if (matrix[currentRow, currentCol] == 'W')
        {
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currentRow},{currentCol}]");
            return;
        }
        else
        {
            collectedFishes += int.Parse(matrix[currentRow, currentCol].ToString());
        }
    }
    matrix[currentRow, currentCol] = 'S';
}
if (collectedFishes >= 20)
{
    Console.WriteLine($"Success! You managed to reach the quota!");
}
else
{
    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20-collectedFishes} tons of fish more.");
}
if (collectedFishes > 0)
{
    Console.WriteLine($"Amount of fish caught: {collectedFishes} tons.");
}
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}
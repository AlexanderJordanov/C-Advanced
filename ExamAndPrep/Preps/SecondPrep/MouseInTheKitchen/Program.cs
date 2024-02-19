int[] sizes = Console.ReadLine()
    .Split(',', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
char[,] kitchenMatrix = new char[sizes[0], sizes[1]];
for (int row = 0; row < sizes[0]; row++)
{
    string matrixRow = Console.ReadLine();
    for (int col = 0; col < sizes[1]; col++)
    {
        kitchenMatrix[row, col] = matrixRow[col];
    }
}
int currentRow = 0;
int currentCol = 0;
int cheeseCount = 0;
for (int row = 0; row < sizes[0]; row++)
{
    for (int col = 0; col < sizes[1]; col++)
    {
        if (kitchenMatrix[row,col] == 'M')
        {
            currentRow = row;
            currentCol = col;
        }
        else if (kitchenMatrix[row, col] == 'C')
        {
            cheeseCount++;
        }
    }
}
string command;
while ((command = Console.ReadLine()) != "danger")
{
    if (command == "up")
    {
        kitchenMatrix[currentRow, currentCol] = '*';
        currentRow--;
        if(currentRow < 0)
        {
            currentRow++;
            kitchenMatrix[currentRow, currentCol] = 'M';
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }
    else if (command == "down")
    {
        kitchenMatrix[currentRow, currentCol] = '*';
        currentRow++;
        if(currentRow > sizes[0] - 1) 
        {
            currentRow--;
            kitchenMatrix[currentRow, currentCol] = 'M';
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }
    else if (command == "left")
    {
        kitchenMatrix[currentRow, currentCol] = '*';
        currentCol--;
        if (currentCol < 0)
        {
            currentCol++;
            kitchenMatrix[currentRow, currentCol] = 'M';
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }
    else if (command == "right")
    {
        kitchenMatrix[currentRow, currentCol] = '*';
        currentCol++;
        if (currentCol > sizes[1] - 1)
        {
            currentCol--;
            kitchenMatrix[currentRow, currentCol] = 'M';
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }

    if (kitchenMatrix[currentRow,currentCol] != '*')
    {
        if (kitchenMatrix[currentRow, currentCol] == 'C')
        {
            cheeseCount--;
            kitchenMatrix[currentRow, currentCol] = 'M';
            if (cheeseCount == 0)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                break;
            }
        }
        else if (kitchenMatrix[currentRow, currentCol] == 'T')
        {
            kitchenMatrix[currentRow, currentCol] = 'M';
            Console.WriteLine("Mouse is trapped!");
            break;
        }
        else if (kitchenMatrix[currentRow, currentCol] == '@')
        {
            if (command == "up")
            {
                currentRow++;
                kitchenMatrix[currentRow, currentCol] = 'M';
            }
            else if (command == "down")
            {
                currentRow--;
                kitchenMatrix[currentRow, currentCol] = 'M';
            }
            else if (command == "left")
            {
                currentCol++;
                kitchenMatrix[currentRow, currentCol] = 'M';
            }
            else if (command == "right")
            {
                currentCol--;
                kitchenMatrix[currentRow, currentCol] = 'M';
            }
        }
    }
    else
    {
        kitchenMatrix[currentRow, currentCol] = 'M';
    }

}
if (command == "danger" && cheeseCount > 0)
{
    Console.WriteLine("Mouse will come back later!");
}
for (int row = 0; row < sizes[0]; row++)
{
    for (int col = 0; col < sizes[1]; col++)
    {
        Console.Write(kitchenMatrix[row, col]);
    }
    Console.WriteLine();
}
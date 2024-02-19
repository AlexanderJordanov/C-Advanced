/*
5 8
- - - O - P - O
- P - O O - - -
- - - - - - O -
- P B - O - - O
- - - O - - - -
up
up
left
Finish


4 4
O B O -
- P O P
- - P -
- - - - 
left
right
down
right
down
right
up
right
up
down
Finish
 */

int[] sizes = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
char[,] playground = new char[sizes[0], sizes[1]];
int blindManRow = 0;
int blindManCol = 0;

for (int row = 0; row < sizes[0]; row++)
{
    char[] playgroundRow = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();
    for (int col = 0; col < sizes[1]; col++)
    {
        if (playgroundRow[col] == 'B')
        {
            blindManRow = row;
            blindManCol = col;
        }
        playground[row, col] = playgroundRow[col];
    }
}
int touchedOponents = 0;
int movesMade = 0;
string command;
while ((command = Console.ReadLine()) != "Finish")
{
    if (command == "up" && blindManRow - 1 < 0 || command == "down" && blindManRow + 1 > sizes[0] - 1 || command == "left" && blindManCol - 1 < 0 || command == "right" && blindManCol + 1 > sizes[1] - 1)
    {
        continue;
    }


    playground[blindManRow, blindManCol] = '-';
    if (command == "up")
    {
        blindManRow--;
    }
    else if (command == "down")
    {
        blindManRow++;
    }
    else if (command == "left")
    {
        blindManCol--;
    }
    else if (command == "right")
    {
        blindManCol++;
    }
    if (playground[blindManRow,blindManCol] == 'O')
    {
        if (command == "up")
        {
            blindManRow++;
        }
        else if (command == "down")
        {
            blindManRow--;
        }
        else if (command == "left")
        {
            blindManCol++;
        }
        else if (command == "right")
        {
            blindManCol--;
        }
        playground[blindManRow, blindManCol] = 'B';
        continue;
    }
    else if (playground[blindManRow, blindManCol] == '-')
    {
        movesMade++;
        playground[blindManRow, blindManCol] = 'B';
    }
    else if (playground[blindManRow, blindManCol] == 'P')
    {
        movesMade++;
        touchedOponents++;
        playground[blindManRow, blindManCol] = 'B';
    }
    if (touchedOponents == 3)
    {
        break;
    }
}
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {touchedOponents} Moves made: {movesMade}");
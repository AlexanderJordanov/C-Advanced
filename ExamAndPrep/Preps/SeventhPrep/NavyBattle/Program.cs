int size = int.Parse(Console.ReadLine());
char[,] battlefield = new char[size, size];
int submarineRow = 0;
int submarineCol = 0;
for (int i = 0; i < size; i++)
{
    string currentRow = Console.ReadLine();
    for (int j = 0; j < size; j++)
    {
        if (currentRow[j] == 'S')
        {
            submarineRow = i;
            submarineCol = j;
        }
        battlefield[i, j] = currentRow[j];
    }
}
int minesHit = 0;
int cruisersDestroyed = 0;
string command;
while (true)
{
    command = Console.ReadLine();
    battlefield[submarineRow, submarineCol] = '-';
    if (command == "up")
    {
        submarineRow--;
    }
    else if (command == "down")
    {
        submarineRow++;
    }
    else if (command == "left")
    {
        submarineCol--;
    }
    else if (command == "right") 
    {
        submarineCol++;
    }

    if (battlefield[submarineRow,submarineCol] != '-')
    {
        if (battlefield[submarineRow, submarineCol] == '*')
        {
            minesHit++;
            battlefield[submarineRow, submarineCol] = 'S';
            if (minesHit > 2)
            {
                Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
                break;
            }
        }
        else if (battlefield[submarineRow, submarineCol] == 'C')
        {
            cruisersDestroyed++;
            battlefield[submarineRow, submarineCol] = 'S';
            if (cruisersDestroyed > 2)
            {
                Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                break;
            }
        }
        else
        {
            battlefield[submarineRow, submarineCol] = 'S';
        }
    }
}
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write(battlefield[i,j]);
    }
    Console.WriteLine();
}
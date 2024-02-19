int n = int.Parse(Console.ReadLine());
char[,] airspace = new char[n, n];
int jetFighterArmor = 300;
int jefFighterRow = -1;
int jefFighterCol = -1;
int enemyCraft = 0;
for (int row = 0; row < n; row++)
{
    string matrixRow = Console.ReadLine();
    for (int col = 0; col < n; col++)
    {
        airspace[row, col] = matrixRow[col];
        if (airspace[row, col] == 'J')
        {
            jefFighterRow = row;
            jefFighterCol = col;
        }
        else if (airspace[row, col] == 'E')
        {
            enemyCraft++;
        }
    }
}
string command;
while (true)
{
    command = Console.ReadLine();
    airspace[jefFighterRow, jefFighterCol] = '-';
    if (command == "up")
    {
        jefFighterRow--;
    }
    else if (command == "down")
    {
        jefFighterRow++;
    }
    else if (command == "left")
    {
        jefFighterCol--;
    }
    else if (command == "right")
    {
        jefFighterCol++;
    }
    

    if (airspace[jefFighterRow, jefFighterCol] != '-')
    {
        if (airspace[jefFighterRow, jefFighterCol] == 'E')
        {
            airspace[jefFighterRow, jefFighterCol] = 'J';
            enemyCraft--;
            if (enemyCraft == 0)
            {
                Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                break;
            }
            else if (enemyCraft > 0)
            {
                jetFighterArmor -= 100;
                if (jetFighterArmor <= 0)
                {
                    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jefFighterRow}, {jefFighterCol}]!");
                    break;
                }
            }
        }
        else if (airspace[jefFighterRow, jefFighterCol] == 'R')
        {
            airspace[jefFighterRow, jefFighterCol] = 'J';
            jetFighterArmor = 300;
        }
    }
    else
    {
        airspace[jefFighterRow, jefFighterCol] = 'J';
    }
}
for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        Console.Write(airspace[row, col]);
    }
    Console.WriteLine();
}


int n = int.Parse(Console.ReadLine());
char[,] gameBoard = new char[n,n];
int money = 100;
int gamblerRow = 0;
int gamblerCol = 0;
int jackpotCount = 1;
for (int i = 0; i < n; i++)
{
    string matrixRow = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        gameBoard[i, j] = matrixRow[j];
        if (gameBoard[i, j] == 'G')
        {
            gamblerRow = i;
            gamblerCol = j;
        }
    }
}
string command;
while ((command = Console.ReadLine()) != "end")
{
    if ((command == "up" && gamblerRow - 1 < 0) ||
        (command == "down" && gamblerRow + 1 > n - 1) ||
        (command == "left" && gamblerCol - 1 < 0) || 
        (command == "right" && gamblerCol + 1 > n - 1))
    {
        Console.WriteLine("Game over! You lost everything!");
        return;
    }
    gameBoard[gamblerRow, gamblerCol] = '-';
    if (command == "up")
    {
        gamblerRow--;
    }
    else if (command == "down")
    {
        gamblerRow++;
    }
    else if (command == "left")
    {
        gamblerCol--;
    }
    else if (command == "right")
    {
        gamblerCol++;
    }

    if (gameBoard[gamblerRow, gamblerCol] != '-')
    {
        if (gameBoard[gamblerRow, gamblerCol] == 'W')
        {
            gameBoard[gamblerRow, gamblerCol] = 'G';
            money += 100;
        }
        else if (gameBoard[gamblerRow, gamblerCol] == 'P')
        {
            gameBoard[gamblerRow, gamblerCol] = 'G';
            money -= 200;
            if (money <= 0)
            {
                Console.WriteLine("Game over! You lost everything!");
                return;
            }
        }
        else if (gameBoard[gamblerRow, gamblerCol] == 'J')
        {
            gameBoard[gamblerRow, gamblerCol] = 'G';
            jackpotCount--;
            money += 100000;
            Console.WriteLine("You win the Jackpot!");
            Console.WriteLine($"End of the game. Total amount: {money}$");
            break;
        }
    }
    else
    {
        gameBoard[gamblerRow, gamblerCol] = 'G';
    }
}
if (jackpotCount > 0)
{
    Console.WriteLine($"End of the game. Total amount: {money}$");
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(gameBoard[i, j]);
    }
    Console.WriteLine();
}
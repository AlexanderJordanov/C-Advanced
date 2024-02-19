using System;
namespace HelpAMole
{
    public class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            int moleRow = 0;
            int moleCol = 0;
            int firstTeleportRow = -1;
            int firstTeleportCol = -1;
            int secondTeleportRow = -1;
            int secondTeleportCol = -1;
            for (int row = 0; row < size; row++)
            {
                string fieldRow = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = fieldRow[col];
                    if (fieldRow[col] == 'M')
                    {
                        moleRow = row;
                        moleCol = col;
                    }
                    if (fieldRow[col] == 'S')
                    {
                        if (firstTeleportRow < 0 && firstTeleportRow < 0)
                        {
                            firstTeleportRow = row;
                            firstTeleportCol = col;
                        }
                        else
                        {
                            secondTeleportRow = row;
                            secondTeleportCol = col;
                        }
                    }
                }
            }
            int pointsCollected = 0;
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if ((command == "up" && moleRow - 1 < 0) || (command == "down" && moleRow + 1 > size - 1) || (command == "left" && moleCol - 1 < 0) || (command == "right" && moleCol + 1 > size - 1))
                {
                    Console.WriteLine("Don't try to escape the playing field!");
                    continue;
                }
                field[moleRow, moleCol] = '-';
                if (command == "up")
                {
                    moleRow--;
                }
                else if (command == "down")
                {
                    moleRow++;
                }
                else if (command == "left")
                {
                    moleCol--;
                }
                else if (command == "right")
                {
                    moleCol++;
                }

                if (field[moleRow, moleCol] != '-')
                {
                    if (field[moleRow, moleCol] == 'S')
                    {
                        if (moleRow == firstTeleportRow && moleCol == firstTeleportCol)
                        {
                            field[moleRow, moleCol] = '-';
                            moleRow = secondTeleportRow;
                            moleCol = secondTeleportCol;
                        }
                        else
                        {
                            field[moleRow, moleCol] = '-';
                            moleRow = firstTeleportRow;
                            moleCol = firstTeleportCol;
                        }
                        field[moleRow, moleCol] = 'M';
                        pointsCollected -= 3;
                    }
                    if (char.IsDigit(field[moleRow, moleCol]))
                    {
                        pointsCollected += Convert.ToInt32(field[moleRow, moleCol] - '0');
                        field[moleRow, moleCol] = 'M';
                    }
                }
                else
                {
                    field[moleRow, moleCol] = 'M';
                }
                if (pointsCollected >= 25)
                {
                    Console.WriteLine("Yay! The Mole survived another game!");
                    Console.WriteLine($"The Mole managed to survive with a total of {pointsCollected} points.");
                    break;
                }
            }
            if (pointsCollected < 25)
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {pointsCollected} points.");
            }
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
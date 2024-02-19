Queue<int> monsters = new Queue<int>(Console.ReadLine()
    .Split(',', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Stack<int> soldiers = new Stack<int>(Console.ReadLine()
    .Split(',', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
int killedMonsters = 0;
while (soldiers.Count > 0 && monsters.Count > 0)
{
    int monster = monsters.Peek();
    int soldier = soldiers.Peek();
    if (monster <= soldier)
    {
        killedMonsters++;
        soldier -= monster;
        monsters.Dequeue();
        if (soldier > 0)
        {
            
            if (soldiers.Count == 1)
            {
                soldiers.Pop();
                soldiers.Push(soldier);
                continue;
            }
            else
            {
                soldiers.Pop();
                soldiers.Push(soldiers.Pop() + soldier);
            }
        }
        else
        {
            soldiers.Pop();
        }
    }
    else
    {
        soldiers.Pop();
        monsters.Dequeue();
        monster -= soldier;
        monsters.Enqueue(monster);
    }

}

if (monsters.Count == 0)
{
    Console.WriteLine("All monsters have been killed!");
}
if (soldiers.Count == 0)
{
    Console.WriteLine("The soldier has been defeated.");
}
Console.WriteLine($"Total monsters killed: {killedMonsters}");
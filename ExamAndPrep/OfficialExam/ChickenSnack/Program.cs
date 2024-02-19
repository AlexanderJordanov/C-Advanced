Stack<int> moneyInPocket = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Queue<int> pricesOfFoods = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
int foodsEaten = 0;
while (moneyInPocket.Count > 0 && pricesOfFoods.Count > 0)
{
    int money = moneyInPocket.Pop();
    int food = pricesOfFoods.Dequeue();
    if (food == money)
    {
        foodsEaten++;
        continue;
    }
    else if (money > food)
    {
        foodsEaten++;
        money -= food;
        if (moneyInPocket.Count >= 1)
        {
            moneyInPocket.Push(moneyInPocket.Pop() + money);
        }
        else
        {
            moneyInPocket.Push(money);
        }
    }
    else
    {
        continue;
    }
}
if (foodsEaten >= 4)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {foodsEaten} foods.");
}
else if (foodsEaten > 1 && foodsEaten < 4)
{
    Console.WriteLine($"Henry ate: {foodsEaten} foods.");
}
else if (foodsEaten == 1)
{
    Console.WriteLine($"Henry ate: {foodsEaten} food.");
}
else if (foodsEaten == 0)
{
    Console.WriteLine("Henry remained hungry. He will try next weekend again.");
}
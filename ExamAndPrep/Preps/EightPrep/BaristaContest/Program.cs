Queue<int> coffees =  new Queue<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Stack<int> milks = new Stack<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Dictionary<string,int> drinks = new Dictionary<string,int>();
while (coffees.Count > 0 && milks.Count > 0)
{
    int coffee = coffees.Dequeue();
    int milk = milks.Pop();
    int result = coffee + milk;
    if (result == 50)
    {
        if (!drinks.ContainsKey("Cortado"))
        {
            drinks.Add("Cortado", 0);
        }
        drinks["Cortado"]++;
    }
    else if (result == 75)
    {
        if (!drinks.ContainsKey("Espresso"))
        {
            drinks.Add("Espresso", 0);
        }
        drinks["Espresso"]++;
    }
    else if (result == 100)
    {
        if (!drinks.ContainsKey("Capuccino"))
        {
            drinks.Add("Capuccino", 0);
        }
        drinks["Capuccino"]++;
    }
    else if (result == 150)
    {
        if (!drinks.ContainsKey("Americano"))
        {
            drinks.Add("Americano", 0);
        }
        drinks["Americano"]++;
    }
    else if (result == 200)
    {
        if (!drinks.ContainsKey("Latte"))
        {
            drinks.Add("Latte", 0);
        }
        drinks["Latte"]++;
    }
    else
    {
        milks.Push(milk - 5);
    }
}
if (coffees.Count == 0 && milks.Count == 0)
{
    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
}
else
{
    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
}
if (coffees.Count > 0)
{
    Console.WriteLine($"Coffee left: {string.Join(", ", coffees)}");
}
else
{
    Console.WriteLine("Coffee left: none");
}
if (milks.Count > 0)
{
    Console.WriteLine($"Milk left: {string.Join(", ", milks)}");
}
else
{
    Console.WriteLine("Milk left: none");
}
foreach(var drink in drinks.OrderBy(d => d.Value).ThenByDescending(d => d.Key))
{
    Console.WriteLine($"{drink.Key}: {drink.Value}");
}
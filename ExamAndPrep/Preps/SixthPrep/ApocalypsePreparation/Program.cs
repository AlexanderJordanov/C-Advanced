Queue<int> textiles = new Queue<int> (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Dictionary<string, int> healingItems = new();
while (textiles.Count > 0 &&  medicaments.Count > 0)
{
    int textile = textiles.Dequeue();
    int medicament = medicaments.Pop();
    int result = textile + medicament;
    if (result == 30)
    {
        if (!healingItems.ContainsKey("Patch"))
        {
            healingItems.Add("Patch", 0);
        }
        healingItems["Patch"]++;
        continue;
    }
    else if (result == 40)
    {
        if (!healingItems.ContainsKey("Bandage"))
        {
            healingItems.Add("Bandage", 0);
        }
        healingItems["Bandage"]++;
        continue;
    }
    else if (result == 100)
    {
        if (!healingItems.ContainsKey("MedKit"))
        {
            healingItems.Add("MedKit", 0);
        }
        healingItems["MedKit"]++;
        continue;
    }
    else if (result > 100)
    {
        if (!healingItems.ContainsKey("MedKit"))
        {
            healingItems.Add("MedKit", 0);
        }
        healingItems["MedKit"]++;
        result -= 100;
        medicaments.Push(medicaments.Pop() + result);
    }
    else
    {
        medicament += 10;
        medicaments.Push(medicament);
    }
}
if (medicaments.Count == 0 && textiles.Count == 0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (medicaments.Count == 0)
{
    Console.WriteLine("Medicaments are empty.");
}
else if (textiles.Count == 0)
{
    Console.WriteLine("Textiles are empty.");
}
foreach (var item in healingItems.OrderByDescending(i=>i.Value).ThenBy(i => i.Key))
{
    if (item.Value > 0)
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}
if (medicaments.Count > 0)
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}
if (textiles.Count > 0)
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}
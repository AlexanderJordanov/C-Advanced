using System.Timers;

int n = int.Parse(Console.ReadLine());
HashSet<string> elements = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    string[] currentRow = Console.ReadLine().Split();
    foreach(string el in currentRow)
    {
        elements.Add(el);
    }
}
Console.WriteLine(string.Join(" ", elements.OrderBy(el => el)));
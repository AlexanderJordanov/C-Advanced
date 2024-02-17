int amountOfNames = int.Parse(Console.ReadLine());  
HashSet<string> names = new HashSet<string>();

for (int i = 0; i < amountOfNames; i++)
{
    names.Add(Console.ReadLine());
}

foreach (string name in names)
{
    Console.WriteLine(name);
}
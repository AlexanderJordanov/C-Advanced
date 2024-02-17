Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
int rows = int.Parse(Console.ReadLine());

for (int i = 0; i < rows; i++)
{
    string[] row = Console.ReadLine().Split(" -> ").ToArray();
    string color = row[0];
    string[] clothes = row[1].Split(",").ToArray();

    if (!wardrobe.ContainsKey(color))
    {
        wardrobe.Add(color, new Dictionary<string, int>());
    }

    foreach (string cloth in clothes)
    {
        if (!wardrobe[color].ContainsKey(cloth))
        {
            wardrobe[color].Add(cloth, 0);
        }
        wardrobe[color][cloth]++;
    }
}

string[] pairToFind = Console.ReadLine().Split();
string colorOfClothToFind = pairToFind[0];
string clothTofind = pairToFind[1];
foreach (var color in wardrobe)
{
    Console.WriteLine($"{color.Key} clothes:");
    foreach (var cloth in color.Value)
    {
        Console.Write($"* {cloth.Key} - {cloth.Value}");

        if (color.Key == colorOfClothToFind && cloth.Key == clothTofind)
        {
            Console.Write(" (found!)");
        }
        Console.WriteLine();
    }
}
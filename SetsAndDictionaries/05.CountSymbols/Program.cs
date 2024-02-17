char[] text = Console.ReadLine().ToArray();
Dictionary<char, int> symbols = new Dictionary<char, int>();

foreach (char c in text)
{
    if (!symbols.ContainsKey(c))
    {
        symbols.Add(c, 0);
    }
    symbols[c]++;
}

foreach (var c in symbols.OrderBy(c => c.Key))
{
    Console.WriteLine($"{c.Key}: {c.Value} time/s");
}
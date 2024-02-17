char[] brackets = Console.ReadLine().ToCharArray();

if (brackets.Length % 2 != 0)
{
    Console.WriteLine("NO");
    return;
}

Stack<char> stack = new Stack<char>();

foreach (char c in brackets)
{
    if ("{[(".Contains(c))
    {
        stack.Push(c);
    }

    else if ((c == ')' && stack.Peek() == '(') || (c == ']' && stack.Peek() == '[') || (c == '}' && stack.Peek() == '{'))
    {
        stack.Pop();
    }
}

if (stack.Any())
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}

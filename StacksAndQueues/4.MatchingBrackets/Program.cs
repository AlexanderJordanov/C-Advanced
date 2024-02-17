string expression = Console.ReadLine();
Stack<int> brackets = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
    if (expression[i] == '(')
    {
        brackets.Push(i);
    }
    if (expression[i] == ')')
    {
        int startingIndex = brackets.Pop();
        Console.WriteLine(expression.Substring(startingIndex, i - startingIndex + 1));
    }
}
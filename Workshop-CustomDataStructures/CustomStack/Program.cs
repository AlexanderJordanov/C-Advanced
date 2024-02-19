namespace CustomStack
{
    public class Program
    {
        static void Main()
        {
            CustomStack stack = new CustomStack();

            stack.Push(114);
            stack.Push(225);
            stack.Push(336);
            Console.WriteLine(stack.Count);
            Console.WriteLine();

            stack.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine(stack.Pop());

        }
    }
}




namespace CustomList
{
    public class Program
    {
        static void Main()
        {
            CustomList list = new CustomList();
            list.Add(111);
            list.Add(999);
            list.Add(2000);
            Console.WriteLine(list);
            list.Swap(0, 3);
            Console.WriteLine(list);
            list.RemoveAt(2);
            Console.WriteLine(list);
            Console.WriteLine(list[0]);
            Console.WriteLine(list.Contains(999));
            Console.WriteLine(list.Contains(191842));
            Console.WriteLine(list[0]);

        }
    }
}
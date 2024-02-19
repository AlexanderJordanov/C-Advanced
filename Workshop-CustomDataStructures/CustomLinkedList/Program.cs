namespace CustomLinkedList
{
    public class Program
    {
        static void Main()
        {
            CustomLinkedList<int> linkedList = new CustomLinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddFirst(0);
            linkedList.AddFirst(-1);
            linkedList.RemoveFirst();
            linkedList.RemoveLast();
            Node<int> node = linkedList.Head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            Console.WriteLine();

            linkedList.ForEach(node => Console.WriteLine(node));
            Console.WriteLine();

            int[] array = linkedList.ToArray();
            Console.WriteLine(String.Join(", ", array));

            CustomLinkedList<double> doublelinkedList = new CustomLinkedList<double>();
            doublelinkedList.AddLast(1.1);
            doublelinkedList.AddLast(2.1);
            doublelinkedList.AddLast(3.1);
            doublelinkedList.AddLast(4.1);
            doublelinkedList.AddFirst(0.2);
            doublelinkedList.AddFirst(-1.3);
            doublelinkedList.RemoveFirst();
            doublelinkedList.RemoveLast();
            Node<double> doublenode = doublelinkedList.Head;
            while (doublenode != null)
            {
                Console.WriteLine(doublenode.Value);
                doublenode = doublenode.Next;
            }
            Console.WriteLine();

            doublelinkedList.ForEach(doublenode => Console.WriteLine(doublenode));
            Console.WriteLine();

            double[] doublearray = doublelinkedList.ToArray();
            Console.WriteLine(String.Join(", ", doublearray));
        }
    }  
}
namespace CustomLinkedList
{
    public class CustomLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }
        public void AddLast(T value)
        {
            Count++;
            Node<T> newNode = new Node<T>(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }
        public void AddFirst(T value)
        {
            Count++;
            Node<T> newNode = new Node<T>(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }
        public void RemoveFirst()
        {
            Count--;
            Node<T> newHead = Head.Next;
            if (newHead == null)
            {
                Head = null;
                Tail = null;
                return;
            }
            newHead.Previous = null;
            Head.Next = null;
            Head = newHead;
        }
        public void RemoveLast()
        {
            Count--;
            if (Tail == null)
            {
                return;
            }
            Node<T> newTail = Tail.Previous;
            if (newTail == null)
            {
                Head = null;
                Tail = null;
                return;
            }
            newTail.Next = null;
            Tail.Previous = null;
            Tail = newTail;
        }

        public void ForEach(Action<T> callback)
        {
            Node<T> node = Head;
            while (node != null)
            {
                callback(node.Value);
                node = node.Next;
            }
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];
            int index = 0;
            ForEach(n =>
            {
                array[index++] = n;
            });
            return array;
        }
    }
}

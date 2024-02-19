namespace CustomQueue
{
    public class Program
    {
        static void Main() 
        {
            CustomQueue queue = new CustomQueue();
            queue.Enqueue(7);
            queue.Enqueue(99);
            queue.Enqueue(111);
            queue.Enqueue(413);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            queue.Clear();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine(queue.Dequeue());
        }
    }
}
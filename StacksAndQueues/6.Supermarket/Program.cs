Queue<string> queue = new Queue<string>();
string customer = "";
while ((customer = Console.ReadLine()) != "End")
{
    if (customer == "Paid")
    {
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
        continue;
    }

    queue.Enqueue(customer);
    ;
}
Console.WriteLine($"{queue.Count} people remaining.");
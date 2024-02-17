int carsToPass = int.Parse(Console.ReadLine());
Queue<string> carsWaiting = new Queue<string>();
int carCount = 0;
string input = string.Empty;
while ((input = Console.ReadLine()) != "end")
{
    if (input == "green")
    {
        for (int i = 0; i < carsToPass; i++)
        {
            if (carsWaiting.Count > 0)
            {
                Console.WriteLine($"{carsWaiting.Dequeue()} passed!");
                carCount++;
            }        
        }
    }
    else
    {
        carsWaiting.Enqueue(input);
    }
}

Console.WriteLine($"{carCount} cars passed the crossroads.");

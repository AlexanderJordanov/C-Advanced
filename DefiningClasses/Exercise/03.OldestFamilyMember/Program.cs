namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            Family family = new();
            for (int i = 0; i < lines; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                family.AddMember(person);
            }
            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
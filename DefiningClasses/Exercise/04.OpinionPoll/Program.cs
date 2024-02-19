namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        { 
            int lines = int.Parse(Console.ReadLine());
            List<Person> family = new();
            for (int i = 0; i < lines; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                family.Add(new Person(personInfo[0], int.Parse(personInfo[1])));
            }
            List<Person> persons = family.Where(p => p.Age > 30).OrderBy(p =>p.Name).ToList();
            foreach(Person person in persons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
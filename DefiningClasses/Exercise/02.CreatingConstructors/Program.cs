namespace DefiningClasses
{
    public class StartUp
    {
        static void Main() 
        {
            Person person = new Person();
            Person person1 = new Person(15);
            Person person2 = new Person("Pesho", 42);
            Console.WriteLine(person.Name + " " + person.Age);
            Console.WriteLine(person1.Name + " " + person1.Age);
            Console.WriteLine(person2.Name + " " + person2.Age);

        }
    }
}
namespace DefiningClasses
{
    public class Family
    {
        List<Person> family = new();

        public void AddMember(Person person)
        {
            family.Add(person);
        }
        public Person GetOldestMember()
        {
            int maxAge = family.Max(p => p.Age);
            return family.FirstOrDefault(p => p.Age == maxAge);
        }
    }
}

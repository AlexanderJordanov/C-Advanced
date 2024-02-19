using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveChild(string childFullName)
        {
            string[] nameArgs = childFullName.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string firstName = nameArgs[0];
            string lastName = nameArgs[1];
            Child foundChild = Registry.FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
            if (foundChild != null)
            {
                Registry.Remove(foundChild);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ChildrenCount { get { return Registry.Count; } }

        public Child GetChild(string childFullName)
        {
            string[] nameArgs = childFullName.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string firstName = nameArgs[0];
            string lastName = nameArgs[1];
            Child foundChild = Registry.FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
            if (foundChild != null)
            {
                return foundChild;
            }
            else
            {
                return null;
            }
        }
        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (Child child in Registry.OrderByDescending(c => c.Age).ThenBy(c => c.LastName).ThenBy(c => c.FirstName))
            {
                sb.AppendLine(child.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

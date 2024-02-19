using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; set; }
        public List<Shark> Species { get; set; }
        public int GetCount { get { return Species.Count; } }

        public void AddShark(Shark shark)
        {
            if (GetCount < Capacity)
            {
                if (!Species.Contains(shark))
                {
                    Species.Add(shark);
                }               
            }
        }
        public bool RemoveShark(string kind)
        {
            return Species.Remove(Species.FirstOrDefault(x => x.Kind == kind));
        }
        public string GetLargestShark()
        {
            int maxLength = 0;
            foreach (Shark shark in Species)
            {
                if (maxLength < shark.Length) 
                { 
                    maxLength = shark.Length;
                }
            }
            List<Shark> sharks = new List<Shark>();
            foreach (Shark shark in Species)
            {
                if (shark.Length == maxLength)
                {
                    sharks.Add(shark);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (Shark shark in sharks)
            {
                sb.AppendLine(shark.ToString());
            }
            return sb.ToString().TrimEnd();
        }
        public double GetAverageLength()
        {
            return Species.Average(x => x.Length);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetCount} sharks classified:");
            foreach (Shark shark in Species)
            {
                sb.AppendLine(shark.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}

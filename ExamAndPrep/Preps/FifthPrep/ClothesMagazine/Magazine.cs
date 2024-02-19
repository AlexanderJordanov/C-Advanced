using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }

        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity) 
            {
                Clothes.Add(cloth);
            }
        }
        public bool RemoveCloth (string color)
        {
            Cloth foundClothToRemove = (Clothes.FirstOrDefault(c => c.Color == color));
            if (foundClothToRemove != null)
            {
                Clothes.Remove(foundClothToRemove);
                return true;
            }
            return false;

        }
        public Cloth GetSmallestCloth()
        {
            Cloth smallestCloth = new Cloth(default, int.MaxValue, default);
            foreach(Cloth cloth in Clothes)
            {
                if (cloth.Size < smallestCloth.Size)
                {
                    smallestCloth = cloth;
                }
            }
            return smallestCloth;

        }
        public Cloth GetCloth(string color)
        {
            return Clothes.FirstOrDefault(c => c.Color == color);
        }
        public int GetClothCount()
        {
            return Clothes.Count;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");

            foreach(Cloth cloth in Clothes.OrderBy(c=>c.Size))
            {
                sb.AppendLine(cloth.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

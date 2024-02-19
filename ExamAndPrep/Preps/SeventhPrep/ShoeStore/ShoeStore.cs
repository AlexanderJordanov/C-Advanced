using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes { get; set; }
        public int Count { get { return Shoes.Count; } }
        public string AddShoe(Shoe shoe)
        {
            if (Shoes.Count < StorageCapacity)
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
            else
            {
                return "No more space in the storage room.";
            }
        }
        public int RemoveShoes(string material)
        {
            List<Shoe> removedShoes = new();
            for (int i = 0; i < Shoes.Count; i++)
            {
                if (Shoes[i].Material == material)
                {

                    removedShoes.Add(Shoes[i]);
                    Shoes.Remove(Shoes[i]);
                    i--;
                }
            }
            return removedShoes.Count;
        }

        public List<Shoe> GetShoesByType(string type)
        {
            string lowType = type.ToLower();
            List<Shoe> shoesOfType = new List<Shoe>();
            foreach (Shoe shoe in Shoes)
            {
                if (shoe.Type.ToLower() == lowType)
                {
                    shoesOfType.Add(shoe);
                }
            }
            return shoesOfType;
        }
        public Shoe GetShoeBySize(double size)
        {
            return Shoes.FirstOrDefault(s => s.Size == size);
        }
        public string StockList(double size, string type)
        {
            List<Shoe> shoesMatch = Shoes.Where(s => s.Size == size && s.Type == type).ToList();
            if (shoesMatch.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (Shoe shoe in shoesMatch)
                {
                    sb.AppendLine(shoe.ToString());
                }
                return sb.ToString().Trim();
            }
            else
            {
                return "No matches found!";
            }
        }
    }
}

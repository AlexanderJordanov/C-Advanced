using System.Text;

namespace GroceriesManagement
{
    public class GroceriesStore
    {
        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new();
        }

        public int Capacity { get; set; }
        public double Turnover { get; set; }
        public List<Product> Stall { get; set; }
        public void AddProduct(Product product)
        {
            if (Stall.Count + 1 <= Capacity && Stall.FirstOrDefault(p => p.Name == product.Name) == null)
            {
                Stall.Add(product);
            }
        }
        public bool RemoveProduct(string name)
        {
            return Stall.Remove(Stall.FirstOrDefault(p => p.Name == name));
        }
        public string SellProduct(string name, double quantity)
        {
            Product product = Stall.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                return "Product not found";
            }
            else
            {
                double productTotalPrice = product.Price * quantity;
                double roundPrice = Math.Round(productTotalPrice, 2);
                Turnover += roundPrice;
                return $"{product.Name} - {productTotalPrice:f2}$";
            }
        }
        public string GetMostExpensive()
        {
            Product product = Stall.OrderByDescending(p => p.Price).First();
            return product.ToString();
        }
        public string CashReport()
        {
            return $"Total Turnover: {Turnover:f2}$";
        }
        public string PriceList()
        {
            StringBuilder sb = new();
            sb.AppendLine("Groceries Price List:");
            foreach(Product product in Stall)
            {
                sb.AppendLine(product.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if(Vehicles.Count < Capacity) 
            {
                Vehicles.Add(vehicle);
            }
        }
        public bool RemoveVehicle(string vin)
        {
            //Vehicle foundVehicle = Vehicles.FirstOrDefault(v => v.VIN == vin);
            //if (foundVehicle != null)
            //{
            //    Vehicles.Remove(foundVehicle);
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return Vehicles.Remove(Vehicles.FirstOrDefault(v=>v.VIN == vin));
        }
        public int GetCount()
        {
            return Vehicles.Count;
        }
        public Vehicle GetLowestMileage()
        {
            return Vehicles.OrderBy(v=>v.Mileage).First();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach(var vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

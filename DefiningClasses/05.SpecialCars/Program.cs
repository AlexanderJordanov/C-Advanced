namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new ();
            string input;
            while ((input = Console.ReadLine()) != "No more tires") 
            {
                string[] tiresInfo = input.Split(); 
                List<Tire> tiresList = new List<Tire>();
                for (int i = 0; i < tiresInfo.Length; i += 2)
                {
                    int year = int.Parse(tiresInfo[i]);
                    double pressure = double.Parse(tiresInfo[i + 1]);
                    Tire tire = new(year,pressure);
                    tiresList.Add(tire);
                }
                tires.Add(tiresList.ToArray());
            }

            List<Engine> engines = new();
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = input.Split();
                int horsePower = int.Parse(engineInfo[0]);
                double cupicCapacity = double.Parse(engineInfo[1]);
                Engine engine = new Engine(horsePower, cupicCapacity);
                engines.Add(engine);
            }

            List<Car> cars = new();
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input.Split();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse((carInfo[6]));
                Car car = new(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);
            }

            List<Car> specialCars = new();
            foreach(var car in cars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.Sum(t => t.Pressure) >= 9 && car.Tires.Sum(t => t.Pressure) <= 10)
                {
                    specialCars.Add(car);                   
                }
            }
            
            foreach(var car in specialCars)
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}
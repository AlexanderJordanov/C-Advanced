namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Car> cars = new();
            for (int i = 0; i < lines; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Engine engine = new(engineSpeed, enginePower);
                Cargo cargo = new(cargoType, cargoWeight);
                List<Tire> tires = new();
                for (int j = 5; j < carInfo.Length; j += 2)
                {
                    double tirePressure = double.Parse(carInfo[j]);
                    int tireAge = int.Parse(carInfo[j + 1]);
                    Tire tire = new Tire(tireAge, tirePressure);
                    tires.Add(tire);
                }
                Car car = new(model, engine, cargo, tires);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            List<Car> filteredCars = cars.Where(car => car.Cargo.Type == command).ToList();
            foreach (Car car in filteredCars)
            {
                if(command == "fragile" && car.Tires.Any(t => t.Pressure < 1))
                {
                    Console.WriteLine(car.Model);
                }
                else if (command == "flammable" && car.Engine.Power > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}

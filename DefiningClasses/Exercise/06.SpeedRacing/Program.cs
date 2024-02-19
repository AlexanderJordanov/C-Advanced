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
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);
                Car car = new(model, fuelAmount, fuelConsumption);  
                if (!cars.Contains(car))
                {
                    cars.Add(car);
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "End") 
            {
                string[] driveInfo = input.Split();
                string model = driveInfo[1];
                double distance = double.Parse(driveInfo[2]);

                foreach(Car car in cars)
                {
                    if (car.Model == model)
                    {
                        car.Drive(distance);
                    }
                }
            }

            foreach(Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
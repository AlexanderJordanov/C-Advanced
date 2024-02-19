namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        { 
            int lines = int.Parse(Console.ReadLine());
            List<Engine> engines = new();
            for (int i = 0; i < lines; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineInfo[0];
                int enginePower = int.Parse(engineInfo[1]);
                Engine engine = new Engine(engineModel, enginePower);
                if (engineInfo.Length == 3)
                {
                    if (char.IsDigit(engineInfo[2][0]))
                    {
                        int engineDisplacement = int.Parse(engineInfo[2]);
                        engine.Displacement = engineDisplacement;
                    }
                    else
                    {
                        string engineEfficiecy = engineInfo[2];
                        engine.Efficiency = engineEfficiecy;
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    int engineDisplacement = int.Parse(engineInfo[2]);
                    string engineEfficiecy = engineInfo[3];
                    engine.Displacement = engineDisplacement;
                    engine.Efficiency = engineEfficiecy;
                }
                engines.Add(engine);
            }
            lines = int.Parse(Console.ReadLine());
            List<Car> cars = new();
            for (int i = 0; i < lines; ++i)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                string engineModel = carInfo[1];
                Engine engine = engines.FirstOrDefault(e => e.Model == engineModel);
                Car car = new Car(carModel, engine);
                if (carInfo.Length == 3) 
                { 
                    if (char.IsDigit(carInfo[2][0]))
                    {
                        int carWeight = int.Parse(carInfo[2]);
                        car.Weight = carWeight;
                    }
                    else
                    {
                        string color = carInfo[2];
                        car.Color = color;
                    }
                }
                else if (carInfo.Length == 4)
                {
                    int carWeight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    car.Weight = carWeight;
                    car.Color = color;
                }
                cars.Add(car);
            }
            foreach(Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
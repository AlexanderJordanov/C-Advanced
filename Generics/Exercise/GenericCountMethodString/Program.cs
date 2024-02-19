namespace Generics
{
    public class StartUp
    {
        static void Main()
        {

            int lines = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>(); //string
            for (int i = 0; i < lines; i++)
            {
                double listRow = double.Parse(Console.ReadLine()); //string
                box.Add(listRow);
            }
            double comparison = double.Parse(Console.ReadLine()); //string
            Console.WriteLine(box.Count(comparison));

        }
    }
}
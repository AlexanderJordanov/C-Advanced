namespace Generics
{
    public class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < lines; i++)
            {
                box.Add(Console.ReadLine());
            }
            Console.WriteLine(box);
        }
    }
}
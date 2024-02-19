namespace GenericScale
{
    public class StartUp
    {
        static void Main()
        {
            EqualityScale<int> scale = new(7, 6);
            Console.WriteLine(scale.AreEqual());
        }
    }
}
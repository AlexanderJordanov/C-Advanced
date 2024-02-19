

namespace Generics
{
    public class StartUp
    {
        static void Main()
        {
            // 07.Tuple
            //string[] nameArgs = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //CustomTuple<string,string> nameTuple = new($"{nameArgs[0]} {nameArgs[1]}", nameArgs[2]);
            //string[] beerArgs = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //CustomTuple<string,int> beerTuple = new(beerArgs[0], int.Parse(beerArgs[1]));
            //string[] numbers = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //CustomTuple<int,double> numbersTuple = new(int.Parse(numbers[0]), double.Parse(numbers[1]));
            //Console.WriteLine(nameTuple);
            //Console.WriteLine(beerTuple);
            //Console.WriteLine(numbersTuple);

            string[] nameTokens = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] beerTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] bankTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string townName = default;
            if (nameTokens.Length == 5)
            {
                townName = $"{nameTokens[3]} {nameTokens[4]}";
            }
            else
            {
                townName = nameTokens[3];
            }


            Threeuple<string, string, string> nameTuple = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2], townName);
            Threeuple<string, int, bool> beers = new(beerTokens[0], int.Parse(beerTokens[1]),
                beerTokens[2] == "drunk");
            Threeuple<string, double, string> account = new(bankTokens[0],
                double.Parse(bankTokens[1]), bankTokens[2]);

            Console.WriteLine(nameTuple);
            Console.WriteLine(beers);
            Console.WriteLine(account);
        }
    }
}
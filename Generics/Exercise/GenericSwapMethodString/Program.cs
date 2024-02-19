using System.Collections.Generic;

namespace Generics
{
    public class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(); //string
            for (int i = 0; i < lines; i++)
            {
                list.Add(int.Parse(Console.ReadLine())); //remove int.Parse
            }
            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            GenericSwap(list, indexes[0], indexes[1]);
            foreach(int item in list) //string
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
        public static void GenericSwap<T>(List<T> items, int firstIndex, int secondIndex)
        {
            T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }
    }
}
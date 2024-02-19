

using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T> where T: IComparable
    {
        private List<T> list;
        public Box()
        {
            list = new List<T>();
        }
        public void Add(T item)
        {
            list.Add(item);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in list)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
        public int Count(T item)
        {
            int count = 0;
            foreach (T listItem in list)
            {
                if (listItem.CompareTo(item) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

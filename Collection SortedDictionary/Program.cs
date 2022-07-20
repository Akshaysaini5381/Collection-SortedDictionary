using System;
using System.Collections.Generic;
namespace Collection_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> s = new SortedDictionary<int, int>();
            s.Add(1, 12);
            s.Add(2, 12);
            s.Add(3, 128);
            s.Add(4, 125);
            s.Add(5, 124);

            foreach (KeyValuePair<int,int> item in s)
            {
                Console.WriteLine(" "+item.Key+" "+item.Value);
            }
            Console.WriteLine(s.Count);
        }
    }
}

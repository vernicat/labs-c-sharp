using System;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "каждый охотник желает знать";
            Console.WriteLine("Было: {0}",s);
            string[] sa = s.Split();
            Array.Sort(sa);
            s = String.Join(' ', sa);
            Console.WriteLine("Стало: {0}", s);
        }
    }
}

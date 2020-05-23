using System;

namespace Ex4
{
    class Program
    {
        static double Avarge(params int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7 };
            Console.WriteLine("Avg: {0} ", Avarge(arr));
            short z = 1, e = 12;
            byte v = 107;
            Console.WriteLine("Avg: {0} ", Avarge(z, e, v));
            Console.WriteLine("Avg: {0} ", Avarge());
        }
    }
}

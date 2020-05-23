using System;

namespace Ex5
{
    class Program
    {
        static double Avarge(ref int a, params int[] arr)
        {
            double av = 0;
            a++;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }

        static double Avarge1(int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }

        static void StrUpdate(params char[] arr)
        {
            for (int i = 0, j = 255; i < arr.Length; i++, j++)
            {
                arr[i] = Convert.ToChar(j); // знак заданной строки в знак Юникода
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }

        static void GetType1(Object Obj)
        {
            Console.WriteLine(Obj.GetType());
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 0 };
            int a = 1, b = 3, c = 5, d = 7, e = 9, f = 0;

            Console.WriteLine(Avarge(ref a, b, c, d, e, f));
            Console.WriteLine(Avarge(ref a, arr));
            Console.WriteLine(a);
            //Console.WriteLine(Avarge1(a, b, c, d, e, f)); // Ни одна из перегрузок метода "Avarge1" не принимает 6 аргументов
            Console.WriteLine(Avarge1(arr));

            char[] str = { 'И', 'з', 'м', 'е', 'н', 'е', 'н', 'и', 'е' };
            StrUpdate(str);

            GetType1(arr);
        }
    }
}

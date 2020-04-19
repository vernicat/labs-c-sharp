using System;

namespace Lab3
{
    class Program
    {
        class Arrs
        {
            private static Random rnd = new Random();

            public static void CreateOneDimAr(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = rnd.Next(1, 100);
            }

            public static void PrintArr1(string b, int[] a)
            {
                string c = "{";
                Console.Write("Массив {0} = {1}", b, c);
                for (int i = 0; i < a.Length; i++)
                    if (i == 0)
                        Console.Write("{0}", a[i]);
                    else
                        Console.Write(", {0}", a[i]);
                c = "}";
                Console.WriteLine(c);
            }

            public static void PrintArr2(string b, int[,] a)
            {
                Console.Write("Массив {0}\n", b);
                for (int i = 0; i < a.GetLength(0); i++, Console.WriteLine())
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (j == 0 && i != 0)
                            Console.Write(a[i, j].ToString() + " ");
                        else
                            Console.Write(a[i, j].ToString() + " ");
                Console.WriteLine();
            }

            public static void CreateAr2(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        a[i, j] = rnd.Next(1, 10);
            }
            public static void PrintArr3(int[][] a)
            {
                for (int i = 0; i < a.Length; i++, Console.WriteLine())
                    for (int j = 0; j < a[i].Length; j++)
                        Console.Write(a[i][j].ToString() + " ");
            }

            public static void CreateAr3(int[][] a)
            {
                for (int i = 0; i < a.Length; i++)
                    for (int j = 0; j < a[i].Length; j++)
                        a[i][j] = rnd.Next(10, 100);
            }
        }

        static int[,] MultMatr(int[,] a, int[,] b)
        {
            int[,] c = new int[a.GetLength(0), b.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    for (int k = 0; k < b.GetLength(0); k++)
                        c[i, j] += a[i, k] * b[k, j];
            return c;
        }
        static void Main()
        {
            //Задание 1
            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[5];
            Arrs.CreateOneDimAr(A);
            Arrs.CreateOneDimAr(B);
            for (int i = 0; i < A.Length; i++)
                C[i] = A[i] + B[i];
            int[] X = { 5, 5, 6, 6, 7, 7 };
            int[] U, V;
            U = new int[3] { 1, 2, 3 };
            //V = { 1, 2, 3};
            V = new int[3];
            V = U;
            V[0] = 9;
            Arrs.PrintArr1("A", A);
            Arrs.PrintArr1("B", B);
            Arrs.PrintArr1("C", C);
            Arrs.PrintArr1("X", X);
            Arrs.PrintArr1("U", U);
            Arrs.PrintArr1("V", V);

            //Console.WriteLine("Введите размерность массива:");
            //int size = int.Parse(Console.ReadLine());
            //int[] D = new int[size];
            //Arrs.CreateOneDimAr(D);
            //Arrs.PrintArr1("D", D);

            //Задание 2
            //int[,] A = new int[3,3], B = new int[3, 3];
            //Arrs.CreateAr2(A);
            //Arrs.CreateAr2(B);
            //Arrs.PrintArr2("A", A);
            //Arrs.PrintArr2("B", B);
            //Arrs.PrintArr2("C", MultMatr(A,B));

            //Задание 3
            //int[][] R =
            //{
            //    new int[1],
            //    new int[2],
            //    new int[3],
            //    new int[4],
            //    new int[5],
            //    new int[6],
            //    new int[7],
            //    new int[8],
            //    new int[9],
            //    new int[10]
            //};
            //Arrs.CreateAr3(R);
            //Arrs.PrintArr3(R);
        }
    }
}

using System;

namespace Lab4
{
    class Program
    {
        class My_array
        {
            private static Random rnd = new Random();

            public static void CreateOneDimAr(int[,] a) // Заполнение массива рандомными значениями
            {
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        a[i, j] = rnd.Next(1, 10); // от 1 до 10
            }
            // Задание 5
            public static void PrintArObj(string name, object[] ar)
            {
                Console.WriteLine("Массив {0}", name);
                //	Реализуйте тело этой функции воспользовавшись циклом foreach
                foreach (object ar1 in ar)
                    Console.Write(" {0} ", ar1);
                Console.WriteLine();
            }
        }

        // Задание 1
        static void PrintAnyArr(string name, Array ar) // Универсальная функция, печать любого массива
        {
            Console.WriteLine("Массив {0}", name);
            if (ar.Rank == 1) // Отличить размерность массива (отличить вектор от матрицы) слудует использовать свойство Rank
                if (ar.GetValue(0) is Array)
                {
                    int count = 0;
                    // печатать усеченный массив
                    foreach (Array ar1 in ar)
                    {
                        PrintAnyArr(name + count.ToString(), ar1);
                        count++;
                    }
                    Console.WriteLine();
                }
                else
                {
                    foreach (Object ar1 in ar)
                        Console.Write(ar1.ToString().Length+" ");
                    Console.WriteLine();
                }
            if (ar.Rank == 2)
            {
                for (int i = 0; i < ar.GetLength(0); i++, Console.WriteLine())
                    for (int j = 0; j < ar.GetLength(1); j++)
                        Console.Write(ar.GetValue(i, j).ToString() + " ");
                Console.WriteLine();
            }
        }

        // Задание 3
        static void PrintArr(string s, Object ar) // Функция печати массива, принимающая в качестве параметра объект типа Object
        {
            Array ar1 = ar as Array;
            if (ar == null)
            {
                Console.WriteLine("Массив пуст.");
            }
            PrintAnyArr(s, ar1);
        }

        // Задание 6

        static int min(int a, int b)
        {
            if (a > b)
                return b;
            return a;
        }

        // Поэлементное сложение массивов с одинаковыми границами индексов
        static int[,] sum(int[,] ar1, int[,] ar2)
        {
            int i1 = min(ar1.GetLength(0), ar2.GetLength(0)); // Минимум по количеству строк
            int j1 = min(ar1.GetLength(1), ar2.GetLength(1)); // Минимум по количеству столбцов

            int[,] rez = new int[i1, j1]; // Результирующая
            for (int i = 0; i < i1; i++)
                for (int j = 0; j < j1; j++)
                    rez[i, j] = ar1[i, j] + ar2[i, j];
            return rez;
        }

        // Поэлементное вычитание массивов с одинаковыми границами индексов
        static int[,] dif(int[,] ar1, int[,] ar2)
        {
            int i1 = min(ar1.GetLength(0), ar2.GetLength(0)); // Минимум по количеству строк
            int j1 = min(ar1.GetLength(1), ar2.GetLength(1)); // Минимум по количеству столбцов

            int[,] rez = new int[i1, j1]; // Результирующая
            for (int i = 0; i < i1; i++)
                for (int j = 0; j < j1; j++)
                    rez[i, j] = ar1[i, j] - ar2[i, j];
            return rez;
        }

        // Умножение всех элементов массива на скаляр
        static int[,] multMatr(int[,] ar1, int[,] ar2)
        {
            int[,] rez = new int[ar1.GetLength(0), ar2.GetLength(0)];  // Результирующая

            for (int i = 0; i < ar1.GetLength(0); i++)
                for (int j = 0; j < ar1.GetLength(1); j++)
                    for (int k = 0; k < ar2.GetLength(0); k++)
                        rez[i, j] += ar1[i, k] * ar2[k, j];
            return rez;
        }

        // Деление всех элементов массива на скаляр
        static double[,] divMatr(int[,] ar1, int[,] ar2)
        {
            double[,] rez = new double[ar1.GetLength(0), ar2.GetLength(0)];  // Результирующая

            for (int i = 0; i < ar1.GetLength(0); i++)
                for (int j = 0; j < ar1.GetLength(1); j++)
                    for (int k = 0; k < ar2.GetLength(0); k++)
                        rez[i, j] += ar1[i, k] / ar2[k, j];
            return rez;
        }


        static void Main()
        {
            // Задание 1
            //double[] a = { 8, 7.7, 5, 1 };
            //int[,] b = {
            //    { 5, 3, 8 },
            //    { 1, 9, 2 }
            //};
            //int[][] c = {
            //    new int[] {6,8,3,1,7},
            //    new int[] {1,4,8,2,3},
            //    new int[] {9,7,1,8,2}
            //};
            //PrintAnyArr("a", a);
            //PrintAnyArr("b", b);
            //PrintAnyArr("c", c);

            // Задание 2
            int count = 4;
            string[] mas = { "1", "5", "4", "6", "3", "2" },
                    mas1 = new string[count];

            // Позволяет копировать весь массив или его часть в другой массив
            Console.Write("Копирование: ");
            Array.Copy(mas, mas1, count);
            foreach (object mas2 in mas1)
                Console.Write(" {0} ", mas2);
            Console.WriteLine();

            //// Определяют индексы первого и последнего вхождения образца в массив, возвращая - 1, если такового вхождения не обнаружено
            //Console.Write("Индекс первого вхождения: ");
            //Console.WriteLine(Array.IndexOf(mas1, "2"));
            //Console.Write("Индекс последнего вхождения: ");
            //Console.WriteLine(Array.LastIndexOf(mas1, "4"));

            //// Выполняет обращение массива, переставляя элементы в обратном порядке
            //Console.Write("Обращение: ");
            //Array.Reverse(mas1);
            //foreach (object mas2 in mas1)
            //    Console.Write(" {0} ", mas2);
            //Console.WriteLine();

            //// Осуществляет сортировку массива
            //Console.Write("Сортировка: ");
            //Array.Sort(mas1);
            //foreach (object mas2 in mas1)
            //    Console.Write(" {0} ", mas2);
            //Console.WriteLine();

            //// Определяет индекс первого вхождения образца в отсортированный массив, используя алгоритм двоичного поиска
            //Console.Write("Индекс первого вхождения в отсортированный массив (алгоритм двоичного поиска): ");
            //Console.WriteLine(Array.BinarySearch(mas1, "6"));

            //Задание 3
            //int[] ar = { 1, 7, 3 };
            //int[,] mas = { 
            //    { 8, 3, 9 }, 
            //    { 7, 5, 2 } 
            //};
            //Console.WriteLine(mas.Length); // Общее кол-во элементов массива
            //Console.WriteLine(mas.GetLength(0)); // Первый подмассив
            //Console.WriteLine(mas.GetLength(1));  // Второй подмассив
            //PrintArr("Array", ar);  // Функцию печати массива, принимающая в качестве параметра объект типа Object

            // Задание 4 (отдельно)

            //Задание 5
            // Для массивов различных типов
            //object[] arr1 = { 7, 2, 9 };
            //object[] arr2 = { 3.6, 1.4, 6.2 };
            //My_array.PrintArObj("arr1", arr1);
            //My_array.PrintArObj("arr2", arr2);

            //Задание 6
            // Задание произвольных целых границ индексов при создании объекта
            //Console.WriteLine("Целые границы индексов: ");
            //int g1 = int.Parse(Console.ReadLine());
            //int g2 = int.Parse(Console.ReadLine()); // Значение задано 

            //// Заполнение массивов рандомными значениями
            //int[,] mas1 = new int[g1, g2];
            //int[,] mas2 = new int[5, 5];

            //My_array.CreateOneDimAr(mas1);
            //My_array.CreateOneDimAr(mas2);

            //// Обращение к отдельному элементу массива с контролем выхода за пределы массива
            //Console.WriteLine("Введите координаты (индексы, т.е. с 0):");
            //g1 = int.Parse(Console.ReadLine());
            //g2 = int.Parse(Console.ReadLine());

            //if (g1 >= mas1.GetLength(0) || g2 >= mas1.GetLength(1))
            //    Console.WriteLine("Вне пределов массива.");
            //else
            //    Console.WriteLine("В координатах ({0}, {1}) значение равно {2}", g1, g2, mas1[g1, g2]);

            //// 1ый параметр "Имя" (по заданию)
            //PrintAnyArr("A", mas1);
            //PrintAnyArr("B", mas2);

            //PrintAnyArr("Сумма",      sum(mas1, mas2));       // Поэлементное сложение массивов с одинаковыми границами индексов
            //PrintAnyArr("Разность",   dif(mas1, mas2));       // Поэлементное вычитание массивов с одинаковыми границами индексов

            //PrintAnyArr("Умножение",  multMatr(mas1, mas2));  // Умножение всех элементов массива на скаляр
            //PrintAnyArr("Деление",    divMatr(mas1, mas2));   // Деление всех элементов массива на скаляр
        }
    }
}
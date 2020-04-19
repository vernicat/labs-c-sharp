using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nExercise 1\n");
            int a, b;
            Console.WriteLine("Введите число а");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b = int.Parse(Console.ReadLine());
            int s = a + b;
            Console.WriteLine("{0} + {1} = {2} ", a , b, s);

            Console.WriteLine("\nExercise 2\n");
            int a1, b1;
            Console.WriteLine("Введите число а");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {1} + {0}", a1, b1);

            Console.WriteLine("\nExercise 3\n");
            int a2, b2, c, s2;
            Console.WriteLine("Введите число а");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("c = " + c);
            s2 = a2 + b2 + c;
            Console.WriteLine("{0} + {1} + {2} = {3}", a2, b2, c, s2);

            Console.WriteLine("\nExercise 4\n");
            double a3, b3, s3;
            Console.WriteLine("Введите число а");
            a3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b3 = double.Parse(Console.ReadLine());
            s3 = a3 * b3;
            Console.WriteLine("{0:##.#} * {1:##.#} = {2:##.#} ", a3, b3, s3);

            Console.WriteLine("\nExercise 5\n");
            double a4, b4, s4;
            Console.WriteLine("Введите число а");
            a4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b4 = double.Parse(Console.ReadLine());
            s4 = a4 / b4;
            Console.WriteLine("{0:#.###} / {1:#.###} = {2:#.###} ", a4, b4, s4);

            Console.WriteLine("\nExercise 6\n");
            double a5, b5, c5;
            Console.WriteLine("Введите число а");
            a5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            b5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c");
            c5 = double.Parse(Console.ReadLine());
            Console.WriteLine("<{0:#.##} + {1:#.##}> + {2:#.##} = {0:#.##} + <{1:#.##} + {2:#.##}>", a5, b5, c5);
        }
    }
}

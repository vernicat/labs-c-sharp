using System;

namespace Ex3
{
    class Program
    {
        static void Info(double value, out int sign, out bool isInteger, out double abs, out double sqr)
        {
            sign = Math.Sign(value);
            isInteger = value % 1 == 0 ? true : false;
            abs = Math.Abs(value);
            sqr = value * value;
        }

        static void Main(string[] args)
        {
            double a = 42, b = -12.67, c, d;
            int e;
            bool f;
            Info(a, out e, out f, out c, out d);
            Console.WriteLine("Число {0}\nЗнак числа: {1}\nЦелочисленное значение: {2}\nМодуль числа: {3}\nКвадрат числа: {4}\n", a, e, f, c, d);
            Info(b, out e, out f, out c, out d);
            Console.WriteLine("Число {0}\nЗнак числа: {1}\nЦелочисленное значение: {2}\nМодуль числа: {3}\nКвадрат числа: {4}\n", b, e, f, c, d);
        }
    }
}

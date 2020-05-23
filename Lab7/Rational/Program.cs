using System;

namespace Rational
{
    class Program
    {
        private class Rational
        {
            private int m, n;

            public Rational(int a, int b)
            {
                if (b == 0)
                {
                    this.m = 0;
                    this.n = 1;
                }
                else
                {
                    if (a < 0 && b < 0) { 
                        a = Math.Abs(a);
                        b = Math.Abs(b);
                    }
                    if (b < 0) {
                        b *= -1;
                        a *= -1;
                    }
                    int c = Nod(a, b);
                    this.m = a / c;
                    this.n = b / c;
                }
            }

            private static int Nod(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);

                while (a != 0 && b != 0)
                    _ = (a > b) ? a %= b : b %= a;
                return a + b;
            }

            public override string ToString()
            {
                return m + "/" + n;
            }

            public void PrintRational()
            {
                Console.WriteLine("{0}/{1}", m, n);
            }

            public Rational Plus(Rational a)
            {
                int b, c;
                b = m * a.n + n * a.m;
                c = n * a.n;
                int d = Nod(b, c);
                return new Rational(b / d, c / d);
            }

            public Rational Minus(Rational a)
            {
                int b, c;
                b = m * a.n - n * a.m;
                c = n * a.n;
                int d = Nod(b, c);
                return new Rational(b / d, c / d);
            }

            public Rational Mult(Rational a)
            {
                int b, c;
                b = m * a.m;
                c = n * a.n;
                int d = Nod(b, c);
                return (new Rational(b / d, c / d));
            }

            public Rational Divide(Rational a)
            {
                int b, c;
                b = m * a.n;
                c = n * a.m;
                int d = Nod(b, c);
                return (new Rational(b / d, c / d));
            }

            public static Rational operator +(Rational a, Rational b)
            {
                return a.Plus(b);
            }

            public static Rational operator -(Rational a, Rational b)
            {
                return a.Minus(b);
            }

            public static Rational operator *(Rational a, Rational b)
            {
                return (a.Mult(b));
            }

            public static Rational operator /(Rational a, Rational b)
            {
                return (a.Divide(b));
            }

            private Rational(int a, int b, string t)
            {
                m = a;
                n = b;
            }

            public static readonly Rational Zero, One;

            static Rational()
            {
                Zero = new Rational(0, 1, "private");
                One = new Rational(1, 1, "private");
            }

            public static bool operator ==(Rational a, Rational b)
            {
                return (a.m == b.m) && (a.n == b.n);
            }

            public static bool operator !=(Rational a, Rational b)
            {
                return (a.m != b.m) || (a.n != b.n);
            }

            public static bool operator >(Rational a, Rational b)
            {
                return (a.m * b.n) > (a.n * b.m);
            }

            public static bool operator <(Rational a, Rational b)
            {
                return (a.m * b.n) < (a.n * b.m);
            }

            public static bool operator <(Rational a, double b)
            {
                return (double)a.m / a.n < b;
            }

            public static bool operator >(Rational a, double b)
            {
                return (double)a.m / a.n > b;
            }

            public static void TestRational()
            {
                Rational q = new Rational(5, 2);
                Rational w = new Rational(2, 6);
                Rational s = new Rational(2, 8);
                Rational z = new Rational(4, 8);

                double x = 1.75;
                double y = -1.75;

                if (q == One)
                    Console.WriteLine("Равно");
                if (w != Zero)
                    Console.WriteLine("Неравно");
                if (z < s)
                    Console.WriteLine("Меньше");
                if (s > Zero)
                    Console.WriteLine("Больше");
                if (s < x)
                    Console.WriteLine("Меньше");
                if (z > y)
                    Console.WriteLine("Больше");
            }
        }

        static void Main(string[] args)
        {
            Rational a = new Rational(-4, -16);
            Rational b = new Rational(2, 6);
            Rational c = new Rational(2, -5);
            Rational d = new Rational(5, 0);

            Console.WriteLine(a.ToString());
            b.PrintRational();
            c.PrintRational();

            d = a + b;
            d.PrintRational();

            d = a - b;
            d.PrintRational();

            d = a * b;
            d.PrintRational();

            d = a / b;
            d.PrintRational();

            Rational.TestRational();
        }
    }
}

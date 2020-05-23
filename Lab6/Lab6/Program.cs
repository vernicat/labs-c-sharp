using System;

namespace Lab6
{
    class Program
    {
        class Example
        {
            public int x;
            public int y;
            public Example(int x)
            {
                this.x = x;
            }

            public static void Init(Example a)
            {
                a.x = 1;
                a.y = 1;
                Console.WriteLine("a.x = {0}\ta.y = {1} ", a.x, a.y);

                Example Obj = a;
                Obj.x = 1231;
                Obj.y = 112;
                Console.WriteLine("v.x = {0}\tv.y = {1} ", Obj.x, Obj.y);
            }

            public static void Sqr(double a, double b)
            {
                a = Math.Pow(a, 2);
                b = Math.Pow(b, 2);
                Console.WriteLine("В методе Sqr. a = {0}\tb = {1}", a, b);
            }
        }
        static void Main(string[] args)
        {
            double a = 12.3, b = 2.9;
            Console.WriteLine("a = {0}\tb = {1} ", a, b);

            Example.Sqr(a, b);
            Console.WriteLine("a = {0}\tb = {1} ", a, b);

            Example.Sqr(a * 2, b * 2);
            Console.WriteLine("a = {0}\tb = {1} ", a, b);

            Example Obj = new Example(11);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);

            Example.Init(Obj);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);
        }
    }
}

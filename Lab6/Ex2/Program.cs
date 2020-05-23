using System;

namespace Ex2
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

            public static void Init(ref Example a)
            {
                a.x = 1;
                a.y = 1;
                Console.WriteLine("a.x = {0}\ta.y = {1} ", a.x, a.y);

                Example Obj = a;
                Obj.x = 1231;
                Obj.y = 112;
                Console.WriteLine("v.x = {0}\tv.y = {1} ", Obj.x, Obj.y);
            }

            public static void Sqr(ref double a, ref double b)
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

            Example.Sqr(ref a, ref b);
            Console.WriteLine("a = {0}\tb = {1} ", a, b);

            //Example.Sqr(ref a * 2, ref b * 2); //Значения ref или out должно быть переменной, которой можно присвоить значение

            //Console.WriteLine("a = {0}\tb = {1} ", a, b);

            double c;
            //Example.Sqr(ref a, ref c); //Использование локальной переменной "c", которой не присвоено значение


            Example Obj = new Example(11);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);

            Example.Init(ref Obj);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);
        }
    }
}

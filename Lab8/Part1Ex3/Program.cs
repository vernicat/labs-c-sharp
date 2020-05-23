using System;

namespace List_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte       a = 0;
            Byte        b = 9;
            Int16       c = 7;
            Int32       d = 5;
            Int64       e = 3;
            String      s = "строка";
            Exception   ex = new Exception();
            Object[] types = { a, b, c, d, e, s, ex };
            foreach (object o in types)
                Console.WriteLine($"{o.GetType().IsValueType}");
            Console.WriteLine("\nОпределение типов:\n");
            foreach (object o in types)
                if (o.GetType().IsValueType.ToString() == "True")
                    Console.WriteLine($"{o.GetType()} - значимый");
                else
                    Console.WriteLine($"{o.GetType()} - ссылочный");
        }
    }
}

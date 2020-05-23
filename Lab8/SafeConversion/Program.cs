using System;

namespace SafeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 a     = 1;
            Int32 b     = 2;
            double c    = 3;

            // a = c; double -> short
            // a = b; int -> short

            b = a;
            // b = c; double -> int

            c = a;
            c = b;
        }
    }
}

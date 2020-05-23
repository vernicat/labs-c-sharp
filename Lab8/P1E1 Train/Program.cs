using System;

namespace Train
{
    class Program
    {
        public struct Train
        {
            public string number, message;
            public int count;

            public enum typeTraine : byte { skTrain, pasTrain, tTrain }; //Ex2
            public typeTraine type;  //Ex2

            public Train(string a, string b, int c, int d)
            {
                this.number = a;
                this.message = b;
                this.count = c;
                this.type = (typeTraine)d;  //Ex2
            }

            public override string ToString()
            {
                return "Поезд " + number + " " + message + ".\nКоличество вагонов: " + count + ".\nТип поезда: " + type;
            }
        }
        static void Main(string[] args)
        {
            Train a = new Train("6017", "отправляется с 5 пути", 16, 1);
            Console.WriteLine(a.ToString());
        }
    }
}

using System;

namespace FirmTrain
{
    class Program
    {
        class Train
        {
            public string number, message;
            public int count;

            public Train(string a, string b, int c)
            {
                this.number = a;
                this.message = b;
                this.count = c;
            }

            public override string ToString()
            {
                return "Поезд " + number + " " + message + ".\nКоличество вагонов: " + count + ".";
            }
        }

        class FirmTrain : Train
        {
            public string nameFirm;
            public double kPrice;

            public FirmTrain(string number, string message, int count, string nameFirm, double kPrice) : base(number, message, count)
            {
                this.number = number;
                this.message = message;
                this.count = count;
                this.nameFirm = nameFirm;
                this.kPrice = kPrice;
            }
            public override string ToString()
            {
            return "Поезд " + number + " " + message + ".\nКоличество вагонов: " + count + ".\nНазвание фирменного поезда: " + nameFirm + ".\nКоэффициент удорожания: " + kPrice;
            }
        }

        static void Main(string[] args)
        {
            Train a = new FirmTrain("6017", "отправляется с 5 пути", 16, "РЖД", 2.5);
            Console.WriteLine(a.ToString());
        }
    }
}

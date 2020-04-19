using System;

namespace Lab2
{
    class Program
    {
        public static int kub(int a)
        {
            return a * a * a;
        }

        static void Main()
        {
            //Задание 2.1
            int i, j, kol = 0;
            Console.Write("Введите размернсть шахматной доски: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите x 1ой фигуры: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите y 1ой фигуры: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите x 2ой фигуры: ");
            int k1 = int.Parse(Console.ReadLine());
            Console.Write("Введите y 2ой фигуры: ");
            int m1 = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        kol++;
                        if ((k == i) && (m == j))
                            Console.WriteLine("({0};{1}) черная", k, m);
                    }

                    else
                    {
                        if ((k == i) && (m == j))
                            Console.WriteLine("({0};{1}) белая", k, m);
                    }
                }

            if ((k + m) % 2 == (k1 + m1) % 2)
            {
                if ((k + m) % 2 == 0)
                    Console.WriteLine("({0};{1}) и ({2};{3}) обе черного\n", k, m, k1, m1);
                else
                    Console.WriteLine("({0};{1}) и ({2};{3}) обе белого\n", k, m, k1, m1);
            }
            else
                Console.WriteLine("({0};{1}) и ({2};{3}) разных цветов\n", k, m, k1, m1);

            if (k + 1 == k1 && (m + 1 == m1 || m - 1 == m1))
                Console.WriteLine("Фигуру ({0};{1}) бьет Пешка в ({2};{3})", k, m, k1, m1);
            if ((k + m) % 2 == (k1 + m1) % 2 && Math.Abs(k + m) == Math.Abs(k1 + m1))
                Console.WriteLine("Фигуру ({0};{1}) бьет Слон в ({2};{3})", k, m, k1, m1);
            if (k == k1 || m == m1)
                Console.WriteLine("Фигуру ({0};{1}) бьет Ладья в ({2};{3})", k, m, k1, m1);
            if ((k == k1 || m == m1) || ((k + m) % 2 == (k1 + m1) % 2 && Math.Abs(k + m) == Math.Abs(k1 + m1)))
                Console.WriteLine("Фигуру ({0};{1}) бьет Ферзь в ({2};{3})", k, m, k1, m1);
            if (((k1 + 1 == k || k1 - 1 == k) && (m1 + 2 == m || m1 - 2 == m)) || ((k1 + 2 == k || k1 - 2 == k) && (m1 + 1 == m || m1 - 1 == m)))
                Console.WriteLine("Фигуру ({0};{1}) бьет Конь в ({2};{3})", k, m, k1, m1);
            Console.WriteLine("Кол-во черных ячеек: {0}", kol);

            //Задание 2.2
            //int day, month, year , pros = 0, osta = 0, predd = 0, predm = 0, predy = 0, nexeld = 0, nexelm = 0, nexely = 0;
            //int[] d = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            //Console.WriteLine("Введите день ");
            //day = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите месяц ");
            //month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите год ");
            //year = int.Parse(Console.ReadLine());
            //int m = month;
            //while (m > 0)
            //{
            //    pros += d[m];
            //    m--;
            //}
            //m = month;
            //while (m < 13)
            //{
            //    osta += d[m];
            //    m++;
            //}
            //if(day == 1)
            //{
            //    if (month == 1)
            //    {
            //        predm = 12;
            //        predy = year - 1;
            //        predd = d[predm];
            //    }
            //    else
            //    {
            //        predd = d[month - 1];
            //        predm = month - 1;
            //        predy = year;
            //    }
            //}
            //else
            //{
            //    predd = day -1;
            //    predm = month;
            //    predy = year;
            //}
            //if (day == d[month])
            //{
            //    if (month == 12)
            //    {
            //        nexelm = 1;
            //        nexely = year + 1;
            //        nexeld = 1;
            //    }
            //    else
            //    {
            //        nexeld = 1;
            //        nexelm = month + 1;
            //        nexely = year;
            //    }
            //}
            //else
            //{
            //    nexeld = day + 1;
            //    nexelm = month;
            //    nexely = year;
            //}
            //pros -= d[month] - day;
            //osta -= day; 
            //Console.WriteLine("С начала года прошло {0} дней", pros);
            //Console.WriteLine("До конца года осталось {0} дней", osta);
            //Console.WriteLine("Вчерашняя дата - {0}.{1}.{2}", predd, predm, predy);
            //Console.WriteLine("Завтрашняя дата - {0}.{1}.{2}", nexeld, nexelm, nexely);

            //Задание 2.3
            //Console.WriteLine("Натуральное число из n цифр является числом Армстронга, если сумма его цифр, возведенных в n-ную степень, равна самому числу.\n");
            //int first = 0, second = 0, third = 0 , arms;
            //for (int i = 100; i < 1000; i++)
            //{
            //    // i = 153
            //    first = i % 10; //3
            //    second = (i / 10) % 10; //5
            //    third = (i / 100) % 10; //1
            //    arms = kub(first) + kub(second) + kub(third);
            //    if (arms == i)
            //        Console.WriteLine("{0} - число Армстронага, {1}+{2}+{3}", i, kub(first), kub(second), kub(third));
            //}

            //Задание 2.4
            //int n, m, kmax = 0, kmin = 0, ksred = 0;
            //Console.WriteLine("Введите длину");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите ширину");
            //m = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите сторону квадрата");
            //int d = int.Parse(Console.ReadLine());
            //kmax = m / n;
            //kmin = m * n;
            //Console.WriteLine("В прямоугольник помещается {0} квадратов MAX S", kmax);
            //Console.WriteLine("В прямоугольник помещается {0} квадратов MIN S", kmin);


            //Задание К1 Вариант 3
            //int a = 3;
            //int b = 5;
            //Console.WriteLine("Cреднее арифметическое кубов двух данных чисел: {0:#.###}", (Math.Pow(a, 3) + Math.Pow(b, 3)) / 2);

            //Задание К2 Вариант 3
            //Console.Write("M = ");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("N = ");
            //int n = int.Parse(Console.ReadLine());
            //if (m % n == 0)
            //    Console.WriteLine("{0}", m / n);
            //else
            //    Console.WriteLine("M на N нацело не делится");

            //Задание К4 Вариант 3
            //Console.Write("Введите номер масти ");
            //int n = int.Parse(Console.ReadLine());
            //switch (n - 1)
            //{
            //    case 0:
            //        Console.WriteLine("пики");
            //        break;
            //    case 1:
            //        Console.WriteLine("трефы");
            //        break;
            //    case 2:
            //        Console.WriteLine("бубны");
            //        break;
            //    case 3:
            //        Console.WriteLine("червы");
            //        break;
            //    default:
            //        Console.WriteLine("error");
            //        break;
            //}

            //Задание К5 Вариант 3
            //Console.Write("Введите стоимость = ");
            //double n = double.Parse(Console.ReadLine());
            //double rub = 0;
            //Console.Write("WHILE:\n");
            //int i = 10;
            //while (i <= 100)
            //{
            //    rub = n * i; 
            //    Console.Write("{0} шт. = {1} руб. \n", i, rub);
            //    i += 10;
            //}
            //Console.Write("DO WHILE:\n");
            //i = 10;
            //do
            //{
            //    rub = n * i;
            //    Console.Write("{0} шт. = {1} руб. \n", i, rub);
            //    i += 10;
            //}
            //while (i <= 100);
            //Console.Write("FOR:\n");
            //for (i = 10; i <= 100; i += 10)
            //{
            //    rub = n * i;
            //    Console.Write("{0} шт. = {1} руб. \n", i, rub);
            //}

            //Задание К5 Вариант 3
            //for (int j = 0; j < 5; j++, Console.WriteLine())
            //{
            //    for (int i = -10; i <= 12; i++)
            //        Console.Write("{0}   ", i);
            //}
        }
    }
}

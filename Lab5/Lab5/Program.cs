using System;
using System.Text;

namespace Lab5
{
    class Program
    {
        // Задание 3
        static void SplitJoin(string str)
        {
            string[] SimpleSentences, Words;

            SimpleSentences = str.Split(',');
            Words = str.Split(' ');

            for (int i = 0; i < SimpleSentences.Length; i++)
                Console.WriteLine(SimpleSentences[i]);

            for (int i = 0; i < Words.Length; i++)
                Console.WriteLine(Words[i]);

            Console.WriteLine(string.Join(' ', Words));
        }
        // Задание 4
        static void TestStringBuilder()
        {
            StringBuilder str1 = new StringBuilder("String – example of StringBuilder");
            StringBuilder str2 = new StringBuilder("Строка - пример СтрокоПостроителя");

            for (int i = 0; i < str1.Length; i++)
            {
                str2[i] = str1[i];
            }
            if (str1 != str2)
                Console.WriteLine("Строки НЕ равны");

            Console.WriteLine("Переприсаивание");
            str1 = str2;

            if (str1 == str2)
                Console.WriteLine("Строки равны");
        }
        // Задание 6
        static void PrintCharAr(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        
        static String CharArrayToString(char[] a)
        {
            string c = new string(a);
            return c;
        }
        static int IndexOfStr(string a, string b)
        {
            int index;
            for (int i = 0; i < a.Length; i++)
                if (a[i] == b[0])
                {
                    int ind = 0;
                    int ii = i;
                    index = i;
                    for (int j = 0; j < b.Length; j++)
                        if (a[ii] == b[j])
                        {
                            ind++;
                            ii++;
                        }
                        else continue;
                    if (ind == b.Length) return index;
                }
            return -1;
        }
        static void TestIndexSym(string a, string b)
        {
            int index;
            Console.Write("Строка \"{0}\" ", b);
            for (int i = 0; i < a.Length; i++)
                if (a[i] == b[0])
                {
                    int ind = 0;
                    int ii = i;
                    index = i;
                    for (int j = 0; j < b.Length; j++)
                        if (a[ii] == b[j])
                        {
                            ind++;
                            ii++;
                        }
                        else continue;
                    if (ind == b.Length) Console.Write("начинается с {0} заканчивается {1} ", index, index + ind - 1);
                }
        }

        static void Main()
        {
            // Задание 1
            /*string str1 = "Строка1";
            string str2 = new string('s', 5);
            char[] charray = { 't', 'e', 's', 't' };
            string str3 = new string(charray);
            string str4;

            str4 = str1; // Присваивание

            Console.WriteLine("Равенство");
            if (str4 == str1)
                Console.WriteLine(str4);

            str4 += str2; // Конкатенация

            Console.WriteLine("НЕравенство");
            if (str4 != str1)
                Console.WriteLine(str4);

            Console.WriteLine("Взятие индекса");
            Console.WriteLine(str4[2] + "  " + str4[4] + "  " + str4[6]);

            string  str5 = "Каждый {Охотник} Желает Знать Где  { Сидит} Фазан", 
                    str6 = "";
            int     k = 0;

            Console.WriteLine(str5);
            for (int i = 0; i < str5.Length; i++)
            {
                if (str5[i] == '{' || str5[i] == '}')
                    if (k == 0)
                        k++;
                    else
                        k--;
                if (k != 0 && str5[i] != '{')
                    str6 += str5[i];
            }
            Console.WriteLine(str6);

            string str7 = "", str8 = "";
            str6 = "Все student сидят дома.";
            for (int i = 0; i < str6.Length; i++)
            {
                if (str6[i] == 's' && i + 7 < str6.Length)
                {
                    k = i;
                    for (int l = 0; l < 7; l++)
                    {
                        str8 += str6[k];
                        k++;
                    }
                    if (str8 == "student")
                        i += 7;
                }
                str7 += str6[i];
            }
            Console.WriteLine(str7);*/

            // Задание 2
            /*
            string[]    val =  { " ноль", " один", " два", " три", " четыре", " пять", " шесть", " семь", " восемь", " девять" },
                        decide =   { "", " одинадцать", " двенадцать", " тринадцать", " четырнадцать", " пятнадцать"," шестнадцать", " семнадцать", " восемнадцать"," девятнадцать" },
                        decide1 =   { "", " десять", " двадцать", " тридцать", " сорок", " пятьдесят", " шестьдесят", " семьдесят", " восемьдесят", " девяносто" },
                        hundred =   { "", " сто", " двести", " триста", " четыреста", " пятьсот", " шестьсот", " семьсот", " восемьсот", " девятьсот" },
                        thosand =   { "", "Тысяча", "Две тысячи", "Три тысячи", "Четыре тысячи", "Пять тысяч", "Шесть тысяч", "Семь тысяч", "Восемь тысяч", "Девять тысяч" };

            Console.WriteLine("Входящий параметр");
            int num = int.Parse(Console.ReadLine());
            string str = "";
            if (num / 10 % 10 == 1 & num % 10 != 0)
            {
                str += thosand[num / 1000] + hundred[(num / 100) % 10] + decide[num % 10] + " рублей";
            }
            else
            {
                str += thosand[num / 1000] + hundred[(num / 100) % 10] + decide1[(num / 10) % 10];
                if (num % 10 != 0)
                    str += val[num % 10];
                switch (num % 10)
                {
                    case 1:
                        str += " рубль";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        str += " рубля";
                        break;
                    default:
                        str += " рублей";
                        break;
                }
            }
            Console.Write(str); */

            // Задание 3
            /*string str = "тучка любит дождик,а котик воробья,небо любит солнышко,а я люблю С#";
            SplitJoin(str);*/

            // Задание 4
            /*
            TestStringBuilder();
            int pos = 32;
            StringBuilder str1 = new StringBuilder("Дабвила строку с помощью метода ");
            StringBuilder str2 = new StringBuilder("Вставила строку с помощью метода на позицию "+pos);

            str1.Append("Append"); // добавление
            str2.Insert(pos, " Insert"); // вставка на позицию

            Console.WriteLine(str1);
            Console.WriteLine(str2);


            StringBuilder txtbuild = new StringBuilder();

            int num = 1;
            string[] str = { "тучка любит дождик","а котик воробья","небо любит солнышко","а я люблю С#" };

            foreach (string sub in str)
                txtbuild.AppendFormat(" {0}: {1}\n", num++, sub);
            Console.WriteLine(txtbuild);*/

            // Задание 5
            /*
            StringBuilder str1 = new StringBuilder("Возвращает или устанавливает текущую емкость буфера");
            StringBuilder str2 = new StringBuilder("Возвращает максимальную емкость буфера");

            Console.WriteLine(str1.Capacity);
            Console.WriteLine(str2.MaxCapacity);

            str1.EnsureCapacity(150);   // позволяет уменьшить емкость буфера
            Console.WriteLine(str1.Capacity);*/

            // Задание 6
            //char[] str1 = "Hello, World!";    // ошибка
            /**/char[] str1 = { 'H', 'e', 'l', 'l', 'o', ',', ' ', 'W', 'o', 'r', 'l', 'd', '!' };
            string str2 = "Здравствуй, Мир!";
            PrintCharAr(str1);
            string str3;
            str3 = CharArrayToString(str1); // преобразует массив символов в строку
            Console.WriteLine(str3);

            string s1 = "в стоку входит подстрока";
            string s2 = "подстрока";
            Console.WriteLine(IndexOfStr(s1, s2)); // нахождение строки s2 в s1
            TestIndexSym(s1, s2); // индексы вхождения символов и подстрок в строку
        }
    }
}

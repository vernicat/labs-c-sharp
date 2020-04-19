using System;

namespace Lab4._4
{
    class Program
    {
        class Student
        {
            private string name; // Фамилия
            private int sumb; // Баллы
            private static Random rnd = new Random();

            public static Student[] InitAr(Student[] Stud) // инициализия элементов массива с помощью констуктора по умолчанию Student()
            {
                for (int i = 0; i < Stud.Length; i++)
                {
                    Stud[i] = new Student();
                }
                return Stud;
            }

            public void SetValue(string surname)
            {
                this.name = surname;
                this.sumb = rnd.Next(1, 10);
            }

            public void PrintInfo()
            {
                Console.WriteLine("Имя: {0}. Балл: {1}", this.name, this.sumb);
            }
        }

        static void Main()
        {
            Student[] mas = new Student[3]; // массив объектов Student из трёх элементов с отложенной инициализацией

            for (int i = 0; i < 3; i++)
                Student.InitAr(mas);

            mas[0].SetValue("Екатерина");
            mas[1].SetValue("Владимир");
            mas[2].SetValue("Константин");

            for (int i = 0; i < 3; i++)
                mas[i].PrintInfo();
        }
    }
}

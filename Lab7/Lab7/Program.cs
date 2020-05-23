using System;

namespace Lab7
{
    class Program
    {
        class Person
        {
            private string fam, status, helth;
            private int salary, age;

            public Person()
            {
                // Для строк обязательна инициализация
                this.fam = "";
                this.status = "В отношениях";
                this.helth = "Полностью здоров";
            }

            public string Fam
            {
                set { if (fam == "") fam = value; }
                get { return (fam); }
            }

            public int Age
            {
                set { age = value; }
                get { return (age); }
            }

            public string Status
            {
                get { return (status); }
            }

            public int Salary
            {
                set { salary = value; }
            }

            public int GetSalary()
            {
                return this.salary;
            }

            public string GetHelth()
            {
                return this.helth;
            }
        }

        static void Main(string[] args)
        {
            Person c = new Person
            {
                Fam = "Иванов",
                Salary = 56000,
                Age = 23
        };
            c.Fam = "Петров";
            Console.WriteLine("Фамилия: {0}\nСтатус: {1}\nЗарплата: {2}\nВозраст: {3}\nЗдоровье: {4}", c.Fam, c.Status, c.GetSalary(), c.Age, c.GetHelth());
        }
    }
}

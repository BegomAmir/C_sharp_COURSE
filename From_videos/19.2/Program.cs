using _19._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empoyee> empoyees = new List<Empoyee>()
            {
                new Empoyee(){Num=1,Name="Иванов",Summa=100000, City = "Москва"},
                new Empoyee(){Num=2,Name="Петров",Summa=110000, City = "СПб"},
                new Empoyee(){Num=3,Name="Сидоров",Summa=60000, City = "Сочи"},
                new Empoyee(){Num=4,Name="Кузнецов",Summa=150000, City = "Иркутск"},
                new Empoyee(){Num=5,Name="Васильев",Summa=200000, City = "Москва"},
                new Empoyee(){Num=6,Name="Бендер",Summa=500000, City = "СПб"},
                new Empoyee(){Num=7,Name="Воробьянинов",Summa=90000, City = "Сочи"},
                new Empoyee(){Num=8,Name="Балаганов",Summa=120000, City = "Екатеринбург"}
            };

            //Console.WriteLine("Введите город");
            //string city = Convert.ToString(Console.ReadLine());
            //List<Empoyee> empoyees1 = empoyees.Where(x => x.City == city).ToList();
            //Print(empoyees1);
            //Console.ReadKey();

            //Console.WriteLine("Введите зп");
            //int summa =Convert.ToInt32(Console.ReadLine());
            //List<Empoyee> empoyees2 = empoyees.Where(x => x.Summa >= summa).ToList();
            //Print(empoyees2);
            //Console.ReadKey();

            //List<Empoyee> empoyees3 = empoyees.OrderBy(x=>x.Name).ToList();
            //Print(empoyees3);

            //IEnumerable<IGrouping<string, Empoyee>> empoyees4 = empoyees.GroupBy(x => x.City);
            //foreach(IGrouping<string, Empoyee> gr in empoyees4)
            //{
            //    Console.WriteLine(gr.Key);
            //    foreach(Empoyee e in gr)
            //    {
            //        Console.WriteLine($"{e.Num} {e.Name} {e.Summa} {e.City}");
            //    }
            //}

            //Empoyee empoyee5 = empoyees.OrderByDescending(x=>x.Summa).FirstOrDefault();
            //Console.WriteLine($"{empoyee5.Num} {empoyee5.Name} {empoyee5.Summa} {empoyee5.City}");
            //Console.WriteLine( empoyees.Any(x => x.Summa > 200));

            Console.ReadKey();
        }
        static void Print(List<Empoyee> empoyees)
        {
            foreach(Empoyee e in empoyees) 
            {
                Console.WriteLine($"{e.Num} {e.Name} {e.Summa} {e.City}");
            }
            Console.WriteLine();
        }
    }
}

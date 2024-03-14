using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer{Code=1111, Name = "Acer", TypeOfProc = "Intel i5", Frequency = 2100, VolumeRM = 8, VolumeHM = 1024, VolumeVC = 512, Price = 59999, Amount = 34},
                new Computer{Code=1122, Name = "Asus", TypeOfProc = "Intel i7", Frequency = 3000, VolumeRM = 12, VolumeHM = 512, VolumeVC = 512, Price = 87999, Amount = 67},
                new Computer{Code=1133, Name = "MSI", TypeOfProc = "Intel i9", Frequency = 5000, VolumeRM = 24, VolumeHM = 512, VolumeVC = 512, Price = 119999, Amount = 10},
                new Computer{Code=1144, Name = "Loc", TypeOfProc = "Intel i3", Frequency = 1000, VolumeRM = 4, VolumeHM = 1024, VolumeVC = 512, Price = 39999, Amount = 5},
                new Computer{Code=1155, Name = "Asus", TypeOfProc = "Intel i5", Frequency = 2100, VolumeRM = 12, VolumeHM = 2048, VolumeVC = 512, Price = 69999, Amount = 11},
                new Computer{Code=1166, Name = "Acer", TypeOfProc = "Intel i7", Frequency = 3000, VolumeRM = 12, VolumeHM = 1024, VolumeVC = 512, Price = 79999, Amount = 9},
            };

            Console.WriteLine("Введите интересующий Вас процессор");
            string typeOfProc = Console.ReadLine();
            List<Computer> computers1 = (from c in computers
                                         where c.TypeOfProc == typeOfProc
                                         select c).ToList();

            Console.WriteLine("Введите необходимый ОЗУ");
            int volumeRC = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers1 = (from c in computers
                                         where c.VolumeRM >= volumeRC
                                         select c).ToList();

            List<Computer> computers1 = computers.OrderBy(x => x.Price).ToList();
            Print(computers1);

            IEnumerable<IGrouping<string, Computer>> computers2 = computers.GroupBy(x => x.TypeOfProc);
            foreach (IGrouping<string, Computer> gr in computers2)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer c in gr)
                {
                    Console.WriteLine($"{c.Code} {c.Name} {c.TypeOfProc} {c.Frequency} {c.VolumeRM} {c.VolumeHM} {c.VolumeVC} {c.Price} {c.Amount}");

                }
            }

            foreach (Computer c in computers1)
            {
                Console.WriteLine($"{c.Code} {c.Name} {c.TypeOfProc} {c.Frequency} {c.VolumeRM} {c.VolumeHM} {c.VolumeVC} {c.Price} {c.Amount}");
            }

            Computer c = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Computer c1 = computers.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"Самый дорогой:{c.Code}   {c.Name}   {c.TypeOfProc}   {c.Frequency}   {c.VolumeRM}   {c.VolumeHM}   {c.VolumeVC}   {c.Price}   {c.Amount}");
            Console.WriteLine($"Самый дешевый:{c1.Code}   {c1.Name}   {c1.TypeOfProc}   {c1.Frequency}   {c1.VolumeRM}   {c1.VolumeHM}   {c1.VolumeVC}   {c1.Price}   {c1.Amount}");

            Console.WriteLine(computers.Any(x => x.Amount > 30));

            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"{c.Code} {c.Name} {c.TypeOfProc} {c.Frequency} {c.VolumeRM} {c.VolumeHM} {c.VolumeVC} {c.Price} {c.Amount}");
            }
            Console.WriteLine();
        }
    }
}

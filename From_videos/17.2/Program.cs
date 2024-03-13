using _16._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите числовой номер");
            //int numInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите имя");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("Введите зп");
            //int summa1 = Convert.ToInt32(Console.ReadLine());

            //Empoyee<int> empoyee1 = new Empoyee<int>(numInt, name1, summa1);
            //Console.WriteLine("Введите строковый номер");
            //string numString = Console.ReadLine(); ;
            //Console.WriteLine("Введите имя");
            //string name2 = Console.ReadLine();
            //Console.WriteLine("Введите зп");
            //int summa2 = Convert.ToInt32(Console.ReadLine());
            //Empoyee<string> empoyee2 = new Empoyee<string>(numString, name2, summa2);
            //Console.WriteLine(empoyee1.GetInfo());
            //Console.ReadKey();

            Empoyee<int> empoyee1 = new Empoyee<int>();
            empoyee1.Input();
            Console.WriteLine(empoyee1.GetInfo());

            Empoyee<string> empoyee2 = new Empoyee<string>();
            empoyee2.Input();
            Console.WriteLine(empoyee2.GetInfo());

            Console.ReadKey();  

        }
    }
}

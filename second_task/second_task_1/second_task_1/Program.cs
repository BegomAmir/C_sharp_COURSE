using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину окружности");
            double L = Convert.ToDouble(Console.ReadLine());
            double r = L / 2;
            Console.WriteLine(r);
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите C");
            double C = Convert.ToDouble(Console.ReadLine());
            int x = 0;
            double t = B;
            while (C <= A)
            {
                while (C <= B)
                {
                    x++;
                    B = B - C;
                }
                A = A - C;
                B = t;
            }
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}

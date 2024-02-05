using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void getCube(double a, out double s, out double v)
        {
            s = 6 * a * a;
            v = a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());    
            double s, v;
            getCube(a, out s, out v);
            Console.WriteLine("Площадь поверхности равна {0:.000}, а объём равен {1:.000}", s, v);
            Console.ReadKey();

        }
    }
}

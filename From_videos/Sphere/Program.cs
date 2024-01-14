using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            double v = ((double)4) / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}

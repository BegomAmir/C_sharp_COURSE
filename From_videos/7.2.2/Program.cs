using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2
{
    internal class Program
    {
        static void getParamsSphere(double r, out double s, out double v)
        {
            s = 4 * Math.PI * r * r;
            v = 4.0 / 3 * Math.PI * r * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            getParamsSphere(r, out s, out v);
            Console.WriteLine("{0:.000} {1:.000}", s,v);
            Console.ReadKey();


        }
    }
}

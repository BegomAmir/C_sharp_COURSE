using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1
{
    internal class Program
    {
        static double getHypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите катеты первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = getHypotenuse(x1,y1);
            Console.WriteLine("Введите катеты второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = getHypotenuse(x2, y2);

            if (z1 > z2)
                Console.WriteLine("Гипотегнуза первого треугольника больше");
            else
                if (z1 < z2)
                Console.WriteLine("Гипотегнуза второго треугольника больше");
            else
                Console.WriteLine("Гипотенузы равны");
            Console.ReadKey();
        }
    }
}

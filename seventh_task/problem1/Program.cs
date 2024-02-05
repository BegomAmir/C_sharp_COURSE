using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        static double ohMySquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите величины сторон первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double Sx = ohMySquare(x1, x2, x3);
            Console.WriteLine("Введите величины сторон второго треугольника");
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double Sy = ohMySquare(y1, y2, y3);
            if (Sx > Sy)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if (Sx < Sy)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }
            Console.ReadKey();
        }
    }
}

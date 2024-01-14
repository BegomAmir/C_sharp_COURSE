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
            Console.WriteLine("Введите координаты первой вершины");
            double Ax = Convert.ToDouble(Console.ReadLine());
            double Ay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины");
            double Bx = Convert.ToDouble(Console.ReadLine());
            double By = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины");
            double Cx = Convert.ToDouble(Console.ReadLine());
            double Cy = Convert.ToDouble(Console.ReadLine());
            double a = Math.Sqrt((Math.Pow(Math.Abs(Bx - Ax), 2) + (Math.Pow(Math.Abs(By - Ay), 2))));
            double b = Math.Sqrt((Math.Pow(Math.Abs(Cx - Bx), 2) + (Math.Pow(Math.Abs(Cy - By), 2))));
            double c = Math.Sqrt((Math.Pow(Math.Abs(Ax - Cx), 2) + (Math.Pow(Math.Abs(Ay - Cy), 2))));
            double P = a + b + c;
            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Периметр треугольника равен {0}", P);
            Console.WriteLine("Площадь треугольника равна {0}", S);
            Console.ReadKey();
        }
    }
}

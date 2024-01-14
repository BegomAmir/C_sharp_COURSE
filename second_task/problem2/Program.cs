using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
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
            double P = 2 * Math.Abs(Bx - Ax) + 2 * Math.Abs(By - Ay);
            double S = Math.Abs(Bx - Ax) * Math.Abs(By - Ay);
            Console.WriteLine("Периметр прямоугольника равен {0}", P);
            Console.WriteLine("Площадь прямоугольника равна {0}", S);
            Console.ReadKey();
        }
    }
}

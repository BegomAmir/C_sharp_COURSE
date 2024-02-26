using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double square = Rectangle.getSquare(a, b);
            double perimetr = Rectangle.getPerimetr(a, b);
            Console.WriteLine($"{square} \n{perimetr}");
            Console.ReadKey();
        }
    }
}

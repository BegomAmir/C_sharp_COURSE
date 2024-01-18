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
            Console.WriteLine("Введите координату точки A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки B");
            int B = Convert.ToInt32(Console.ReadLine()); 
            string b = "B";
            Console.WriteLine("Введите координату точки C");
            string c = "C";
            int C = Convert.ToInt32(Console.ReadLine());
            int x1, x2;
            x1 = Math.Abs(B - A);
            x2 = Math.Abs(C - A);
            if (x1 > x2)
            {
                Console.WriteLine("Ближайшая точка к A это точка {0} и расстояние между ними равно {1}", c, x2);
            }
            else if (x2 > x1)
            {
                Console.WriteLine("Ближайшая точка к A это точка {0} и расстояние между ними равно {1}", b, x1);
            }
            else
            {
                Console.WriteLine("Точки B и C равноудалены от точки A");
            }
            Console.ReadKey();  

        }
        
    }
}

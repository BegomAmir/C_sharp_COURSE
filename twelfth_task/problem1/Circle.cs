using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    static class Circle
    {
        static public double getLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double getSquare(double r)
        {
            return Math.PI * r * r;
        }
        static public void checkCoordinate(double x, double y, double r, double x0, double y0)
        {
            if (x0 + r >= x && y0 + r >= y)
            {
                 Console.WriteLine("Точка принадлежит окружности");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит окружности");
            }   
             
        }
    }
}

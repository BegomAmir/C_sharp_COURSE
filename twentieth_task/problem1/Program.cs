using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate my = Length;
            my += Square;
            my += Volume;
            my(r);
            Console.ReadKey();


        }
        static double Length(double r)
        {
            double D = 2 * Math.PI * r;
            Console.WriteLine(D);
            return D;
        }
        static double Square(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(S);
            return S;
        }
        static double Volume(double r)
        {
            double V = Math.PI * Math.Pow(r, 3) * 4 / 3;
            Console.WriteLine(V);
            return V;
        }
    }
}

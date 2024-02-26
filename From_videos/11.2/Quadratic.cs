using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2
{
    struct Quadratic
    {
        double a;
        double b;
        double c;

        public Quadratic(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string Root()
        {
            double d2 = b * b - 4 * a * c;
            if (d2 < 0)
                return "Решений нет";
            double r1 = (-b + Math.Sqrt(d2)) / (2 * a);
            double r2 = (-b - Math.Sqrt(d2)) / (2 * a);
            return $"Первое решение - {r1} \nВторое решение - {r2}";
        }
    }
}

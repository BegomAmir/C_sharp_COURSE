using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    struct linear
    {
        double k;
        double b;

        public linear(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (k == 0)
                return "Решений нет";
            double x = -b / k;
            return $"{x} является решением уравнения";
        }
    }
}

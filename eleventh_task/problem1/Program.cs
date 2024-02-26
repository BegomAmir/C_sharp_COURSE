using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты уравнения");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            linear linear = new linear(k,b);
            Console.WriteLine(linear.Root());
            Console.ReadKey();

        }
    }
}

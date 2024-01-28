using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            double M = ((n * (Math.Pow(n, 2) + 1)) / 2); /*магическая константа*/
            int[,] array = new int[n,n];
            double t = 0.0;
            Console.WriteLine("Введите числа");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array [i,j] = Convert.ToInt32(Console.ReadLine());
                    t += array[i, j];
                }
            }
            if ((M*n) == t) /*Свойство магического квадрата*/
            {
                Console.WriteLine("Квадрат является магическим");
            }
            else
            {
                Console.WriteLine("Квадрат не является магическим");
            }
            Console.ReadKey();
        }
    }
}

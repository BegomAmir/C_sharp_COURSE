using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 2 * i - 1;
                Console.WriteLine(s);
            }
            Console.WriteLine("Квадрат числа равен {0}", s);
            Console.ReadKey();
        }
    }
}

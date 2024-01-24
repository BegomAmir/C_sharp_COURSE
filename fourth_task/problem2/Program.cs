using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            int p = 0;
            int q = 0;
            do
            {
                t = 0;
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    p++;
                }
                else if (n < 0)
                {
                    q++;

                }
                else
                {
                    continue;
                }
                t = n;
            } while (t != 0);
            if (q > p)
            {
                Console.WriteLine("Отрицательных чисел больше");
            }
            else if (p > q)
            {
                Console.WriteLine("Положительных чисел больше");
            }
            else
            {
                Console.WriteLine("Количество положительных и отрицательных чисел одинаково");
            }
            Console.ReadKey();
        }  
    }
}

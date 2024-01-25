using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int s = 0;
            int t = 0;
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    s += array[i];
                    t++;
                }
            }
            Console.WriteLine(((double)s)/t);
            Console.ReadKey();
        }
    }
}

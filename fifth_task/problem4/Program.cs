using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int x = 0;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0 && array[i] >= 0 && array[i] % 2 == 1)
                {
                    x++;
                }
            }
            Console.WriteLine("Количество элементов равно {0}", x);
            Console.ReadKey();
        }
    }
}
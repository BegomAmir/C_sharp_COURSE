using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int Max = array[0];
            int Min = array[0];
            foreach (int a in array)
            {
                if (a > Max)
                {
                    Max = a;
                }
            }
            foreach (int b in array)
            {
                if (b < Min)
                {
                    Min = b;
                }
            }
            int Sum = Max + Min;
            Console.WriteLine("Наибольший член равен {0}", Max);
            Console.WriteLine("Наименьший член равен {0}", Min);    
            Console.WriteLine("Сумма равна {0}", Sum);
            Console.ReadKey();
        }
    }
}

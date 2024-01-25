using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FindArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int Max = array[0];
            foreach (int a in array)
            {
                if (a > Max)
                    Max = a;
            }
            Console.WriteLine(Max);
            Console.ReadKey();
        }
    }
}

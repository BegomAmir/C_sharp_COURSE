using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\8.1.1\pomp.txt";
            Random random = new Random();
            using(StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i <10; i++)
                {
                    sw.WriteLine(random.Next(-100,100));
                }
            }
            int k = 0;
            using(StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i<10; i++)
                {
                    k += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}

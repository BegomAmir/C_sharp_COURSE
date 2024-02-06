using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\8.1.1\8.1.2.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }
            }
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Convert.ToInt32(sr.ReadLine()) > 0)
                    {
                        k++;
                    }

                }
            }
            Console.WriteLine(k);
            Console.ReadKey();  
        }
    }
}

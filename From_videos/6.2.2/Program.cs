using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
            string str = Console.ReadLine();
            string str2 = "";
            foreach (char c in str) 
            {
                str2 = c + str2;
            }
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}

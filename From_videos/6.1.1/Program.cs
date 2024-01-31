using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16"); /*Прочитал на хабре, что в вс 2022 года кодировки 
                                                                                 не совпадают, с помощью этой команды все решилось*/ 

            string str = Console.ReadLine();
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            string[] strArray = str.Split();
            string min = strArray[0];
            foreach (string s in strArray)
            {
                if (s.Length < min.Length )
                {
                    min = s;
                }
                
            }
            Console.WriteLine(min);
            Console.ReadKey();  
        }
    }
}

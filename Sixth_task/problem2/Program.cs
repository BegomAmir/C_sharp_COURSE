using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string str2 = string.Join("", strArray);
            str2 = str2.ToLower();
            string str3 = "";
            foreach (char c in str)
            {
                str3 = c + str3;
            }
            string[] strArray1 = str3.Split();
            string str4 = string.Join("", strArray1);
            str4 = str4.ToLower();
            if (str2 == str4)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.ReadKey();  
        }
    }
}

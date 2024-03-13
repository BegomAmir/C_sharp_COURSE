using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _17._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Apartment<int, int> apartment1 = new Apartment<int, int>();
            //apartment1.Num = 1;

            //Apartment<string, int> apartment2 = new Apartment<string, int>();
            //apartment2.Num = "01";
            print<int>(12);
            print<string>("hello!");
            Console.ReadKey();
        }
        static void print<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
    //class Apartment<T, U>
    //{
    //    public U Level { get; set; }
    //    public T Num { get; set; }
    //}
}

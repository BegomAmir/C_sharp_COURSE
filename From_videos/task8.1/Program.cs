using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2/Log.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Старт программы");
                sw.WriteLine("Ошибка");
            } 
            using(StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}

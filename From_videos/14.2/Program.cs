using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Антоновка", "Кислый", "Россия");
            apple.showInfo();
            Console.ReadKey();
        }
    }
}

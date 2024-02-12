using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat;
            cat.name = "Мурка";
            cat.color = "Черный";
            cat.age = 1;
            cat.Say();
        }
        struct Cat
        {
            public string name;
            public string color;
            public int age;
            public void Say()
            {
                Console.WriteLine("Мяу");
            }
        }
    }
}

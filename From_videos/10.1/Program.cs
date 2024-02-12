using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using video11;

namespace _10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "черный", 1);
            cat.Say();
            Console.ReadKey();
        }

    }
}

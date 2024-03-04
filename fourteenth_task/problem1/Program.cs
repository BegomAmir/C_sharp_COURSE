using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Муся");
            Dog dog = new Dog("Жучка");
            dog.ShowInfo();
            cat.ShowInfo();
            Console.ReadKey();
        }
    }
}

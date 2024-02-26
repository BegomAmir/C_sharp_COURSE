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
            Circle.checkCoordinate(3,4,10,0,0);
            Console.WriteLine(Circle.getLength(10));
            Console.WriteLine(Circle.getSquare(10));
            Console.ReadKey();
        }
    }
}

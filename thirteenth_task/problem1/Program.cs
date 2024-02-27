using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул. Маяковского, д. 12", 100, 100, 30);
            MultiBuilding multiBuilding = new MultiBuilding("ул. Маяковского, д. 12", 300, 100, 30, 9);
            Console.WriteLine(building.Print());
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}

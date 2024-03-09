using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AChiper achiper = new AChiper();
            Console.WriteLine(achiper.Encode("ABC123 XYZ"));
            BChiper bchiper = new BChiper();
            Console.WriteLine(bchiper.Encode("ABC123 XYZ"));
            Console.ReadKey();
        }
    }
}

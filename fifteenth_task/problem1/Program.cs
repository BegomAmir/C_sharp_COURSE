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
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(2);
            arithProgression.setStep(3);
            Console.WriteLine(arithProgression.getNext());
            arithProgression.Reset();
            GeomProgression ge = new GeomProgression();
            ge.setStart(2);
            ge.setStep(3);
            Console.WriteLine(ge.getNext());
            Console.ReadKey();
            
        }
    }
   
}

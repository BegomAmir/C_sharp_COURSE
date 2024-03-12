using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace _16._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Empoyees.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Empoyee[] empoyees = JsonSerializer.Deserialize < Empoyee[]>(jsonString);
            
            Empoyee maxEmpoyee = empoyees[0];
            foreach(Empoyee e in empoyees)
            {
                if (e.Summa > maxEmpoyee.Summa)
                {
                    maxEmpoyee = e;
                }
            }
            Console.WriteLine($"{maxEmpoyee.Num} {maxEmpoyee.Name} { maxEmpoyee.Summa}");
            Console.ReadKey();
        }
    }
}

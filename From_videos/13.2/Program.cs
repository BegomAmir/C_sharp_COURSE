using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("Иванов", 2000, "Москва");
            Console.WriteLine(man.Print());
            Student student = new Student("Петров", 1990, "СПб", "ИТМО");
            Console.WriteLine(student.Print());
            Console.ReadKey();
        }
    }
}

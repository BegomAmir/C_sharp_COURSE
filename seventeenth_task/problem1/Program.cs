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
            BankAccount<int> account1 = new BankAccount<int>();
            account1.Input();
            account1.Output();
            BankAccount<string> account2 = new BankAccount<string>();
            account2.Input();
            account2.Output();
            Console.ReadKey();
        }
    }
}

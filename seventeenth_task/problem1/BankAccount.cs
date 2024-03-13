using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class BankAccount <T>
    {
        T AccountId {  get; set; }
        int Balance { get; set; }
        string Name { get; set; }
        public void Input()
        {
            Console.WriteLine("Введите номер аккаунта");
            AccountId = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите уровень баланса");
            Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите имя владельца");
            Name = Console.ReadLine();  
        }
        public void Output()
        {
            Console.WriteLine($"{AccountId} {Name} {Balance}");
        }
    }
}

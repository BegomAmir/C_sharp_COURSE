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
            Console.WriteLine("Введите числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер операции, которую нужно совершить: \n 1 - сложение \n 2 - вычитание \n 3 - умножение \n 4 - деление");
            int k = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (k)
                {
                    case 1:
                        Console.WriteLine(a + b);
                        break;
                    case 2:
                        Console.WriteLine(a - b);
                        break;
                    case 3:
                        Console.WriteLine(a * b);
                        break;
                    case 4:
                        Console.WriteLine(a / b);
                        break;
                    default:
                        Console.WriteLine("Введите корректное число");
                        break;
                }
            }   
            catch (DivideByZeroException)  when (a==0 && b == 0 && k==4)
            {
                Console.WriteLine("Деление 0 на 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}

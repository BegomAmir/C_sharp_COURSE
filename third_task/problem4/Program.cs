using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100 до 999");
            int number = Convert.ToInt32(Console.ReadLine());
            int xNumber = number / 100;
            string x = "";
            int yNumber = (number / 10) % 10;
            string y = "";
            int zNumber = (number % 100) % 10;
            string z = "";
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Введено некорректное число");
            }
            else
            {
                switch (xNumber)
                {
                    case 1:
                        x = "Сто";
                        break;
                    case 2:
                        x = "Двести";
                        break;
                    case 3:
                        x = "Триста";
                        break;
                    case 4:
                        x = "Четыреста";
                        break;
                    case 5:
                        x = "Пятьсот";
                        break;
                    case 6:
                        x = "Шестьсот";
                        break;
                    case 7:
                        x = "Семьсот";
                        break;
                    case 8:
                        x = "Восемьсот";
                        break;
                    case 9:
                        x = "Девятьсот";
                        break;
                    default:
                        Console.WriteLine("Введено некорректное число");
                        break;
                }
                switch (yNumber)
                {
                    case 1:
                        break;
                    case 2:
                        y = "двадцать";
                        break;
                    case 3:
                        y = "тридцать";
                        break;
                    case 4:
                        y = "сорок";
                        break;
                    case 5:
                        y = "пятьдесят";
                        break;
                    case 6:
                        y = "шестьдесят";
                        break;
                    case 7:
                        y = "семьдесят";
                        break;
                    case 8:
                        y = "восемьдесят";
                        break;
                    case 9:
                        y = "девяносто";
                        break;
                    default:
                        break;

                }
                switch (zNumber)
                {
                    case 1:
                        z = "один";
                        break;
                    case 2:
                        z = "два";
                        break;
                    case 3:
                        z = "три";
                        break;
                    case 4:
                        z = "четыре";
                        break;
                    case 5:
                        z = "пять";
                        break;
                    case 6:
                        z = "шесть";
                        break;
                    case 7:
                        z = "семь";
                        break;
                    case 8:
                        z = "восемь";
                        break;
                    case 9:
                        z = "девять";
                        break;
                    default : 
                        break;
                        
                }
                if (yNumber == 1 && zNumber == 0)
                {
                    Console.WriteLine("{0} - {1} десять", number, x);
                }
                else if (yNumber == 1 && zNumber == 1)
                {
                    Console.WriteLine("{0} - {1} одиннадцать", number, x);
                }
                else if (yNumber == 1 && zNumber == 2)
                {
                    Console.WriteLine("{0} - {1} двенадцать", number, x);
                }
                else if (yNumber == 1 && zNumber == 3)
                {
                    Console.WriteLine("{0} - {1} тринадцать", number, x);
                }
                else if (yNumber == 1 && zNumber == 4)
                {
                    Console.WriteLine("{0} - {1} четырнадцать", number, x);
                }
                else if (yNumber == 1 && zNumber == 5)
                {
                    Console.WriteLine("{0} - {1} пятнадцать", number, x);
                }
                else if (yNumber == 1 && zNumber == 6)
                {
                    Console.WriteLine("{0} - {1} шестнадцать", number, x);
                }
                else if (yNumber == 1 && zNumber == 7)
                {
                    Console.WriteLine("{0} - {1} семнадцать", number, x);
                }
                else if (yNumber == 1 && zNumber == 8)
                {
                    Console.WriteLine("{0} - {1} восемнадцать", number, x);
                }
                else if (yNumber == 1 && zNumber == 9)
                {
                    Console.WriteLine("{0} - {1} девятнадцать", number, x);
                }
                else
                {
                    Console.WriteLine("{0} - {1} {2} {3}", number, x, y, z);
                }
            }
            Console.ReadKey();
        }
    }
}

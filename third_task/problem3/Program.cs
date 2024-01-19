using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 20 до 69");
            int x = Convert.ToInt32(Console.ReadLine());
            int n = x % 10;
            int t = x / 10;
            string s = " ";
            switch (n)
            {
                case 1:
                    s = "один";
                    break;
                case 2:
                    s = "два";
                    break;
                case 3:
                    s = "три";
                    break;
                case 4:
                    s = "четыре";
                    break;
                case 5:
                    s = "пять";
                    break;
                case 6:
                    s = "шесть";
                    break;
                case 7:
                    s = "семь";
                    break;
                case 8:
                    s = "восемь";
                    break;
                case 9:
                    s = "девять";
                    break;
                default:
                    break;
            }
            if (x < 20 || x > 69)
            {
                Console.WriteLine("Введено некорректное число");
            }
            else
            {
                switch (t)
                {
                    case 2:
                        switch (n)
                        {
                            case 0:
                                Console.WriteLine("{0} - двадцать лет", x);
                                break;
                            case 1:
                                Console.WriteLine("{0} - двадцать {1} год", x, s);
                                break;
                            case 2:
                            case 3:
                            case 4:
                                Console.WriteLine("{0} - двадцать {1} года", x, s);
                                break;
                            default:
                                Console.WriteLine("{0} - двадцать {1} лет", x, s);
                                break;

                        }
                        break;
                    case 3:
                        switch (n)
                        {
                            case 0:
                                Console.WriteLine("{0} - тридцать лет", x);
                                break;
                            case 1:
                                Console.WriteLine("{0} - тридцать {1} год", x, s);
                                break;
                            case 2:
                            case 3:
                            case 4:
                                Console.WriteLine("{0} - тридцать {1} года", x, s);
                                break;
                            default:
                                Console.WriteLine("{0} - тридцать {1} лет", x, s);
                                break;

                        }
                        break;
                    case 4:
                        switch (n)
                        {
                            case 0:
                                Console.WriteLine("{0} - сорок лет", x);
                                break;
                            case 1:
                                Console.WriteLine("{0} - сорок {1} год", x, s);
                                break;
                            case 2:
                            case 3:
                            case 4:
                                Console.WriteLine("{0} - сорок {1} года", x, s);
                                break;
                            default:
                                Console.WriteLine("{0} - сорок {1} лет", x, s);
                                break;
                        }
                        break;
                    case 5:
                        switch (n)
                        {
                            case 0:
                                Console.WriteLine("{0} - пятьдесят лет", x);
                                break;
                            case 1:
                                Console.WriteLine("{0} - пятьдесят {1} год", x, s);
                                break;
                            case 2:
                            case 3:
                            case 4:
                                Console.WriteLine("{0} - пятьдесят {1} года", x, s);
                                break;
                            default:
                                Console.WriteLine("{0} - пятьдесят {1} лет", x, s);
                                break;
                        }
                        break;
                    case 6:
                        switch (n)
                        {
                            case 0:
                                Console.WriteLine("{0} - шестьдесят лет", x);
                                break;
                            case 1:
                                Console.WriteLine("{0} - шестьдесят {1} год", x, s);
                                break;
                            case 2:
                            case 3:
                            case 4:
                                Console.WriteLine("{0} - шестьдесят {1} года", x, s);
                                break;
                            default:
                                Console.WriteLine("{0} - шестьдесят {1} лет", x, s);
                                break;
                        }
                        break;



                }

            }
            Console.ReadKey();  
        }
    }
}


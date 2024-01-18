using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            Console.WriteLine("Введите первую координату");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую координату");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третью координату");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4, y4;
            if ((x1 + x2 + x3 + y1 + y2 + y3) % 2 != 0 && (x1 + x2 + x3 + y1 + y2 + y3) % 2 != 1)
            {
                Console.WriteLine("Введены нецелочисленные координаты");
            }
            else
            {
                if ((x1 == x2 && y1 == y2)||(x2 == x3 && y2 == y3)||(x3 == x1 && y3 ==y1))
                {
                    Console.WriteLine("Невозможно вывести прямоугольник: точки совпадают");
                }
                else
                {
                    if (y1 == y2)
                    {
                        if (x1 == x3)
                        {
                            x4 = x2;
                            y4 = y3;
                            Console.WriteLine("Координаты четвертой вершины равны {0} и {1}", x4, y4 );
                        }
                        else
                        {
                            x4 = x1;
                            y4 = y3;
                            Console.WriteLine("Координаты четвертой вершины равны {0} и {1}", x4, y4);
                        }
                    }
                    else if (y2 == y3)
                    {
                        if (x2 == x1)
                        {
                            x4 = x3;
                            y4 = y1;
                            Console.WriteLine("Координаты четвертой вершины равны {0} и {1}", x4, y4);
                        }
                        else
                        {
                            y4 = y1;
                            x4 = x1;
                            Console.WriteLine("Координаты четвертой вершины равны {0} и {1}", x4, y4);
                        }
                    }
                    else if (y3 == y1)
                    {
                        if (x3 == x2)
                        {
                            x4 = x1;
                            y4 = y2;
                            Console.WriteLine("Координаты четвертой вершины равны {0} и {1}", x4, y4);
                        }   
                        else
                        {
                            y4 = y2;
                            x4 = x3;
                            Console.WriteLine("Координаты четвертой вершины равны {0} и {1}", x4, y4);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Прямоугольник не будет со сторонами, которые параллельны осям координат");
                    }
                }
            }
            Console.ReadKey();
        } 
    }
}
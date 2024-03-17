using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Configuration;

namespace problem1
{
    internal class Program
    {
        const int n = 3;
        const int m = 4;
        const int k = -1;
        const int l = -2;
        public static int[,] garden = new int[n, m] { { 20, 5, 10,5 },
                                               { 20, 3, 13,6 },
                                               { 96, 7, 8 ,15}};
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Gardner2();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{garden[i, j]} ");
                }
            }
            Console.ReadKey();
        }
        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (garden[i, j] >= 0)
                    {
                        int delay = garden[i, j];
                        garden[i, j] = k;
                        Thread.Sleep(delay);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        static void Gardner2()
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    if (garden[i, j] >= 0)
                    {
                        int delay = garden[i, j];
                        garden[i, j] = l;
                        Thread.Sleep(delay);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}

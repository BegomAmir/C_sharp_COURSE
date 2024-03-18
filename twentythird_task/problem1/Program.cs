using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            SumAsync(n);
            Console.ReadKey();
        }
        static void Multiply(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            Console.WriteLine(s);

        }
        static async void SumAsync(int n)
        {
            await Task.Run(() => Multiply(n));
        }
    }
}

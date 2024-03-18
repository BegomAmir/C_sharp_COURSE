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
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);

            Func<Task<int[]>, int[]> func2 = new Func<Task<int[]>, int[]>(GetSum);

            Task<int[]> task2 = task1.ContinueWith<int[]>(func2);

            Action<Task<int[]>> action = new Action<Task<int[]>>(PrintArray);
            Task task3 = task2.ContinueWith(action);
            //Action < Task<int[]>> action1 = new Action<Task<int[]>>(PrintFirstArray);
            //Task task4 = task3.ContinueWith((Action<Task>)action1);
            task1.Start();

            Console.ReadKey();
        }
        static int[] GetArray(object a)
        {
            int n = (int)a;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
            }
            return array;
        }
        static int[] GetSum(Task<int[]> task)
        {
            int[] array = task.Result;
            int[] mass = new int[2];
            int t = 0;
            int maxValue = array.Max();
            for (int i = 0;i < array.Count(); i++)
            {
                t += array[i];
            }
            mass[0] = maxValue;
            mass[1] = t;
            return mass;
        }
        static void PrintArray(Task<int[]> task)
        {
            int[] array = task.Result;
            for (int i = 0; i < array.Count(); i++)
            {
                Console.WriteLine($"\n{array[i]}");
            }
        }
        //static void PrintFirstArray(Task<int[]> task1)
        //{
        //    int[] array = task1.Result;
        //    foreach (int q in array)
        //    {
        //        Console.WriteLine($"{array[q]} ");
        //    }
        //}
    }
}

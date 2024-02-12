using System;
using System.Collections.Generic;
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
            Angle angle;
            int i = 0;

            Console.WriteLine("Введите градусы, минуты, секунды по порядку");
            do
            {
                if (i > 0)
                {
                    Console.WriteLine("Данные неверны, введите еще раз");
                }
                i++;
                int gradus = Convert.ToInt32(Console.ReadLine());
                int min = Convert.ToInt32(Console.ReadLine());
                int sec = Convert.ToInt32(Console.ReadLine());
                 
                angle = new Angle(gradus, min, sec);

            } while (angle.isCorrect == false);
            double radianAngle = angle.ToRadian();
            Console.WriteLine("{0} - угол в радианах", radianAngle);
            Console.ReadKey();
        }
    }
}

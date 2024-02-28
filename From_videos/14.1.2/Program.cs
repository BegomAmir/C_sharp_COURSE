using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    abstract class Figure
    {
        public abstract double getArea();
        public abstract double getPerimeter();
        public abstract string Name { get; set; }
    }
    class Rectangular : Figure
    {
        string name;
        public double Width { get; set; }
        public double Height { get; set; }

        public override double getArea()
        {
            return Width * Height;
        }

        public override double getPerimeter()
        {
            return 2 * (Width + Height);
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}

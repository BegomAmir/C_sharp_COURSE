using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Building
    {
        string adress { get; set; }
        int length;
        int width;
        int height;
        public Building(string adress, int length, int width, int height)
        {
            this.adress = adress;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Некорректная величина длины");
                else
                    length = value;
            }
        }
        int Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Некорректная величина ширины");
                else
                    width = value;
            }
        }
        int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Некорректная величина высоты");
                else
                    height = value;
            }
        }
        public string Print()
        {
            return $"{adress}, длина здания - {length} метров, ширина здания - {width} метров, высота здания - {height} метров.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _14._2
{
    abstract class Fruit
    {
        public abstract string Name { get; set; }
        public Fruit(string name)
        {
            Name = name;
        }
        public abstract void getTaste();
        public void showInfo()
        {
            Console.WriteLine(Name);
            getTaste();
        }
    }
    class Apple : Fruit
    {
        string country;
        string taste;
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Apple(string name, string taste, string country)
            : base(name)
        {
            this.taste = taste;
            this.country = country;
        }
        public override void getTaste()
        {
            Console.WriteLine(taste);
            Console.WriteLine(country);
        }
    }
    class Lemon : Fruit
    {
        int level;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Lemon(string name, int level)
            : base(name)
        {
            this.level = level;
        }
        public override void getTaste()
        {
            Console.WriteLine("Кислый");
            Console.WriteLine(level);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    abstract class Animal
    {
        public abstract string Name { get; set; }  
        public Animal(string name) 
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Dog : Animal
    {
        string name;
        public override string Name { get => name; set => name=value;}
        public Dog(string name)
            : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
    class Cat : Animal
    {
        string name;
        public override string Name { get => name; set => name = value; }
        public Cat(string name)
            : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}

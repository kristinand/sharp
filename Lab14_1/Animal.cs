using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_1
{
    abstract class Animal
    {

        public abstract string Name { get; set; }

        public Animal(string name) {
            this.Name = name;
        }

        abstract public void Say();

        public void ShowInfo() {
            Console.WriteLine(Name);
            Say();
        }
    }

    internal class Cat:Animal {

        private string name;

        public Cat(string name) : base(name)
        {

        }

        public override string Name {  
            get => name;
            set=> name = value;
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    internal class Dog : Animal
    {

        private string name;

        public Dog(string name) : base(name)
        {

        }

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal abstract class Animal : IAnimal
    {
        protected string name;
        protected string color;
        protected int age;
        protected int height;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.age = value; }
        }

        protected Animal(string name, string color, int age, int height)
        {
            this.name = name;
            this.color = color;
            this.age = age;
            this.height = height;
        }

        public abstract void Eat();
        public abstract void Cry();
    }
}

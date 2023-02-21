using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Cat : Animal
    {
        public Cat(string name, string color, int age, int height) : base (name, color, age, height)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

        public override void Cry()
        {
            Console.WriteLine("Meow!");
        }
    }
}

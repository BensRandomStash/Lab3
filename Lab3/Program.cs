using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("James", "yellow", 4, 3);

            Console.WriteLine("Dog info:");
            Console.WriteLine("Name: " + dog.Name);
            Console.WriteLine("Color: " + dog.Color);
            Console.WriteLine("Age: " + dog.Age);
            Console.WriteLine("Height: " + dog.Height);

            dog.Eat();
            dog.Cry();

            Console.WriteLine("");

            Animal cat = new Cat("Sam", "Black", 7, 2);

            Console.WriteLine("Cat info:");
            Console.WriteLine("Name: " + cat.Name);
            Console.WriteLine("Color: " + cat.Color);
            Console.WriteLine("Age: " + cat.Age);
            Console.WriteLine("Height: " + cat.Height);

            cat.Eat();
            cat.Cry();
        }
    }
}

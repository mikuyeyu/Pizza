using Pizza.Entities;
using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog { Name = "Azor"};
            IAnimal cat = new Cat { Name = "Uwu" };
            IAnimal human = new Human { Name = "Wojtek" };

            Console.WriteLine($"{dog.Name} says: {dog.GetSound()}");
            Console.WriteLine($"{cat.Name} says: {cat.GetSound()}");
            Console.WriteLine($"{human.Name} says: {human.GetSound()}");
        }
    }
}

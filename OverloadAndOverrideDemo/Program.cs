using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAndOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var newDog = new Dog();
            var newCat = new Cat();
            var newDuck = new Duck();

            newDog.MakeSound();
            newCat.MakeSound();
            newDuck.MakeSound();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAndOverrideDemo
{
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow.");
        }
    }
}

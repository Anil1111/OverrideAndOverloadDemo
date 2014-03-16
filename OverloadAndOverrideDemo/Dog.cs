using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAndOverrideDemo
{
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof, woof");
        }
    }
}

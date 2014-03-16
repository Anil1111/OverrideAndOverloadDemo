using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAndOverrideDemo
{
    abstract class Animal
    {
        public virtual void MakeSound() 
        { 
            Console.WriteLine("default sound."); 
        }

    }
}

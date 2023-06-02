using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2023
{
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("oink");
        }
    }
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("ruff");
        }
    }
}
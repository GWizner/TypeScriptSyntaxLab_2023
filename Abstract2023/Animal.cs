using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2023
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract void AnimalSound(); //all child classes must override any abstract member
                                            //of parent class (method, property, etc.)
    }
    class Pig : Animal
    {
        public override string Name { get; set; }
        public override void AnimalSound()
        {
            Console.WriteLine("oink");
        }
    }
    class Dog : Animal
    {
        public override string Name { get; set; }
        public override void AnimalSound()
        {
            Console.WriteLine("ruff");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2023
{
    public class Dog : IAnimal
    {
        public string FavoriteFood { get; set; }

        public void AnimalSound()
        {
            Console.WriteLine("Woof");
        }

        public void Run()
        {
            Console.WriteLine("Run, dog, run!");
        }
    }
}

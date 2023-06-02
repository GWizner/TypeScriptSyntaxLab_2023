using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2023
{
    interface IAnimal
    {
        string FavoriteFood { get; set; }
        void AnimalSound();
        void Run();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects2023
{
    public class MenuItem
    {
        public string Name;
        private decimal price;
        public string Description;
        public int Calories;
        public List<string> Ingredients;

        public decimal GetPrice() 
        { 
            return price; 
        }
        public void SetPrice(decimal price)
        {
            Description = Description + "\n Price changed on " + DateTime.Now.ToString();
            this.price = price;
        }

        public string GetFullDescription()
        {

            return $"{Name}, {GetPrice()}, {Calories}, {Description}";
        }
        public MenuItem(string name, decimal price, int calories, string description = "No Description")
        {
            Name = name;
            this.price = price;
            Calories = calories;
            Description = description;
            Ingredients = new List<string>();
        }
    }
}

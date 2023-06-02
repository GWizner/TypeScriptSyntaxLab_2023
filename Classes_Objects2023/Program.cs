using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Classes_Objects2023
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuItem myFirstItem = new MenuItem("Coney Dog", 
                2.50m, 
                500,
                "Yummy");

            myFirstItem.Ingredients.Add("Bun");
            myFirstItem.Ingredients.Add("Hot Dog");

            //Console.WriteLine("myFirstItem name: " + myFirstItem.name);

            MenuItem mySecondItem = new MenuItem("Chili Dog",
                3.00m, 
                600);

            mySecondItem.Ingredients.Add("Chili");
            mySecondItem.Ingredients.Add("Coney Dog");

            //Console.WriteLine("mySecondItem name: " + mySecondItem.name);

            List<MenuItem> menu = new List<MenuItem>()
            {
                myFirstItem,
                mySecondItem,
                //new MenuItem() {Name = "Chili Cheese Dog", Price = 3.50m},
                //new MenuItem() {Name = "Corn Dog", Price = 3.75m},
                //new MenuItem() {Name = "Footlong Coney", Price = 4.00m},
                //new MenuItem() {Name = "Bacon Cheddar Dog", Price = 4.25m}
            };

            Console.WriteLine("Here is our menu: \n");

            foreach (MenuItem menuItem in menu)
            {
                Console.WriteLine($"{menuItem.Name} {menuItem.GetPrice():C}");
                Console.WriteLine(menuItem.Description);
                Console.WriteLine();
            }


            //do
            //{
            //    Console.WriteLine("Add a new item to our menu... \n");

            //    Console.WriteLine("\nName: ");
            //    string userItemName = Console.ReadLine();

            //    Console.WriteLine("\nPrice: ");
            //    string userItemPriceString = Console.ReadLine();
            //    decimal userItemPrice = decimal.Parse(userItemPriceString);

            //    Console.WriteLine("\nDescription: ");
            //    string userDescription = Console.ReadLine();

            //    Console.WriteLine("\nCalories: ");
            //    string userCaloriesString = Console.ReadLine();
            //    int userCalories = int.Parse(userCaloriesString);


            //    MenuItem userMenuItem = new MenuItem();
            //    userMenuItem.name = userItemName;
            //    userMenuItem.price = userItemPrice;
            //    userMenuItem.description = userDescription;
            //    userMenuItem.calories = userCalories;

            //    menu.Add(userMenuItem);


            //    Console.WriteLine("\nAdd another item?");

            //} while (Console.ReadLine() == "y");

            //Console.WriteLine("Updated menu: \n");
            //foreach (MenuItem menuItem in menu)
            //{
            //    Console.WriteLine($"{menuItem.name, -10} { menuItem.price.ToString("C"), 10}");
            //    Console.WriteLine(menuItem.description);
            //    Console.WriteLine(menuItem.calories);
            //    Console.WriteLine();

            //}
            //Console.WriteLine("Search the menu: ");
            //string searchTerm = Console.ReadLine();

            //List<MenuItem> searchResults = menu.Where(item => item.name.Contains(searchTerm)).ToList();

            //foreach (MenuItem result in searchResults)
            //{
            //    Console.WriteLine(result.name);
            //}

            IEnumerable<MenuItem> lessThan = menu.Where(x => x.GetPrice() < 3.50m).Take(4);

            foreach (var item in lessThan)
            {
                Console.WriteLine(item.GetFullDescription());
            }
        }
    }
}
          




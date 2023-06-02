using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    public class Validator
    {
        public static bool getContinue()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Would you like to see any more? (y/n): ");
                string choice = Console.ReadLine().ToLower().Trim();
                choice = choice.Trim();
                if (choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {

                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("I do not understand your input. Please try again.");
                }
            }
            return result;
        }
        public static double getUserRad()
        {
            double userRad = 0;
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter a radius: ");
                        userRad = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Please try a number greater or less than 0.");
                        Console.WriteLine();
                    }

                }

                if (userRad == 0)
                {
                    Console.WriteLine("Please try a number greater or less than 0.");
                    Console.WriteLine();
                }
                else if (userRad != 0)
                {
                    break;
                }
            }
            return userRad;
        }
    }
}
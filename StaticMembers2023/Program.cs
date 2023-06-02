using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers2023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pen pen1 = new Pen("black");
            Pen pen2 = new Pen("red");
            Pen pen3 = new Pen("blue");
            Pen pen4 = new Pen("magenta");
                        
            Console.WriteLine($"Pen ink level: {pen1.InkLevel * 100}%");

            pen1.InkLevel = 2f;

            Console.WriteLine($"Pen ink level: {pen1.InkLevel * 100}%");

            pen1.InkLevel = -1.0f;

            Console.WriteLine($"Pen ink level: {pen1.InkLevel * 100}%");

            pen1.InkLevel = 100;

            while (pen1.InkLevel > 0)
            {
                pen1.Write();

                Console.ReadKey();
            }
            while (pen2.InkLevel > 0)
            {
                pen2.Write();

                Console.ReadKey();
            }
            foreach (Pen pen in Pen.AllPens)
            {
                Console.WriteLine($"{pen.InkColor}, {pen.InkLevel * 100}%");
            }
        }
    }
}
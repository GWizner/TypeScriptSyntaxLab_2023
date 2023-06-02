using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers2023
{
    public class Pen
    {
        public Pen(string inkColor)
        {
            InkColor = inkColor;
            inkLevel = 1.0f;

            AllPens.Add(this);
        }

        public string InkColor { get; set; }
        public string Brand { get; set; }
        public string InkType { get; set; }
        public decimal Price { get; set; }
        public float Length { get; set; }

        private float inkLevel;
        public float InkLevel //range from 0.00 to 1.00 i.e. 0% - 100%
        {
            get
            {
                return inkLevel /*    * 100*/;
            }
            set
            {
                if (value > 1.0f)
                {
                    inkLevel = 1.0f;
                }
                else if  (value < 0.0)
                {
                    inkLevel = 0.0f;
                }
                else
                {
                    inkLevel= value;
                }
            }
        }
        public void Write()
        {
            InkLevel -= 0.1f;
            Console.WriteLine("Pen Write() called");
            Console.WriteLine("Ink level: " + InkLevel * 100 + "%");

        }
        public static void RefillPens()
        {
            foreach (Pen pen in AllPens) 
            {
                pen.InkLevel = 1.0f;
                
            }
        }

        public static List<Pen> AllPens = new List<Pen>()
        {

        };
    }
}

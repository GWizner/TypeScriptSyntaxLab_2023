namespace CircleLab
{
    public class Circle
    {
        public double rad;
        public double circ;
        public double area;

        public Circle(double radius)
        {
            rad = radius;
        }

        public double CalculateCircumference()
        {
            circ = 2 * Math.PI * rad;
            return circ;

        }
        public string CalculateFormattedCircumference()
        {
            string roundCirc = FormatNumber(CalculateCircumference());
            return $"The circumference is {roundCirc}";
        }
        public double CalculateArea()
        {
            area = Math.PI * Math.Pow(rad, 2);
            return area;
        }
        public string CalculateFormattedArea()
        {
            string roundArea = FormatNumber(CalculateArea());
            return $"The area is {roundArea}";
        }
        private string FormatNumber(double x)
        {
            string round = Math.Round(x, 2).ToString();
            return round;
        }


    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Circle> totCircles = new List<Circle>();
            bool keepAsk = true;

            Console.WriteLine("Welcome to \"Circle Builder.\"\n");
            while (keepAsk)
            {
                double userRad = Validator.getUserRad();

                Circle newCircle = new Circle(userRad);

                string trueCirc = newCircle.CalculateFormattedCircumference();
                string trueArea = newCircle.CalculateFormattedArea();

                Console.WriteLine();
                Console.WriteLine(trueCirc);
                Console.WriteLine();
                Console.WriteLine(trueArea);

                totCircles.Add(newCircle);

                keepAsk = Validator.getContinue();
                Console.WriteLine();
            }

            Console.WriteLine($"You have built {totCircles.Count} circle(s). Goodbye.");

        }
    }
}
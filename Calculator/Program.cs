public class Program
{
    public static void Main(string[] parameters)
    {
        Console.WriteLine("Try my calulator.");
        bool keepOn = true;
        var myCalculator = new Calculator();
        while (keepOn)
        {

            Console.WriteLine("Calculator options menu:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Select one: ");
            var userIn = Console.ReadLine();
            int userNo;
            bool userInput = false;
            userInput = int.TryParse(userIn, out userNo);

            if (userInput)
            {
                if (userNo == 1)
                {
                    Console.WriteLine("Please enter a number to add:");
                    string numberString = Console.ReadLine();
                    int numberX = int.Parse(numberString);
                    myCalculator.Add(numberX);
                }
                else if (userNo == 2)
                {
                    Console.WriteLine("Please enter a number to subtract:");
                    string numberString = Console.ReadLine();
                    int numberX = int.Parse(numberString);
                    myCalculator.Subtract(numberX);
                }
                else if (userNo == 3)
                {
                    Console.WriteLine("Please enter a number to multiply:");
                    string numberString = Console.ReadLine();
                    int numberX = int.Parse(numberString);
                    myCalculator.Multiply(numberX);
                }
                else if (userNo == 4)
                {
                    Console.WriteLine("Please enter a number to divide:");
                    string numberString = Console.ReadLine();
                    int numberX = int.Parse(numberString);
                    myCalculator.Divide(numberX);
                }
                else if (userNo == 5)
                {
                    keepOn = false;
                }
            }
            else
            {
                Console.WriteLine($"Unrecognized input: {userIn}. Please enter an integer.");
            }
            if (keepOn)
            {
                Console.WriteLine($"The current value is {myCalculator.accumulator}");
            }

        }
    }
}

public class Calculator
{
    public int accumulator;

    public void Add(int newValue)
    {
        accumulator += newValue;
    }
    public void Subtract(int newValue)
    {
        accumulator -= newValue;
    }
    public void Multiply(int multiplicand)
    {
        accumulator *= multiplicand;
    }
    public void Divide(int divisor)
    {
        accumulator /= divisor;
    }
}
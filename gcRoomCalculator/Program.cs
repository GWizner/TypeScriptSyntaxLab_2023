bool userAns = false;
string userBns;

double length = 0;
double width = 0;
double height = 0;

Console.WriteLine("Hello, welcome to my room detail generator! Please input all of your answers in feet.");
Console.WriteLine();
begin:
Console.WriteLine("Enter Length: ");
string userLength = Console.ReadLine();
userAns = double.TryParse(userLength, out length);
if (userAns == false)
{
    Console.WriteLine("C'mon, quit playin'.");
    Console.ReadLine();
    goto begin;
}
else
{
    Console.WriteLine("Enter Width: ");
    string userWidth = Console.ReadLine();
    userAns = double.TryParse(userWidth, out width);


    if (userAns == false)
    {
        Console.WriteLine("Seriously?!");
        Console.ReadLine();
        goto begin;
    }
    else
    {
        Console.WriteLine("Enter Height: ");
        string userHeight = Console.ReadLine();
        userAns = double.TryParse(userHeight, out height);
        if (userAns == false)
        {
            Console.WriteLine("=_= ...");
            Console.ReadLine();
            goto begin;
        }
        else
        {
            double area = length * width;
            double perimeter = length * 2 + width * 2;
            double volume = length * width * height;
            double surfaceArea = 2 * (length * width + length * height + width * height);

            Console.WriteLine();
            Console.WriteLine("Area = " + area + " sq. ft.");
            Console.WriteLine("Perimeter = " + perimeter + " sq. ft.");
            Console.WriteLine("Volume = " + volume + " sq. ft.");
            Console.WriteLine("Surface Area = " + surfaceArea + " sq. ft.");

            if (area == 250 || area < 250)
            {
                Console.WriteLine("That's a small room!! ('O')");
            }
            else if (area > 250 && area < 650)
            {
                Console.WriteLine("Ehh, that's a pretty decent sized room. ;)");
            }
            else
            {
                Console.WriteLine("Now that's a large room! XD");
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to measure any more rooms?");
            userBns = Console.ReadLine().ToLower();
            userBns.Trim();
            userBns = userBns.Trim();
            string yes = "yes";
            string y = "y";
            if (userBns == yes)
            {
                goto begin;
            }
            else if (userBns == y)
            {
                goto begin;
            }
            else
            {
                Console.WriteLine("Goodbye! ^_^");
            }
            Console.ReadLine();

        }
    }
}
//string User1 = Console.ReadLine();

//string User2 = Console.ReadLine();

//double UserNum1 = double.Parse(User1);
//double UserNum2 = double.Parse(User2) * (UserNum1);


//Console.WriteLine($"{UserNum2}");

//string y = "y";
//string n = "n";
//bool hello = true;

//while (hello)
//{
//    Console.WriteLine("Hello, World! \nWould you like to continue (y/n)?");
//    string userAnswer = Console.ReadLine();
//    Console.WriteLine();

//    if (userAnswer == y)
//    {
//        hello = true;
//    }
//    else if (userAnswer == n)
//    {
//        System.Threading.Thread.Sleep(500);
//        Console.WriteLine("Goodbye");
//        hello = false;
//    }
//    else
//    {
//        Console.WriteLine("Sorry, I don't understand :(");
//        hello = false;
//    }
//}
string myString = "Hello";

for (int i = 0; i < myString.Length; i++)
{
    global::System.Console.WriteLine(myString[i]);
    System.Threading.Thread.Sleep(500);
}
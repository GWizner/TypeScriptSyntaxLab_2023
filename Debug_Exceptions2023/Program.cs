

//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        Console.WriteLine(i);
//    }
//    Console.WriteLine();
//}

//exception
int[] numArray = { 1, 23, 45 };

Console.WriteLine(numArray[1]);
Console.WriteLine();

try
{
	Console.WriteLine(numArray[3]);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
	Console.WriteLine();
	//throw; ------- will end the program
}
Console.WriteLine("Program Continues...\n");


Console.WriteLine("Please enter a number: \n");
string input1 = Console.ReadLine();
int num1 = int.Parse(input1);

Console.WriteLine("Please enter a number: ");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2);

Console.WriteLine();

try
{
	double total = num1 / num2;
	Console.WriteLine(total);
}
catch (NullReferenceException ex)
{
	Console.WriteLine(ex.Message);
}
catch (OutOfMemoryException ex)
{
	Console.WriteLine(ex.Message);
}
catch (Exception)
{
    Console.WriteLine("Does not compute!");
	Environment.Exit(0);
}
finally
{
	Console.WriteLine("Always runs!");
}
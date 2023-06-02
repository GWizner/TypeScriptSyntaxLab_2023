string enteredValue = Console.ReadLine();
decimal parsedValue = 0;
try
{
    double pi = 3.14;
    parsedValue = 3.14m;
    parsedValue = decimal.Parse(enteredValue);
    int partsedValueInt = (int)parsedValue;
    int x = (int)6;
}
catch (Exception e)
{
    Console.WriteLine("Sorry, an error happened.");
}
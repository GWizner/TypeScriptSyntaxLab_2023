Console.WriteLine("Enter a number: ");
string userInput = Console.ReadLine();
Console.WriteLine();
bool InputGood = int.TryParse(userInput, out int userNum);

for (int a = userNum; a >= 0; a--)
{
    Console.WriteLine(a);
}
Console.WriteLine();
for (int b = 0; b <= userNum; b++)
{
    Console.WriteLine(b);
}
Console.WriteLine();
Console.ReadLine();
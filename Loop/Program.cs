// See https://aka.ms/new-console-template for more information
var favColors = new List<string>();
bool keepAsk = true;
while (keepAsk)
{
    Console.WriteLine("Hello, User. What are your favorite colors?");
    string userColors = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(userColors))

        keepAsk = false;
    else
    
        favColors.Add(userColors);
}
    for(int currColorNo = 0; currColorNo < favColors.Count; currColorNo++)
    {
        Console.WriteLine($"{currColorNo}. {favColors[currColorNo]}");
    }

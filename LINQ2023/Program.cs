//Language Integrated Query

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LINQ2023;

List<string> menu = MockDatabase.GetAllMenuItems();

List<string> coneyList = new List<string>();

foreach (var item in menu)
{
    if (item.Contains("coney", StringComparison.CurrentCultureIgnoreCase))
    {
        coneyList.Add(item);
    }
}

foreach (var item in coneyList)
{
    Console.WriteLine(item);
}
Console.WriteLine();

var coneyListFromLambda = menu.Where(item => item.Contains("coney", StringComparison.CurrentCultureIgnoreCase));


var coneyListFromQuery = from item in menu
                         where item.Contains("coney", StringComparison.CurrentCultureIgnoreCase) 
                         select item;

foreach(var item in coneyListFromLambda)
{
    Console.WriteLine(item);
}
Console.WriteLine();

foreach(var item in coneyListFromQuery)
{
    Console.WriteLine(item);
}
Console.WriteLine();
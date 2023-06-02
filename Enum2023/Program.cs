using Enum2023;
using System;


Console.WriteLine(Days.Monday);

Person person = new Person();
person.FirstName = "Banana";

int currentHourOfTheDay = 14;

if (currentHourOfTheDay > 9)
{
    person.State = CurrentState.Working;
}
Console.WriteLine(person.FirstName + "is" + person.State);

switch (person.State)
{
    case CurrentState.Sleeping:
        break;
    case CurrentState.Working:
        break;
    case CurrentState.Eating:
        break;
    default:
        break;
}
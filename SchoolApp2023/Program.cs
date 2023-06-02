

using SchoolApp2023;
using System;

Console.WriteLine("Welcome to the Cshool Online System! Please login to continue.");


do
{
    Console.WriteLine("Enter your email address: ");
    string userEmail = Console.ReadLine();

    Console.WriteLine("Enter your password: ");
    string userPassword = Console.ReadLine();
    
    if(false)
    {

    }
    else
    {
        Console.WriteLine("sorry");
    }

    Console.WriteLine("Would you like to restart the App? [y]");

} while (Console.ReadLine() == "y");

Student s1 = new Student();
s1.CurrentStatus = RegistrationStatus.Accepted;

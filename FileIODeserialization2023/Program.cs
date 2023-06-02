using FileIODeserialization2023;
using System.Runtime.InteropServices;
using System;
using System.IO;

// Define path based on OS

string macPath = @"/Users/YourUserName/Desktop/Inventory.txt";
string windowsPath = @"c:\Users\dude_dude\Desktop\Inventory.txt";
string path = string.Empty;

// Detect the Operating system

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    Console.WriteLine("Windows!");
    path = windowsPath;
}

if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
{
    Console.WriteLine("Mac!");
    path = macPath;
}

// Create an inventory item instance: hardcode example
InventoryItem inventoryItem = new InventoryItem("001", "Cat", "Friendly cat. Please buy.", 150.00m);

if (!File.Exists(path))
{
    // Prompt user to create their own inventory item

    Console.WriteLine("Create a new Inventory Item.");

    Console.WriteLine("ID: ");
    string userId = Console.ReadLine();

    Console.WriteLine("Name: ");
    string userName = Console.ReadLine();

    Console.WriteLine("Description: ");
    string userDescription = Console.ReadLine();

    Console.WriteLine("Price: ");
    decimal userPrice = decimal.Parse(Console.ReadLine());

    InventoryItem userInventoryItem = new InventoryItem(userId, userName, userDescription, userPrice);


    // Create a file to write to.
    using (StreamWriter sw = File.CreateText(path))
    {
        sw.WriteLine(inventoryItem);
        sw.WriteLine(userInventoryItem);
    }
}

// Open the file to read from.

Console.WriteLine("Print out the exact content of the text file:");
using (StreamReader sr = File.OpenText(path))
{
    string s;
    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);
    }
}

// How do we turn the text file back into OBJECTS in our program? 
// We want to turn a string into an object. 
// This is known as DESERIALIZATION.

List<InventoryItem> inventoryItems = new List<InventoryItem>();

using (StreamReader sr = File.OpenText(path))
{
    string s;
    while ((s = sr.ReadLine()) != null)
    {
        string[] values = s.Split("||");

        decimal priceFromFile = decimal.Parse(values[3]);

        InventoryItem itemFromFile = new InventoryItem(values[0], values[1], values[2], priceFromFile);
        inventoryItems.Add(itemFromFile);
    }
}

// Loop through the deserialized objects
foreach (InventoryItem item in inventoryItems)
{
    Console.WriteLine($"{item.ProductName} is {item.Price}.");
}
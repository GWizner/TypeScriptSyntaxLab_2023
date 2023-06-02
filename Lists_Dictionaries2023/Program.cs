//List<string> animals = new List<string>();

////LIST METHODS

//////add
//animals.Add("Platypus");
//animals.Add("Octopus");
//animals.Add("Narwhal");

//foreach (string animal in animals)
//{
//    Console.WriteLine(animal);
//}
//Console.WriteLine();

//////remove
//animals.Remove("Platypus");
//foreach (string animal in animals)
//{
//    Console.WriteLine(animal);
//}
//Console.WriteLine();

//////chaange the content of an element
//Console.WriteLine("The first element at position 0 is: " + animals[0]);
//animals[0] = "Seahorse";
//Console.WriteLine("Now, the first element at position 0 is: " + animals[0] + "\n");
//Console.WriteLine();
//Console.WriteLine(animals.Count);

//if (2 < animals.Count - 1)
//{
//    animals[2] = "Dog"; //element 2 does not currently exist
//}

//////contains
//bool containsResult = animals.Contains("Seahorse");
//Console.WriteLine(containsResult);

//bool containsResult2 = animals.Contains("Dog");
//Console.WriteLine(containsResult2);
//Console.WriteLine();

//////insert
//animals.Insert(0, "Tree Frog");
//foreach (string animal in animals)
//{
//    Console.WriteLine(animal);
//}
//Console.WriteLine();
//animals.Insert(0, "Flamingo");
//animals.Insert(4, "Dog"); //This element just got created
// foreach (string animal in animals)
//{
//    Console.WriteLine(animal);
//}
//Console.WriteLine();

//////tolist
//string animalsAsString = "Flamingo, Tree Frog, Seahorse, Narwhal, Dog";
////whatever comes befor "comma space" becomes a separate string
//string[] arrayOfAnimals = animalsAsString.Split(", "); 
//List<string> animalList = arrayOfAnimals.ToList();
////all on one line
////List<string> animalList = animalsAsString.Split(", ").ToList();

//Dictionary<string, string> englishToSpanish = new();
Dictionary<string, string> englishToSpanish = new Dictionary<string, string>();

englishToSpanish["hello"] = "hola";  //SET a key and its value
englishToSpanish.Add("goodbye", "adios");  //alternate set function
englishToSpanish.Add("tomorrow", "mañana");  
englishToSpanish.Add("morning", "mañana");  //cannot have duplicate keys. Can duplicate values. 

Console.WriteLine($"{englishToSpanish["hello"]}");  //GET value
Console.WriteLine($"{englishToSpanish["goodbye"]}");


//Console.WriteLine($"{englishToSpanish["dog"]}");     //throws an exception!
//avoiding an exception
if (englishToSpanish.ContainsKey("dog"))
{ 
    //something
}
else
{
    Console.WriteLine("Sorry, didn't find dog.");
}

//Contains key?? -- Get value else alert
Console.WriteLine("\n");
Console.WriteLine("Enter a word to search the dictionary: ");
string searchTerm = Console.ReadLine();

if (englishToSpanish.ContainsKey(searchTerm))
{
    Console.WriteLine($"{searchTerm} = {englishToSpanish[searchTerm]}");
}
else
{
    Console.WriteLine($"Nrrrp! {searchTerm} don't exist!");
}
Console.WriteLine();

Dictionary<int, List<string>> employeeDatabase = new();   //enter a # such as empID to get a list of skills, etc.

List<string> skillsExample1 = new();
skillsExample1.Add("HTML");
skillsExample1.Add("CSS");
skillsExample1.Add("Javascript");

List<string> skillsExample2 = new();
skillsExample2.Add("SQL");
skillsExample2.Add("NoSQL");
skillsExample2.Add("MongoDB");

employeeDatabase.Add(44, skillsExample1);
employeeDatabase.Add(1, skillsExample2);

foreach (var employee in employeeDatabase)
{
    Console.WriteLine("Employee ID: " + employee.Key);
        foreach (string skill in employee.Value)
    {
        Console.WriteLine(skill); 
    }
    Console.WriteLine();
}


//add values
Console.WriteLine();
Dictionary<string, decimal> keyValuePairs = new();
keyValuePairs.Add("Chocolate", 9.99m);
keyValuePairs.Add("Apple", 0.25m);
keyValuePairs.Add("Guava", 2.99m);

decimal total = keyValuePairs += ["Apple"];                 //["Apple"] + keyValuePairs["Guava"];
Console.WriteLine(total); ;
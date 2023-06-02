//initialize an array
int[] ages = new int[] {25, 25, 99, 77, 29, 30, 27, 20, 28, 49, 37, 34};
string[] names = new string[13];

int classSize = 13;
string[] homeTown = new string[classSize];

//use user input
Console.WriteLine("How many elements do you want?");
int userSize = int.Parse(Console.ReadLine());
double[] userElements = new double[userSize];

//accessing elements
//use index
Console.WriteLine(ages[0]);
ages[0] = 24;
Console.WriteLine(ages[0]);
Console.WriteLine();

//loop through an array
//for
for (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}
Console.WriteLine();

//add 1 to all
for (int i = 0; i < ages.Length; i++)
{
    ages[i]++;
    Console.WriteLine();
}

//find average age
int sum = 0;
for (int i = 0; i < ages.Length; i++)
{
    sum += ages[i];
}
int avg = sum / ages.Length;
Console.WriteLine($"{avg} is the average age in class");

int avgAge = ages.Sum() / ages.Length;

Console.WriteLine();
//foreach
foreach(int a in ages)
{
    Console.WriteLine(a);
}

//array static methods
//Array.Sort(ages);
//Array.Clear(ages);
//Array.Reverse(ages);


Console.WriteLine();
foreach(int a in ages)
{
    Console.WriteLine(a);
}




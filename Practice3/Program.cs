int[] ages = new int[] { 25, 25, 99, 77, 29, 30, 27, 20, 28, 49, 37, 34 };

string[] names = new string[13];

int classSize = 13;
string[] homeTown = new string[classSize];

Console.WriteLine("How many elements do you want?");
int userSize = int.Parse(Console.ReadLine());
double[] userElements = new double[userSize];

Console.WriteLine(ages[0]);
ages[0] = 24;
Console.WriteLine(ages[0]);

for (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}
for (int i = 0; i < ages.Length; i++)
{
    ages[i]++;
    Console.WriteLine(ages[i]);
}

int sum = 0;
for (int i = 0; i < ages.Length; i++)
{
    sum += ages[i];
}
int avg = sum / ages.Length;
Console.WriteLine($"{avg} is the average age in class.");

Console.WriteLine();

foreach(int a in ages)
{
    Console.WriteLine(a);
}

Array.Sort(ages);
//Array.Clear(ages);
//Array.Reverse(ages);

Console.WriteLine();
foreach(int a in ages)
{
    Console.WriteLine(a);
}

//int[] copyAges = ages;
int[] copyAges = new int[999];
//ages.CopyTo(copyAges,0);

//skips first (#0), only copies up uo three
Array.Copy(ages, 1, copyAges, 0, 3);
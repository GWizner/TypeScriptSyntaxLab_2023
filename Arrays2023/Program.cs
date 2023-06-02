////arrays
//string[] names = new string[6];
//names[0] =  "Grace";
//names[1] = "Selena";
//names[2] = "Patti";
//names[3] = "";
//names[4] = "Geoff";
//names[5] = "";

////access element by position
//Console.WriteLine(names[1]);
//Console.WriteLine(names[2]);
//Console.WriteLine();

////loop through all elements
//for (int i = 0;i < names.Length; i++)
//{
//    Console.WriteLine($"{i}. {names[i]}");
//}
//Console.WriteLine();

////array of ints
//int[] userIds = new int[] { 2, 3, 5, 8, 11 };

////user array
//Console.WriteLine("How many movie titles do you want to enter? ");
//int userNum = int.Parse(Console.ReadLine());

//string[] titles = new string[userNum];

//for (int i = 0;i < titles.Length; i++)
//{
//    Console.Write("Enter movie title: ");
//    string title = Console.ReadLine();

//    titles[i] = title;

//    Console.WriteLine("\n");
//}
//Console.WriteLine();

////print the value for each element
//foreach (string title in titles)
//{
//    Console.WriteLine(title);
//}
//Console.WriteLine();

////index number
//for (int i = 0; i < titles.Length; i++) //i+=2 will give me every other movie (0, 2, 4, etc.)
//{
//    Console.WriteLine($"{i + 1}. {titles[i]}");
//}

//Use case for arrays
string dessertApiResponse = "Apple Pie, Apple Strudel, Banana Bread, Banana Pudding, Blueberry Muffin, Maine Blueberry, Blackberry Pie, Blackberry Cobbler, Blackberry Cheesecake, Birthday Cake, Cake Pops, Cheesecake, Cheesecake Brownies, Cherry Pie, Chocolate Cake, Chocolate Pie, Cinnamon Rolls, Cupcakes, Custard Tart, Fancy Doughnuts, Doughnut Hole, Death by Chocolate Cake, Fudge, Funnel Cake, Fruitcake, Frozen Yogurt, Gingerbread Cookies, Gingersnaps, Hot Fudge Sundae, Ice Cream Sundae, Ice Cream Cake, Ice Cream, Jelly Roll, Key Lime Pie, Lemon Meringue Pie, Lemon Bar, Lemon Blueberry Cupcakes, Lemon Pie, Lemon Pound Cake, Ladyfinger";
string[] desserts = dessertApiResponse.Split(", ");

for (int i = 0;i < desserts.Length; i++)
{
    if (desserts[i].StartsWith('C'))
    {
        Console.WriteLine($"{i + 1}. {desserts[i]}");
    }
}
Console.WriteLine("Array.Sort() example: ");
Array.Sort(desserts);
string cupcakes = "Cupcakes";
int binarySearchResult = Array.BinarySearch(desserts, cupcakes); //will only work if array is sorted properly (ascending)
Console.WriteLine("Binary Search Result: " + binarySearchResult);

Array.Reverse(desserts);

foreach (var item in desserts)
{
    Console.WriteLine(item);
}



Console.ReadLine();


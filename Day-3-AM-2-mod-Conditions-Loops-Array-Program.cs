Console.WriteLine("Conditions, Arrays, Lists and Loops Examples");
/*
// Conditions
int number = 7;
if ( number < 0)
{
    Console.WriteLine($"{number} is negative"); // interpolation   
}
else if ( number == 0)
{
    Console.WriteLine("Number is 0");
}
else
{
    Console.WriteLine($"{number} is positive");
}

// Ternary operator
string parity = (number % 2 == 0) ? "even" : "odd";
Console.WriteLine($"{number} is {parity} (checked with ternary).");


// Switch statement
Console.WriteLine("Enter a Number: ");
Console.WriteLine("1-Add a Product:");
Console.WriteLine("2-Search a Product:");
Console.WriteLine("3-Delete a Product:");
Console.WriteLine("0-Quit");
Console.Write("Enter a Number: ");
string userInput = Console.ReadLine();
switch (userInput)
{
    case "1":
        //Console.WriteLine("You chose to add a product.");
        AddProduct();
        break;
    
    case "2": 
        //Console.WriteLine("You chose to search a product.");
        SearchProduct();
        break;
    
    case "3": 
        //Console.WriteLine("You chose to delete a product.");
        DeleteProduct();
        break;
    
    default: Console.WriteLine("Invalid choice.");
        break;
}

void AddProduct()
{
    Console.WriteLine("Adding a product...");
    // Code to add a product goes here
}

void SearchProduct()
{
    Console.WriteLine("Searching for a product...");
    // Code to search for a product goes here
}

void DeleteProduct()
{
    Console.WriteLine("Deleting a product...");
    // Code to delete a product goes here
}

*/

/*
 * Arrays
 * An array is a collection of items stored at contiguous memory locations.
 * https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-10.0
*/

// Declaring the arrays
string[] myStr;
myStr = new string[3];
myStr[0] = "Hello";

string[] myStr2 = { "a", "b", "c", "1"};
// var is implicitly typed local variable, the compiler infers the type from the right-hand side of the assignment
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables
var myArr1 = new int[] { 1, 2, 3};

int[] numbersArray = { 10, 20, 30, 40, 50, 1, 5};
Console.WriteLine("Elements of numbers Array: " + numbersArray.Length);
Console.WriteLine("First element: " + numbersArray[0]);

// Modifying an element
numbersArray[2] = 35;

for (int i = 0; i < numbersArray.Length; i++)   
{
    Console.WriteLine($"Element at index {i}: {numbersArray[i]}");
}

foreach (int num in numbersArray)
{
    Console.WriteLine($"Element: {num}");
}


// Arrays can be sorted
Array.Sort(numbersArray);
foreach (int num in numbersArray)
{
    Console.WriteLine($"Sorted Element: {num}");
}

/*
 * Lists   
 * The List<T> is a collection of strongly typed objects
   that can be accessed by index and having methods for sorting, searching, and modifying list.
 * List can contain string, int, double etc values  also can contain objects

 * It is different from the arrays.
 * A List<T> can be resized dynamically but arrays cannot.
 * In general, it’s better to use lists in C# 
   because lists are far more easily sorted, searched through, and manipulated in C# than arrays. 
 * https://www.tutorialsteacher.com/csharp/csharp-list
 * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-10.0
 * 
*/

// Lists are generics and can grow dynamically
List<string> myList = new List<string> { "apple", "banana", "cherry" };
//var myList1 = new List<string> { "apple", "banana", "cherry" };
var myList1 = new List<string> { "apple", "banana", "cherry" };

var numbersList = new List<int> { 10, 20, 30, 40, 50, 1, 5 };

// Add, Insert, Remove
// Add appends an element to the end of the list
numbersList.Add(60);
Console.WriteLine("List");
foreach (int num in numbersList) { 
    Console.WriteLine($"List Element: {num}");
}

// Insert adds an element at the specified index and shifts the rest to the right
numbersList.Insert(2, 25); // Insert 25 at index 2
Console.WriteLine("List after Insert an element");

foreach (int num in numbersList)
{
    Console.WriteLine($"List Element: {num}");
}

// Remove removes the first occurrence of the specified value
numbersList.Remove(25); // Remove the first occurrence of 40

Console.WriteLine("List after Remove an element");

foreach (int num in numbersList)
{
    Console.WriteLine($"List Element: {num}");
}

// RemoveAt removes the element at the specified index
numbersList.RemoveAt(0);
Console.WriteLine("List after RemoveAt an element");

foreach (int num in numbersList)
{
    Console.WriteLine($"List Element: {num}");
}


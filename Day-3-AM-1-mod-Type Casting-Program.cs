// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;

Console.WriteLine("Hello, World!");



// Type Casting and Parsing
Console.Write("Enter First Number:");
string input1 = Console.ReadLine();
Console.Write("Enter Second Number: ");
string input2 = Console.ReadLine();

// Convert.ToInt32() - converts string to int, throws exception if invalid  
//int sum = Convert.ToInt32(input1) + Convert.ToInt32(input2);

// Parse() - converts string to int, throws exception if invalid
//var sum = int.Parse(input1) + int.Parse(input2);

// TryParse() - converts string to int, returns false if invalid, does not throw exception
bool isValid1 = int.TryParse(input1, out int number1);
bool isValid2 = int.TryParse(input2, out int number2);

if(isValid1 && isValid2)
{
    var sum = number1 + number2;
    Console.WriteLine("Sum of Numbers: " + sum);
}
else
{
    Console.WriteLine("Enter valid integers.");
}

//Console.WriteLine("Sum of Numbers: " + sum);








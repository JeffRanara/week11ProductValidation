// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;
using System;
using System.Collections.Generic;
using System.IO; 
using System.Text.RegularExpressions;


List<string> productList = new List<string>();
string fileName = "products.txt";

Console.WriteLine("--- Product Entry System ---");
Console.WriteLine("Format: LETTERS-NUMBERS (e.g., XX-480)");
Console.WriteLine("Note that letters in lowercase will be converted to uppercase. Numbers must be between 200 and 500.");
Console.WriteLine("Type 'exit' to finish.");

while (true)
{
    Console.Write("\nEnter product: ");
    string input = Console.ReadLine()?.Trim(); // the '?' prevents a NullReferenceException

    if (string.IsNullOrEmpty(input))
    {
        ShowErrorMessage("Sorry: Empty input is not allowed.");
        continue;
    }

    if (input.ToLower() == "exit") break;

    if (!input.Contains("-"))
    {
        ShowErrorMessage("Sorry: The hyphen character '-' is missing. Format must be LETTERS-NUMBERS.");
        continue;
    }

    string[] parts = input.Split('-');

    if (parts.Length != 2)
    {
        ShowErrorMessage("Sorry: Invalid format. Use exactly one hyphen (e.g., ABC-123).");
        continue;
    }

    string leftPart = parts[0];
    string rightPart = parts[1];

    if (!Regex.IsMatch(leftPart, @"^[a-zA-ZåäöÅÄÖ]+$"))
    {
        ShowErrorMessage($"Sorry: The left part '{leftPart}' of the product must contain letters only.");
        continue;
    }

    if (!int.TryParse(rightPart, out int productCode))
    {
        ShowErrorMessage($"Sorry: The right part '{rightPart}' of the product must contain numbers only.");
        continue;
    }

    if (productCode < 200 || productCode > 500)
    {
        ShowErrorMessage($"Sorry: The number {productCode} is out of range. Must be a whole number between 200 and 500.");
        continue;
    }

    string formattedProduct = input.ToUpper();
    if (productList.Contains(formattedProduct))
    {
        ShowErrorMessage($"Sorry: The product '{formattedProduct}' has already been entered.");
        continue;
    }

    productList.Add(formattedProduct);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Product successfully entered!");
    Console.ResetColor();
}

// Final output processing
productList.Sort();
Console.WriteLine("\n******************");
Console.WriteLine("PRODUCT LIST (sorted alphabetically):");
foreach (var product in productList)
{
    Console.WriteLine($"- {product}");
}

// Summary
Console.WriteLine("******************");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Total number of products successfully entered: {productList.Count}");
Console.ResetColor();

// Save to file
if (productList.Count > 0)
{
    try
    {
        File.WriteAllLines(fileName, productList);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"List successfully saved to '{fileName}'.");
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        ShowErrorMessage($"Could not save file: {ex.Message}");
    }
}

Console.WriteLine("\nPress any key to close this program...");
Console.ReadKey();

static void ShowErrorMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}

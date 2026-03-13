// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;

//Console.WriteLine("Hello, World!");
//int number1 = 10;
//int number2 = 20;

//int sum = number1 + number2;
//Console.WriteLine("Sum of two numbers: " + sum);
//Console.WriteLine($"Sum of two numbers: {sum}"); // interpolation
//Console.WriteLine("Sum of two numbers:{0}", sum);
//Console.WriteLine("Sum of two numbers: " + (number1 + number2));
//Console.ReadLine();

//Sum of two numbers

// Comment Highligted code CTRL + K + C
// UnComment Highligted code CTRL + K + U

//Console.Write("Enter Your Name: ");
//string name = Console.ReadLine();
//Console.WriteLine("Hello " + name);

// String Operations and Methods
string data = "Lexicon Malmö ";
//             012345678
Console.WriteLine(data[5]);
//data[0] = 'l'; // String is immutable, cannot change individual characters
//data = "Kopenhagen";  // value of data can be changed but not the individual characters
string all = data.Substring(0);
string partOne = data.Substring(0, 7);
string partTwo = data.Substring(8, 6);
Console.WriteLine(partTwo);
string dataRemoved = data.Remove(7);
string dataReplaced = data.Replace("Malmö", "Kopenhagen");
string dataTrimmed = data.Trim();
string[] parts = data.Split();
Console.WriteLine(parts[0]);
string[] parts1 = data.Trim().Split();
Console.WriteLine(parts1[1]);
Console.ReadLine();
// Extra Useful string methods
// Primitives
string raw = "  Hello, World!  ";
string lang = "CSharp";
string name = "Alice";
int years = 30;
//float height = 1.72f;
double height = 1.72;
char initial = 'A';

// Basic string operations
// First way
Console.WriteLine("Original: " + "\"" + raw + "\"");
// Second way - interpolation
Console.WriteLine($"Original: '{raw}'");
// Third way
Console.WriteLine("Original: '{0}' ", raw);
Console.WriteLine($"Trim(): '{raw.Trim()}'");
Console.WriteLine($"Length: {raw.Length} (counts all characters, including spaces)");

// Case transformations
Console.WriteLine($"ToUpper(): {lang.ToUpper()}");
Console.WriteLine($"ToLower(): {lang.ToLower()}");

// Searching, substring and index
Console.WriteLine("Contains \"World\": " + raw.Contains("World"));
Console.WriteLine($"Contains(\"World\"): {raw.Contains("World")}");
Console.WriteLine($"IndexOf(','): {raw.IndexOf(',')}");
int commaPos = raw.IndexOf(',');
if (commaPos >= 0)
    Console.WriteLine($"Substring after comma: '{raw.Substring(commaPos + 1).Trim()}'");

// StartsWith / EndsWith
Console.WriteLine($"StartsWith(\"  He\"): {raw.StartsWith("  He")}");
Console.WriteLine($"EndsWith(\"!  \"): {raw.EndsWith("!  ")}");

// Replace, Insert, Remove
Console.WriteLine($"Replace: {lang.Replace("C", "c")}");
Console.WriteLine($"Insert: {lang.Insert(1, "#")}");   // C#harp -> C#sharp
Console.WriteLine($"Remove: {lang.Remove(1, 2)}");       // Removes 2 chars starting at index 1

// Split and Join
string csv = "red,green,blue";
string[] colors = csv.Split(',');
Console.WriteLine($"Split -> {string.Join(" | ", colors)}");

// StringBuilder for repeated concatenation
var sb = new StringBuilder();
for (int i = 0; i < colors.Length; i++)
{
    if (i > 0) sb.Append(';');
    sb.Append(colors[i]);
}
Console.WriteLine($"StringBuilder result: {sb}");

// Formatting and interpolation
Console.WriteLine($"Name: {name}, Age: {years}, Height: {height:F2} m");

// Parsing strings to numeric types (culture-invariant example for floats)
string yearsText = "42";
if (int.TryParse(yearsText, out int parsedYears))
    Console.WriteLine($"Parsed int: {parsedYears}");

string floatText = "3.1415";
if (float.TryParse(floatText, NumberStyles.Float, CultureInfo.InvariantCulture, out float parsedFloat))
    Console.WriteLine($"Parsed float: {parsedFloat}");

// Char utilities
Console.WriteLine($"Initial: {initial}, IsLetter: {char.IsLetter(initial)}, IsDigit('5'): {char.IsDigit('5')}");

// Null/empty/whitespace checks
string maybe = null;
Console.WriteLine($"IsNullOrEmpty(maybe): {string.IsNullOrEmpty(maybe)}");
Console.WriteLine($"IsNullOrWhiteSpace(\"   \"): {string.IsNullOrWhiteSpace("   ")}");

// Comparison (ordinal and case-insensitive)
Console.WriteLine($"Compare('a','A', Ordinal): {string.Compare("a", "A", StringComparison.Ordinal)}");
Console.WriteLine($"Compare('a','A', OrdinalIgnoreCase): {string.Compare("a", "A", StringComparison.OrdinalIgnoreCase)}");

// Safe concatenation and joining arrays
var items = new[] { "one", "two", "three" };
Console.WriteLine("Joined: " + string.Join(", ", items));
Console.WriteLine($"Interpolated: {string.Join(", ", items)}");

Console.WriteLine("\nDone.");


Console.ReadLine();

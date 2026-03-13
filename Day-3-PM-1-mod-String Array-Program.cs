// 1. Create a string array
// 2. Add string elements into this array
// 3. User can enter elements from the console until the user enter "exit"
// 4. Print all elements in the array

string[] myCars = new string[10];
Console.WriteLine("Add a car brand and close with 'exit'");
int index = 0;
while (true)
{
    Console.Write("Add a car brand: ");
    string data = Console.ReadLine();
    if (data.ToLower().Trim() == "exit")
    {
        break;
    }

    myCars[index] = data;
    index++;
}
Array.Resize(ref myCars, index);
Console.WriteLine("My Cars unorders List");
for (int i = 0; i < myCars.Length; i++)
{
    Console.WriteLine(myCars[i]);
}

// Create a copy of the original array and sort it
var myCars2 = new string[myCars.Length];
myCars.CopyTo(myCars2,0);
Array.Sort(myCars2);
Console.WriteLine("My Cars ordered List");
foreach(string car in myCars2)
{ 
     Console.WriteLine(car); 
}

Console.ReadLine();
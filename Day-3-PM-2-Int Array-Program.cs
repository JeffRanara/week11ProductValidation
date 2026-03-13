Console.WriteLine("Input Numbers and type exit to show list");
int[] valueArray = new int[0];
int index = 0;

while (true)
{
    Console.Write("Input Number: ");
    string data = Console.ReadLine();
    if (data.ToLower().Trim() == "exit")
    {
        break;
    }

    bool isInt = int.TryParse(data, out int value);
    //Console.WriteLine(isInt);
    //Console.WriteLine(value);

    if (isInt)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("{0} is a NUMBER", data);
        Array.Resize(ref valueArray, index + 1);
        valueArray[index] = value;
        index++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"'{data}' is not a valid integer. Please try again.");
    }

    Console.ResetColor();


    //Array.Resize(ref valueArray, index + 1);
    //valueArray[index] = data;
    //valueArray[index] = Convert.ToInt32(data);
    //valueArray[index] = int.Parse(data);
    //index++;

}

Console.WriteLine("Unsorted view");
foreach (int item in valueArray)
{
    Console.WriteLine(item);
}

Array.Sort(valueArray);
Console.WriteLine("-------------------");
Console.WriteLine("Sorted View");
foreach (int item in valueArray)
{
    Console.WriteLine(item);
}

Console. ReadLine();
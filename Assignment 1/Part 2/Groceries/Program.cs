// See https://aka.ms/new-console-template for more information
using System.Linq;
List<string> groceries = new List<string>();

while (true) {
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    var inputstring = Console.ReadLine();
    if (inputstring[0] == '+')
    {
        groceries.Add(inputstring.Substring(1));
    }
    else if (inputstring[0] == '-')
    {
        Console.WriteLine("here");
        groceries.Remove(inputstring.Substring(1));
    }
    else if (inputstring[..2] == "--")
    {
        Console.WriteLine("here");
        groceries.Clear();
    }
    else {
        Console.WriteLine("Entry must start with +, -, or to clear, use --.");
    }
    foreach (string yah in groceries) {
        Console.WriteLine(yah);
    }
}
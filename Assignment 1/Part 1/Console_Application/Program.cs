// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter full name");
string fullName = Console.ReadLine();
Console.WriteLine("Enter your age");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your address");
string address = Console.ReadLine();
Console.WriteLine("You've been doxxed. Your name is " + fullName + ". Your age is " + age + ". Your address is " + address + ".");
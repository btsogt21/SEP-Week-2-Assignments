// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter birth year");
int birth_year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter birth month");
int birth_month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter birth day");
int birth_day = Convert.ToInt32(Console.ReadLine());
DateTime birth = new DateTime(birth_year, birth_month, birth_day);
double days_alive = (DateTime.Today - birth).TotalDays;
Console.WriteLine("You have been alive for " + days_alive + " days.");


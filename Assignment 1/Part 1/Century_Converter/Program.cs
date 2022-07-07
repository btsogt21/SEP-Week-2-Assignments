// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter an integer number of centuries");

double centuries = Convert.ToDouble(Console.ReadLine());
double years = checked(centuries * 100);
double days = checked(centuries * (100 * 365));
double hours = checked(centuries * (100 * 365 * 24));
double minutes = checked(centuries * (100 * 365 * 24*60));
double seconds = checked(centuries * (100 * 365 * 24 * 60 * 60UL));
double milliseconds = checked(centuries * (100 * 365 * 24 * 60 * 60UL*1000));
double microseconds = checked(centuries * (100 * 365 * 24 * 60 * 60UL * 1000 * 1000));
double nanoseconds = checked(centuries * (100 * 365 * 24 * 60 * 60UL * 1000 * 1000*1000));

Console.WriteLine(centuries + " centuries is " + years+ " years, " +
    days + " days, " + hours + " hours, " + minutes + " minutes, "+
    seconds + " seconds, " + milliseconds + " milliseconds, " +
    microseconds + " microseconds, and "+ nanoseconds + " nanoseconds.");
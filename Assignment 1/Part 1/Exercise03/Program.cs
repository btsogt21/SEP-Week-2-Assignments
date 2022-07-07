// See https://aka.ms/new-console-template for more information
int max = 100;
for (int i = 0; i < max; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.WriteLine(i + " fizzbuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i+ " buzz");
    }
    else if (i%3 == 0){
        Console.WriteLine(i+ " fizz");
    }
}
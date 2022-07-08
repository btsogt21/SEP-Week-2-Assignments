// See https://aka.ms/new-console-template for more information
int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("Guess the randomly generated integer between 1 and 3 inclusive.");
int guess = Convert.ToInt32(Console.ReadLine());
while (true) {
    if (guess == correctNumber)
    {
        Console.WriteLine("You guessed correctly");
        break;
    }
    else if (guess > 3)
    {
        Console.WriteLine("Your answer is greater than 3. Guess again!");
        guess = Convert.ToInt32(Console.ReadLine());
    }
    else if (guess < 1)
    {
        Console.WriteLine("Your answer is less than 1. Guess again!");
        guess = Convert.ToInt32(Console.ReadLine());
    }
    else {
        Console.WriteLine("Guess again!");
        guess = Convert.ToInt32(Console.ReadLine());
    }

}
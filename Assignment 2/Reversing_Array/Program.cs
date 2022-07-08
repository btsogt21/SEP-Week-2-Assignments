// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] GenerateNumbers(int size) {
    return new int[size];
}

static void Main(string[] args) {
    int[] numbers = GenerateNumbers();
}
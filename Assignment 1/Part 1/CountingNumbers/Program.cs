// See https://aka.ms/new-console-template for more information

for (int i = 1; i <= 4; i++) {
    for (int y = 0; y <= 24; y += i) {
        Console.Write(y + ", ");
    }
    Console.WriteLine();
}


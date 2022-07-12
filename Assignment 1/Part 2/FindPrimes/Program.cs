// See https://aka.ms/new-console-template for more information
static List<int> FindPrimesinRange(int StartNum, int EndNum) {
    while (StartNum < 1) {
        Console.WriteLine("Enter a number greater than 0. Negative numbers are not prime, and 0 is not prime.");
        StartNum = Convert.ToInt32(Console.ReadLine());
    }
    var primeList = new List<int>();
    for (int i = StartNum; i <= EndNum; i++) {
        if (i == 1) {
            primeList.Add(i);
            continue;
        }
        for (int y = 2; y < i; y++) {
            if (i % y == 0) {
                break;
            }
            if (y == i - 1) {
                primeList.Add(i);
            }
        }
    }
    return primeList;
}

foreach (int var in FindPrimesinRange(1, 100)) {
    Console.WriteLine(var);
}
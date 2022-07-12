// See https://aka.ms/new-console-template for more information
int[] numbers = new int[10];
for (int i = 0; i < 10; i++) {
    numbers[i] = i;
}

int[] numbers2 = new int[numbers.Length];

foreach (int i in numbers) {
    numbers2[i] = i;
}

foreach(var item in numbers){
    Console.WriteLine(item.ToString());
}

foreach (var item in numbers2)
{
    Console.WriteLine(item.ToString());
}
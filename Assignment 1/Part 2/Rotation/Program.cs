// See https://aka.ms/new-console-template for more information
int[] SumAfterRotation(int[] arr, int k)
{
    int times = k / arr.Length;
    int move = k % arr.Length;
    int sum = 0;
    int[] res = new int[arr.Length];
    foreach (var item in arr)
    {
        sum = sum + item;
    }
    sum = sum * times;
    Console.WriteLine(move);
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 1; j <= move; j++)
        {
            if (i - j >= 0)
            {
                res[i] = res[i] + arr[i - j];
            }
            else
            {
                res[i] = res[i] + arr[i - j + arr.Length];
            }
        }
        res[i] = sum + res[i];
    }
    return res;
}

int[] yah = new int[4] { 3, 2, 4, -1};

foreach (int i in SumAfterRotation(yah, 2)) {
    Console.WriteLine(i);
}

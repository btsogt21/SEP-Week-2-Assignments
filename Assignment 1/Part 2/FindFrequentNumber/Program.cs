// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
static void FrequentNumber(int[] arr){
    Dictionary<int, int> frequency = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++) {
        if (frequency.ContainsKey(arr[i]))
        {
            frequency[arr[i]]++;
        }
        else {
            frequency.Add(arr[i], 1);
        }
    }
    int maxValue = frequency.Values.Max();
    var matches = frequency.Where(pair => pair.Value == maxValue).Select(pair => pair.Key);
    int counter = 0;
    foreach (int var in matches) {
        counter++;
        Console.WriteLine(var);
        if (counter > 0) {
            break;
        }
    }
}

int[] test_array = new int[] { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };

FrequentNumber(test_array);
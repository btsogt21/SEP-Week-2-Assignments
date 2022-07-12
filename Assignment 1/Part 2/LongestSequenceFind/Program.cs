// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
static void LongestSequence(int[] arr) {
    Hashtable lengths = new Hashtable();
    int l = 0;
    int r = 0;
    int maxlen = 0;
    int currentlen;
    int start = 0;
    //List<int> subsequence;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == arr[l] && i!=arr.Length-1){
            continue;
        }
        else {
            currentlen = i - l;
            if (currentlen > maxlen){
                maxlen = currentlen;
                start = l;
            }
            maxlen = Math.Max(maxlen, i - l);
            //if (!lengths.ContainsKey(maxlen)) {
            //    lengths.Add(maxlen, l);
            //}
            l = i;
        }
    }
    for (int i = start; i < start + maxlen; i++) {
        Console.Write(arr[i]);
    }
}

int[] test_array = new int[] { 2, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
LongestSequence(test_array);


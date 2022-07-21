// Reverse through printing and for loop
void reverseStringPrint(string str) {
    for (int i = str.Length - 1; i >= 0; i--) {
        Console.WriteLine(str[i]);
    }
}

reverseStringPrint("yabadabadoo");


// Reverse through conversion to char-array


void ReverseString(string str) {
    char[] charArr = str.ToCharArray();
    Array.Reverse(charArr);
    string str2 = new(charArr);
    Console.WriteLine(str2);
}

ReverseString("yabadabadoo");


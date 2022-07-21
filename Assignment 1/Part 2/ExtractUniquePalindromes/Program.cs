void Palindromes() {
    string input = Console.ReadLine();
    HashSet<string> words = new HashSet<string>();
    string word_container = "";
    bool on_word = true;
    char[] charinput = input.ToCharArray();
    foreach (var c in charinput) {
        if (char.IsLetter(c)){
            on_word = true;
            word_container += c.ToString();
        }
        else {
            if (on_word && word_container != "") {
                words.Add(word_container);
            }
            on_word = false;
            word_container = "";
        }
        if (charinput[charinput.Length - 1] == c && word_container!="") {
            words.Add(word_container);
        }
    }
    foreach (var word in words) {
        if (IsPalindrome(word)) {
            Console.WriteLine(word);
        }
    }
}

bool IsPalindrome(string s) {
    if (s.Length <= 1)
    {
        return true;
    }
    int i = 0, j = s.Length - 1;
    while (i < j) {
        if (s[i] != s[j])
        {
            return false;
        }
        else {
            i++;
            j--;
        }
    }
    return true;
}

Palindromes();
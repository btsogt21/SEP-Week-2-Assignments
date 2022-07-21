using System.Linq;

void ReverseWords() {
    string str = Console.ReadLine();
    string[] special_char = {".", ",", ":", ";", "=", "(", ")", "&", "[", "]", "\"", "'", "\\", "/", "!", "?", " "};
    string container = "";
    string sep_container = "";
    List<string> list_of_words = new List<string>();
    List<string> list_of_seperators = new List<string>();
    for (int i = 0 ;i<str.Length; i++) {
        string test_string = str[i].ToString();
        if (!special_char.Contains(test_string)){
            if (sep_container != "") {
                list_of_seperators.Add(sep_container);
            }
            sep_container = "";
            container += test_string;
        }
        else {
            if(container!="")list_of_words.Add(container);
            container = "";
            sep_container += test_string;
        }
        if (i == str.Length - 1) {
            list_of_seperators.Add(sep_container);
        }
    }
    list_of_words.Reverse();
    string final_string = "";

    for (int i = 0; i < list_of_words.Count; i++) {
        final_string += list_of_words[i];
        final_string += list_of_seperators[i];
    }

    Console.WriteLine(final_string);
    //for (int i = 0; i < Math.Max(list_of_words.Count, list_of_seperators.Count); i++) {
    //    if (list_of_words.Count >= list_of_seperators.Count)
    //    {
    //        final_string += list_of_words[i];
    //        try
    //        {
    //            final_string += list_of_seperators[i];
    //        }
    //        catch
    //        {
    //            final_string += list_of_words[i];
    //        }
    //    }
    //    else if (list_of_seperators.Count>list_of_words.Count) {
    //        try
    //    }
    //}
    //for (int i = 0; i < list_of_seperators.Count; i++)
    //{
    //    Console.WriteLine(list_of_seperators[i]);
    //}
    //for (int i = 0; i < list_of_words.Count; i++)
    //{
    //    Console.WriteLine(list_of_words[i]);
    //}
}

ReverseWords();
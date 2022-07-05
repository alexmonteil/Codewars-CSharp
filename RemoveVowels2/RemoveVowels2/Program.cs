using System.Text;

string example = "hello";

static string RemoveVowels(string str)
{

    HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };

    StringBuilder result = new StringBuilder();

    for (int i = 0; i < str.Length; i++)
    {
        if (!vowels.Contains(str[i]))
        {
            result.Append(str[i]);
        }
    }

    return result.ToString();
}


Console.WriteLine(RemoveVowels(example));

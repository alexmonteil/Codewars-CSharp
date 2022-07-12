using System.Text;

static string ToCamelCase(string str)
{
    HashSet<char> chars = new HashSet<char> {'-', '_'};

    StringBuilder stringBuilder = new StringBuilder();

    for (int i = 0; i < str.Length - 1; i++)
    {
        if (chars.Contains(str[i]))
        {
            if (!chars.Contains(str[i + 1]))
            {
                str = str.Replace(str[i + 1], Char.ToUpper(str[i + 1]));
            }
        }
    }

    for (int i = 0; i < str.Length; i++)
    {
        if (!chars.Contains(str[i]))
        {
            stringBuilder.Append(str[i]);   
        }
    }

    return stringBuilder.ToString();
}

string test = "The_Stealth_Warrior";
string test2 = "the-stealth-warrior";
Console.WriteLine(ToCamelCase(test));
Console.WriteLine("\n");
Console.WriteLine(ToCamelCase(test2));

// See https://aka.ms/new-console-template for more information


using System.Text;

static string ToJadenCase(string phrase)
{
    StringBuilder stringBuilder = new StringBuilder(phrase.Length);
    char previous;
    char current;

    for (int i = 0; i < phrase.Length; i++)
    {
        current = phrase[i];

        // if first character, uppercase and append to stringbuilder
        if (i == 0)
        {
            stringBuilder.Append(current.ToString().ToUpper());
        }

        // if not first character
        if (i > 0)
        {
            previous = phrase[i - 1];
            
            // if previous character is white space, uppercase current and append to stringbuilder
            if (Char.IsWhiteSpace(previous))
            {
                stringBuilder.Append(current.ToString().ToUpper());
            }

            // otherwise append current to stringbuilder
            else
            {
                stringBuilder.Append(current.ToString());
            }
        }
    }

    return stringBuilder.ToString();
}


string test = "this is not capitalized 1 yet but it will be very soon";

Console.WriteLine(ToJadenCase(test));


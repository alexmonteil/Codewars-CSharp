// See https://aka.ms/new-console-template for more information


using System.Text;

static bool AreTheyTheSame(int[] a, int[] b)
{
    if (a.Length != b.Length)
    {
        return false;
    }

    Dictionary<int, int> aDictionary = new Dictionary<int, int>();
    Dictionary<int, int> bDictionary = new Dictionary<int, int>();  

    for (int i = 0; i < a.Length; i++)
    {
        if (aDictionary.ContainsKey(a[i]))
        {
            aDictionary[a[i]] = aDictionary[a[i]] + 1;
        }
        else
        {
            aDictionary.Add(a[i], 1);
        }

        if (bDictionary.ContainsKey(b[i]))
        {
            bDictionary[b[i]] = bDictionary[b[i]] + 1;  
        }
        else
        {
            bDictionary.Add(b[i], 1);
        }
    }


   foreach (KeyValuePair<int, int> kvp in aDictionary)
   {
       if (kvp.Value != bDictionary[kvp.Key])
       {
           return false;
       }
   }

   return true;

}


int[] a = new int[] { 1, 2, 3, 4, 5, 6 };
int[] b = new int[] { 1, 2, 2, 4, 5, 6 };
int[] c = new int[] { 1, 2, 3, 4, 5, 6 };

Console.WriteLine(AreTheyTheSame(a, b));
Console.WriteLine(AreTheyTheSame(a, c));


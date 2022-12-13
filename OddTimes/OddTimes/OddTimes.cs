
namespace OddTimesKata;

public static class OddTimes
{

    public static int find_it(int[] seq)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int i in seq)
        {
            if (dict.ContainsKey(i))
            {
                dict[i]++;
            }
            else
            {
                dict.Add(i, 1);
            }
        }

        foreach (KeyValuePair<int, int> kvp in dict)
        {
            if (kvp.Value % 2 != 0)
            {
                return kvp.Key;
            }
        }

        return -1;
    }
}

using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static Dictionary<char, int> Count(string str)
    {
        return str.GroupBy(val => val).ToDictionary(gr => gr.Key, gr => gr.Count());
    }
}
// ref: https://www.codewars.com/kata/59e19a747905df23cb000024

using System;
using System.Linq;

public class Kata
{
    public static string StringLetterCount(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return "";
        }

        return string.Join("", str.ToLower()
            .Where(char.IsLetter)
            .GroupBy(x => x)
            .OrderBy(gr => gr.Key)
            .Select(x => x.Count().ToString() + x.Key.ToString()));
    }
}
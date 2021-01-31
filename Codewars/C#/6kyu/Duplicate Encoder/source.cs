// ref: https://www.codewars.com/kata/54b42f9314d9229fd6000d9c

using System.Linq;
using System;

public class Kata
{
    public static string DuplicateEncode(string word)
    {
        return string.Join("", word.Select(x => word.Count(y => char.ToLower(x) == char.ToLower(y)) > 1 ? x = ')' : x = '('));
    }
}
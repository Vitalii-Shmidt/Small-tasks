// ref: https://www.codewars.com/kata/546f922b54af40e1e90001da

using System;
using System.Linq;
public static class Kata
{
    public enum Alphabet
    {
        a = 1, b = 2, c = 3, d = 4, e = 5, f = 6, g = 7, h = 8,
        i = 9, j = 10, k = 11, l = 12, m = 13, n = 14, o, p, q, r, s, t, u, v, w, x, y, z
    }
    public static string AlphabetPosition(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        return string.Join(" ",
            text.ToLower()
                .Where(ch => char.IsLetter(ch))
                .Select(x => (int)Enum.Parse(typeof(Alphabet), x.ToString()))
                );
    }
}
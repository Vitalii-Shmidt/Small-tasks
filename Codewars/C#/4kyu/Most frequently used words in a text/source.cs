// ref: https://www.codewars.com/kata/51e056fe544cf36c410000fb

using System;
using System.Collections.Generic;
using System.Linq;
public class TopWords {
                  public static List<string> Top3(string s) {
            return s.Trim()
                    .Split(new char[] {' ', ',', ':', '/', '_', '-', '!', '?', '.' })
                    .Where(x => x != string.Empty && x.Any(ch => char.IsLetter(ch) || ch == '\''))
                    .Select(x => x.ToLower().TrimStart('\''))
                    .GroupBy(val => val)
                    .OrderByDescending(gr => gr.Count())
                    .Take(3)
                    .Select(x => x.Key)
                    .ToList();
        }
}
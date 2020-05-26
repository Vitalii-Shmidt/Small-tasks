// ref: https://www.codewars.com/kata/545cedaa9943f7fe7b000048
using System;
using System.Linq;

public static class Kata {
      public static bool IsPangram(string str) {
        return str.ToLower()
              .Select(ch => ch)
              .Where((ch) => 
                    ((Convert.ToInt32(ch) >= 97) && (Convert.ToInt32(ch) <= 122)))
              .Distinct()
              .ToList()
              .Count == 26;
        }
}
// ref: https://www.codewars.com/kata/545cedaa9943f7fe7b000048

using System;
using System.Linq;
public static class Kata {
 public static bool IsPangram(string str) {
            var uniqueChars = str.Select(x => x)
                                 .Distinct()
                                 .ToList();
            uniqueChars.RemoveRange(uniqueChars.Count - 1, 1);
            return uniqueChars.Count < 26 ? false : true; // !uniqueChars.Count < 26 || uniqueChars.Count > 26. idk
        }
}
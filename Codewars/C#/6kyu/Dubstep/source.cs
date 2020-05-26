// ref: https://www.codewars.com/kata/551dc350bf4e526099000ae5

using System;
using System.Linq;

public class Dubstep {
            public static string SongDecoder(string input) {
            return string.Join(" ", input
                         .Replace("WUB", " ")
                         .Split(' ')
                         .Where(c => c != string.Empty));
        }
}  
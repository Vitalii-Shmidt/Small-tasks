// ref: https://www.codewars.com/kata/552c028c030765286c00007d

using System;
using System.Linq;

public class IQ
    {
        public static int Test(string input)
        { 
            var numbers = input.Split(' ')
                         .Where(x => x != string.Empty)
                         .Select(x => int.Parse(x))
                         .ToArray();

            return numbers.Count(x => x % 2 == 0) >= 2
                ? Array.IndexOf(numbers, numbers.First(x => x % 2 != 0)) + 1 
                : Array.IndexOf(numbers, numbers.First(x => x % 2 == 0)) + 1; 
        }
    }
// ref: https://www.codewars.com/kata/5287e858c6b5a9678200083c
 
using System;
using System.Linq;

// New solution;
public class Kata {
  public static bool Narcissistic(int value) {
    return value == value.ToString()
                         .ToCharArray()
                         .Select(ch => Math.Pow(char.GetNumericValue(ch), value.ToString().Length))
                         .Sum();
  }
  
 // An older solution;  
 public static bool Narcissistic(int value) {
            int sumOfPoweredDigits = 0;

            var arrOfCharsFromValue = value.ToString()
                                           .ToCharArray();

            var power = value.ToString()
                             .Length;

            foreach(var ch in arrOfCharsFromValue) {
                var tmp = char.GetNumericValue(ch);
                sumOfPoweredDigits += (int)Math.Pow(tmp, power);
            }

            return value == sumOfPoweredDigits;
        }

}

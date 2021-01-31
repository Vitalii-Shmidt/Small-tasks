// ref: https://www.codewars.com/kata/55c45be3b2079eccff00010f

using System;
using System.Linq;

public static class Kata
{
  public static string Order(string words) {
    if(string.IsNullOrEmpty(words)) {
      return "";
    }
    
    return string.Join(" ", 
                      words.Split(' ')
                           .OrderBy(val => TakeOnlyDigits(val))
                           .ToArray()
                      );
  }
  public static int TakeOnlyDigits(string str) {
    return int.Parse(string.Join("", str.Where(ch => char.IsDigit(ch))));
  }
}
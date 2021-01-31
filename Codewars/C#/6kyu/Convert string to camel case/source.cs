// ref: https://www.codewars.com/kata/517abf86da9663f1d2000003
using System;
using System.Linq;
public class Kata
{
  public static string ToCamelCase(string str) {
    if(string.IsNullOrEmpty(str)) {
      return "";
    }
    var counter = 0;
    return string.Join("",
                      str.Split('-', '_')
                         .Select(word => (counter++ > 0? (char.ToUpper(word[0])).ToString() 
                         : word[0].ToString()) + word.Substring(1, word.Length - 1))
                      );
  }
}
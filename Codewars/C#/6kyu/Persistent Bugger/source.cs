// ref: https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec

using System;
using System.Linq;

public class Persist 
{
  public static int Persistence(long n) {
    if(n.ToString().Length == 1) {
      return 0;
    }
    var iterations = 0;
    do {
      var digits = n.ToString()
                    .ToCharArray();
      var product = 1;
      foreach(var digit in digits) {
        product *= (int)char.GetNumericValue(digit);
      }
      n = product;
      ++iterations;
    } while(n.ToString().Length > 1);
    
    return iterations;
  }
}

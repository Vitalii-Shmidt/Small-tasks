//ref: https://www.codewars.com/kata/55b22ef242ad87345c0000b2

using System;
using System.Numerics;
class QuickCalc
{
   public static BigInteger Choose(int n, int p) {
      if(n < p) {
        return 0;
      }
     
     return Factorial(n) / (Factorial(p) * Factorial(n - p));
   }
   
  public static BigInteger Factorial(int n) {
    if(n == 0) {
      return 1;
    }
    
    return n * Factorial(n - 1);
  }
}
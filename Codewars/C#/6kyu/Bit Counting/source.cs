// ref: https://www.codewars.com/kata/526571aae218b8ee490006f4

using System;
using System.Linq;

public class Kata
{
  public static int CountBits(int n)
  {
    return Convert.ToString(n, 2).Where(ch => ch == '1').Count();
  }
}
//ref: https://www.codewars.com/kata/5c8e99ba171e834117a0e905

using System.Linq;
using System;

public class Kata 
{
  public class Account
  {
    public static string BinarySort(string s) {
      return  string.Join("", 
                          s.Where(ch => ch == '1' || ch == '0')
                           .OrderBy(val => int.Parse(val.ToString()))
                         );
    }
  }
}
// ref: https://www.codewars.com/kata/5519a584a73e70fa570005f5

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class Primes
{
    public static IEnumerable<int> Stream()
    {
        return Enumerable.Range(2, int.MaxValue - 1)
      .Where(x =>
      {
          if (x == 2 || x == 3)
          {
              return true;
          }

          if (x % 2 == 0 || x % 3 == 0)
          {
              return false;
          }

          for (var i = 5; i * i <= x; i += 6)
          {
              if (x % i == 0 || x % (i + 2) == 0)
              {
                  return false;
              }
          }

          return true;
      });
    }
}
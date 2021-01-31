// ref: https://www.codewars.com/kata/550498447451fbbd7600041c

using System;
using System.Linq;
class AreTheySame {
          public static bool comp(int[] a, int[] b) {
            if(a == null || b == null) {
              return false;
            }
            return Enumerable.SequenceEqual(
                a.Select(x => x * x)
                 .OrderBy(val => val), b.OrderBy(val => val)
                );
        }
}
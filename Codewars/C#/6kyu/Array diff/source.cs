// ref: https://www.codewars.com/kata/523f5d21c841566fde000009

using System.Linq;
using System.Collections.Generic;

public class Kata {
  public static int[] ArrayDiff(int[] a, int[] b) {
    var ans = new List<int>();
    foreach(var kek in a) {
      if(!b.Contains(kek)) {
        ans.Add(kek);
      }
      // or if(Contains(kek)) {
      //        continue;    
      //    }
      //    ans.Add(kek);
    }
    
    return ans.ToArray();
  }
}
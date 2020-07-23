// ref: https://www.codewars.com/kata/58ad317d1541651a740000c5
 namespace myjinxin {
    using System;
    using System.Collections.Generic;
    using System.Linq;
  
         public class Kata {
           public string MiddlePermutation(string source) {
             
            var sortedSource = new string(source.OrderByDescending(ch => ch).ToArray());
             // checks is our source string have an even or odd length
             var middle = source.Length % 2 + 1;
            
            return sortedSource.Substring(source.Length / 2, middle) 
              + sortedSource.Remove(source.Length / 2, middle);
          }
        }
}
// ref: https://www.codewars.com/kata/550554fd08b86f84fe000a58

using System.Collections.Generic;
using System.Linq;

class WhichAreIn {
              public static string[] inArray(string[] substrs, string[] words) {
                var ans = new List<string>();
                foreach(var word in words) {
                    foreach(var sub in substrs) {
                        if(word.Contains(sub)) {
                            ans.Add(sub);
                        } 
                    }
                }
                return ans.Select(x => x)
                          .OrderBy(x => x)
                          .Distinct()
                          .ToArray();
            }
}
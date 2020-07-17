// ref: https://www.codewars.com/kata/51e056fe544cf36c410000fb

using System;
using System.Collections.Generic;
using System.Linq;
public class TopWords
{          // (TL)
           public static List<string> Top3(string s) {
            var mostFrequentlyUsedWords = s.Trim()
                                           .Split(' ', ',', ':', '/')
                                           .Select(x => x.ToLower())
                                           .GroupBy(val => val)
                                           .OrderByDescending(gr => gr.Count())
                                           .Select(x => x.Key);
           
            var ans = new List<string>();

            foreach(var word in mostFrequentlyUsedWords) {
               if(ans.Count() == 3) {
                    break;
                } 
              if(!string.IsNullOrWhiteSpace(word)) {
                    ans.Add(word);
                }
               
            }

            return ans;
        }
}
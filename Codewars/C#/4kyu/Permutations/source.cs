// ref: https://www.codewars.com/kata/5254ca2719453dcc0b00027d/solutions/csharp

using  System;
using System.Linq;
using System.Collections.Generic;

public class Permutations 
{
        public static IEnumerable<string> SinglePermutations( string s ) 
        {
            if ( s.Length == 1 ) 
            {
                return new List<string> { s };
            }
            var permutations = new HashSet<string>();
            foreach (var substring in SinglePermutations(s.Substring(1))) 
            {
                for (var i = 0; i <= substring.Length; ++i) 
		{
                    permutations.Add(substring.Substring(0,i) + s [0] + substring.Substring(i));
                }
            }
            return permutations.ToList();
        }
    }
// ref: https://www.codewars.com/kata/58ad317d1541651a740000c5
    using System;
    using System.Collections.Generic;
    using System.Linq;

public class Kata {
    // (TL)
    public string MiddlePermutation(string s) {
        var permutations = s.Permutations()
                            .Select(x => string.Join("", x))
                            .OrderBy(val => val)
                            .ToArray();

        return permutations[permutations.Length / 2 - 1];
    }
}

// This part of code I copied from StackOverflow: https://stackoverflow.com/a/58826787/13936286 
public static class PermutationsExtension {

        /// <summary>
        /// Returns array of all permutations of elements of initial collection.
        /// </summary>        
        public static IEnumerable<T[]> Permutations<T>(this IEnumerable<T> source) {
            var sourceArray = source.ToArray();
            var results = new List<T[]>();
            Permute(sourceArray, 0, sourceArray.Length - 1, results);
            return results;
        }

        /// <summary>
        /// Recursion function, that exactly makes a pairs(permutations) by initial collection.
        /// <param name="elements">Initial collection</param>
        /// <param name="recursionDepth">Current recursion depth</param>
        /// <param name="maxDepth">Initial collection items count</param>
        /// <param name="results">Results collecion, that stores all permutations.</param>
        /// </summary> 
        private static void Permute<T>(T[] elements, int recursionDepth, int maxDepth, ICollection<T[]> results) {
            if (recursionDepth == maxDepth) {
                results.Add(elements.ToArray());
                return;
            }

            for (var i = recursionDepth; i <= maxDepth; ++i) {
                Swap(ref elements[recursionDepth], ref elements[i]);
                Permute(elements, recursionDepth + 1, maxDepth, results);
                Swap(ref elements[recursionDepth], ref elements[i]);
            }
        }

        /// <summary>
        /// Generic-function, that swaping values. 
        /// </summary>
        private static void Swap<T>(ref T a, ref T b) {
            T tmp = a;
            a = b;
            b = tmp;
        }
  }
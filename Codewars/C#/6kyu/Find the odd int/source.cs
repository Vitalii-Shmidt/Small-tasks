// ref: https://www.codewars.com/kata/54da5a58ea159efa38000836/
using System.Linq;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq) {
            return seq.Select(x => x)
                      .GroupBy(x => x)
                      .Where(gr => gr.Count() % 2 == 1)
                      .ToList()
                      .First()
                      .Key;
        }

    }
}
// ref: https://www.codewars.com/kata/578aa45ee9fd15ff4600090d
using System.Linq;

public class Kata
{
        public static int[] SortArray(int[] array)
        {
            var sortedOdds = array.Where(x => x % 2 != 0).OrderBy(val => val).ToArray();
            var oddIndex = 0;
            
            return array.Select(x => x % 2 == 0 ? x : sortedOdds[oddIndex++]).ToArray();
        }
}
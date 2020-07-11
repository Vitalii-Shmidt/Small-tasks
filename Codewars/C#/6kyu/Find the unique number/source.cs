// ref: https://www.codewars.com/kata/585d7d5adb20cf33cb000235

using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers) {
        return numbers.GroupBy(val => val)
                      .Where(gr => gr.Count() == 1)
                      .First()
                      .Key;
    }
}
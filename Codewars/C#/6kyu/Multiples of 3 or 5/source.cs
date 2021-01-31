// ref: https://www.codewars.com/kata/514b92a657cdc65150000006/
using System.Linq;

public static class Kata
{
    public static int Solution(int value) {
        var sequence = new int[value];

        for (int i = 0; i < sequence.Length; ++i) {
            sequence[i] = i;
        }

        return sequence.Where(x => x % 3 == 0 || x % 5 == 0)
                       .Sum();
    }
}
// ref: https://www.codewars.com/kata/596d34df24a04ee1e3000a25

using System;
using System.Numerics;
using System.Linq;
public class BitCount
{
       public static BigInteger CountOnes(long left, long right) {
            var ans = new BigInteger();

            for (var i = left; i <= right; ++i) {
                var binary = Convert.ToString(i, 2);
                ans += binary.Count(ch => ch == '1');
            }

            return ans;
        }
}
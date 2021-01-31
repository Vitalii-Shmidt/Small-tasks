using System;
using System.Linq;

public class Solution
{
        public static int solve(int [] arr)
        {
            return arr.Where((val, index) => IsPrime(index)).Sum();
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (var i = 3; i <= boundary; i+=2)
                if (number % i == 0)
                    return false;

            return true;        
        }
}
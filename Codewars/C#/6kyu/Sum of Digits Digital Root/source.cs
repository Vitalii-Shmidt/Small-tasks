// ref: https://www.codewars.com/kata/541c8630095125aba6000c00
using System;
using System.Linq;

public class Number {
   public int DigitalRoot(long n) {
            var digits = n.ToString();
            var sum = 0;

            while (digits.Length > 1) {
                sum = 0;
                foreach (var ch in digits) {
                    sum += (int)char.GetNumericValue(ch);
                }
                digits = sum.ToString();
            }

            return sum;
        }
}
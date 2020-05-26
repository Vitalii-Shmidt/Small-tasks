// ref: https://www.codewars.com/kata/5324945e2ece5e1f32000370

using System;
using System.Numerics;

public static class Kata {
        public static string sumStrings(string a, string b) {
            if(string.IsNullOrEmpty(a)) {
                if(string.IsNullOrEmpty(b)) {
                    return "";
                }
                BigInteger bb = BigInteger.Parse(b);
                return bb.ToString();
            } else if(string.IsNullOrEmpty(b)) {
                if(string.IsNullOrEmpty(a)) {
                    return "";
                }
                BigInteger aa = BigInteger.Parse(a);
                return aa.ToString();
            }
            if (a == "0" || b == "0") {
                return "0";
            }
            BigInteger ans = BigInteger.Parse(a) + BigInteger.Parse(b);
            return ans.ToString();
        }
}
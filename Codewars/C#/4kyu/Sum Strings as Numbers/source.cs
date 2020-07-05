// ref: https://www.codewars.com/kata/5324945e2ece5e1f32000370
using System;
using System.Numerics;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        var trash = new BigInteger();
        var aIsOk = BigInteger.TryParse(a, out trash);
        var bIsOk = BigInteger.TryParse(b, out trash);

        if (aIsOk && bIsOk)
        {
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
        else if (bIsOk)
        {
            return (BigInteger.Parse(b)).ToString();
        }
        else if (aIsOk)
        {
            return (BigInteger.Parse(a)).ToString();
        }

        return "0";
    }
}
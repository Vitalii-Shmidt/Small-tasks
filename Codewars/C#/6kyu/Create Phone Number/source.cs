// ref: https://www.codewars.com/kata/525f50e3b73515a6db000b83

using System;
public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        var ans = "";
        var counter = 0;
        foreach (var numb in numbers)
        {
            if (counter == 0)
            {
                ans += "(";
            }
            else if (counter == 3)
            {
                ans += ") ";
            }
            else if (counter == 6)
            {
                ans += "-";
            }
            ans += numb.ToString();
            counter += 1;
        }

        return ans;
    }
    public static string CreatePhoneNumber(int[] numbers)
    {
        return $"({string.Join("", numbers.Take(3).ToArray())} {string.Join("", numbers.Skip(3).Take(3))}-{string.Join("", numbers.Skip(6).Take(4))})";
    }


}
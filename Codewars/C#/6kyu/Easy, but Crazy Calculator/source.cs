// ref: https://www.codewars.com/kata/56b71974bd06e679a800090b

namespace smile67Kata
{
    using System;
    using System.Data;
  
    public class Kata {
        public double crazyCalculate(string input) {
            return Convert.ToDouble(
                new DataTable().Compute(
                    input.Replace("+", "#")
                          .Replace("-", "+")
                          .Replace("#", "-")                 
                          .Replace("*", "#")
                          .Replace("/", "*")
                          .Replace("#", "/"),
                (int.MaxValue).ToString()
                    )
            );
        }
    }
}
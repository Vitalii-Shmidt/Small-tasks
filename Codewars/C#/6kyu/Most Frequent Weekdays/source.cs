// ref: https://www.codewars.com/kata/56eb16655250549e4b0013f4

using System;
using System.Linq;

public class Kata
{
  public static string[] MostFrequentDays(int year)
  {
      var dt = new DateTime(year, 1, 1);
      return DateTime.IsLeapYear(year) 
          ? (new[] { dt.DayOfWeek, dt.AddDays(1).DayOfWeek })
                                .OrderBy(dw => dw == DayOfWeek.Sunday ? 7 : (int)dw)
                                .Select(dw => dw.ToString())
                                .ToArray()
          : new[] { dt.DayOfWeek.ToString() };
  }
}
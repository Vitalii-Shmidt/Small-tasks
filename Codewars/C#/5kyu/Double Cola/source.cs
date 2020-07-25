// ref: https://www.codewars.com/kata/551dd1f424b7a4cdae0001f0

using System;

public class Line
{
	public static string WhoIsNext(string[] names , long n)
        {
            if (n < names.Length)
            {
                return names[n - 1];
            }
          
            var index = n - 1;  
            while (index >= names.Length)
            {
                index = (index - names.Length) / 2;
            }

            return names[index];
        }
    }
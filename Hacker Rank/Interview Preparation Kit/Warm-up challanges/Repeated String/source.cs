// ref: https://www.hackerrank.com/challenges/repeated-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)) return 0;
            if (s.Length == 1)
            {
                if (s[0] == 'a')
                {
                    return n;
                }
            }

            if (s.Length >= n)
            {
                return s.Substring(0, (int)n).Count(ch => ch == 'a');
            }
            
            var occurences = s.Count(ch => ch == 'a');

            var times = n / s.Length;

            var remainder = n % s.Length;

            return occurences * times + s.Substring(0, (int)remainder)
                                         .Count(ch => ch == 'a');
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

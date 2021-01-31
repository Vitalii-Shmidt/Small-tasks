// ref: https://www.codewars.com/kata/556deca17c58da83c00002db

using System.Linq;
using System.Collections.Generic;

public class Xbonacci
{
    public double[] Tribonacci(double[] signature, int n) {
        if(n <= 3) {
          return signature.Take(n)
                          .ToArray();
        }
        var sequence = new List<double>(signature);
        for(int i = 3; i < n; ++i) {
            sequence.Add(sequence[i - 3] + sequence[i - 2] + sequence[i - 1]);
        }
        return sequence.Take(n)
                       .ToArray();
    }
}
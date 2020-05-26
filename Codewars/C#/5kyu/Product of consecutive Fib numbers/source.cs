// ref: https://www.codewars.com/kata/5541f58a944b85ce6d00006a

using System.Collections.Generic;

public class ProdFib {
      public static ulong[] productFib(ulong prod) {
            //F(n) * F(n+1) = prod
            var Fib = new List<ulong>() {0, 1};
            for(int i = 0; i < Fib.Count - 1; ++i) {
                if (Fib[i] * Fib[i + 1] < prod) {
                    Fib.Add(Fib[i] + Fib[i + 1]);
                }else if(Fib[i] * Fib[i + 1] > prod) {
                    return new ulong[] { Fib[i], Fib[i + 1], 0 };
                } else {
                    return new ulong[] { Fib[i], Fib[i + 1], 1 };
                }
            }
            throw new ArgumentException("I don't know, how aplication is crash down....");
        }
}
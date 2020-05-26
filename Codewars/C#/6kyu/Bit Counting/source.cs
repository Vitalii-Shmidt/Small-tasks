// ref: https://www.codewars.com/kata/526571aae218b8ee490006f4

using System;

public class Kata {
      public static int CountBits(int n) {
            //need to compute amount of 1s;      
            int counter = 0;
            if( n == 0) {
                return 0;
            }
            string str = "";
            while(n >= 2) {
                str += (n % 2).ToString();
                n /= 2;
            }
            for(int i = 0; i < str.Length; ++i) {
                if(str[i] == '1') {
                    ++counter;
                }
            }
            return counter + 1;
        }
}
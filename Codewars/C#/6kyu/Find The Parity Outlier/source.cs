// ref: https://www.codewars.com/kata/5526fc09a1bbd946250002dc
using System.Collections.Generic;
using System;

public class Kata {
   public static int Find(int[] a) {
            var even = 0;
            var odd = 0;
            var evenCounter = 0;
            var oddCounter = 0;
            foreach(var numb in a) {
                if(Math.Abs(numb) % 2 == 0 && evenCounter < 2) {
                    even = numb;
                    ++evenCounter;
                } else if(Math.Abs(numb) % 2 == 1 && oddCounter < 2) {
                    odd = numb;
                    ++oddCounter;
                }
            }
            return oddCounter < 2 ? odd : even;
        }
}
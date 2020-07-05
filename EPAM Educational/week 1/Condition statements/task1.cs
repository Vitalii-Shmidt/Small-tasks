       /*
         Task 1:
         For a given integer n calculate the value which is equal to a:
         • squared number, if its value is strictly positive;
         • modulus of a number, if its value is strictly negative;
         • zero, if the integer n is zero.
         Examples:
         n = 4 result = 16
         n = -5 result = 5
         n = 0 result = 0
         */
        public static int Task1(int n) {
            if (n == 0) return 0;
            if (n < 5) return n * -1;

            return n * n;
        }
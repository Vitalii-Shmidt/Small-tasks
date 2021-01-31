/*
Task 2:
For a positive integer n calculate the result value, which is equal to the sum of the “1” in the binary representation of n.
Example:
n = 1410 = 11102 result = 3
n = 12810 = 1000 00002 result = 1
*/

        public static int Task2(int n) {
            var binary = Convert.ToString(n, 2);
            var counter = 0;
            foreach(var ch in binary) {
                if(ch == '1') {
                    ++counter;
                }
            }

            return counter;
        }
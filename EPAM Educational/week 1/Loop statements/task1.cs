/*
Task1:
For a positive integer n calculate the result value, which is equal to the sum of the odd numbers of n.
Example:
n = 1234 result = 4
n = 246 result = 0
*/

 public static int Task1(int n) {
            var chars = n.ToString()
                         .ToCharArray();

            var result = 0;

            foreach(var ch in chars) {
                var tmp = (int)char.GetNumericValue(ch);
                if (tmp % 2 != 0) {
                    result += tmp;
                }
            }

            return result;
        }
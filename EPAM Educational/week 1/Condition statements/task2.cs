/*
 Task 2:
Find the maximum integer, that can be obtained by permutation of numbers of an arbitrary three-digit
positive integer n (100<=n<=999).
Example:
n = 165 result = 651
 */
public static int Task2(int n) {
    return Convert.ToInt32(
        new string(
            n.ToString()
             .ToCharArray()
             .Select(ch => ch)
             .OrderByDescending(val => char.GetNumericValue(val))
             .ToArray()
             )
         );
}
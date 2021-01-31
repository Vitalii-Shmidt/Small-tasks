// ref: https://www.codewars.com/kata/52774a314c2333f0a7000688

public class Parentheses {
    public static bool ValidParentheses(string input) {
        var opened = 0;
        var closed = 0;
        foreach (var ch in input) {
            if (ch == '(') {
                ++opened;
            } else if (ch == ')') {
                ++closed;
            }
            if (closed > opened) {
                return false;
            }
        }
        return closed == opened;
    }
}
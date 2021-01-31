// ref: https://www.codewars.com/kata/5a9c35e9ba1bb5c54a0001ac

int Add(int x, int y) {
    while (y != 0) {
        int carry = x & y;
        x = x ^ y;
        y = carry << 1;
    }

    return x;
}
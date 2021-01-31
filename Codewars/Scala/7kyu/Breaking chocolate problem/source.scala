// ref: https://www.codewars.com/kata/534ea96ebb17181947000ada

object Sol {

  def breakChocolate(n: Int, m: Int): Int = {
    if(n == 0 || n < 0 || m < 0 || m == 0) {
      return 0
    }
     return math.max(n * m - 1, 0);
  }
}
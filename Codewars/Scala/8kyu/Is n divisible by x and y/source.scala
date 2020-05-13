// Reference to problem: https://www.codewars.com/kata/5545f109004975ea66000086/scala

object Kata {
  def isDivisible(n: Int, x: Int, y: Int): Boolean = {
    var divizible = false;
    if( n % x == 0 && n % y == 0) {
      divizible = true
    }
    return divizible;
  }
}
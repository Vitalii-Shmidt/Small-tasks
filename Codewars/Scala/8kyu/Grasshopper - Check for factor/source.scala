// ref: https://www.codewars.com/kata/55cbc3586671f6aa070000fb

object Kata {
  def checkForFactor(base: Int, factor: Int): Boolean = {
    if(base < factor) return false;
    else if(base % factor != 0) return false;
    return true
  }
}
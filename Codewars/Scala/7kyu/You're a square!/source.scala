// ref: https://www.codewars.com/kata/54c27a33fb7da0db0100040e

object Sol {

  def isSquare(x: Int): Boolean = {
    if(x == 0) return true
    else if(x < 0) return false
    else if(x % math.sqrt(x) == 0) return true
    else {
      return false
    }
  }
}
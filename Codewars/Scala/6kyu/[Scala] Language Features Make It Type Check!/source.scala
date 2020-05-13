// ref: https://www.codewars.com/kata/5c17c7e99830f977d100006a

object Kata {
    implicit def toInt(b: Boolean): Int = {
      if(b) {
        return 1
      } 
      return 0
    }
    implicit def toBool(n: Int): Boolean = {
      return n != 0
    }
  }
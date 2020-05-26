// ref: https://www.codewars.com/kata/52f787eb172a8b4ae1000a34

object Solution {
   def zeros(n: Int): Int =
    n / 5 match {
      case 0 => 0
      case x => x + zeros(x)
    }
}
// ref: https://www.codewars.com/kata/556deca17c58da83c00002db

object Tribonacci {
  def tribonacci[T: Numeric](signature: List[T], n: Int): List[T] = {
    if(n <= 3) {
      return signature.take(n)
    }
    var sequence = List[T](signature(0), signature(1), signature(2))
    for(i <- 3 to n) {
      sequence :+ (signature.takeRight(3).sum)
    }
    return sequence
  }
}
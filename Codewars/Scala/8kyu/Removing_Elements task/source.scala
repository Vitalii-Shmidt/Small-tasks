// Reference to a problem: https://www.codewars.com/kata/5769b3802ae6f8e4890009d2

object Kata {
   def removeEveryOther[T](list: List[T]): List[T] = {
    var ans = List[T]()
    var it = 1
    for(item <- list) {
      if(it % 2 != 0) {
        ans = item :: ans
      }
      it += 1
    }
    return  ans.reverse
  }
}
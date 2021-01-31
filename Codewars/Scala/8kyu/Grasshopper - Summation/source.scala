// ref: https://www.codewars.com/kata/55d24f55d7dd296eb9000030

object Kata {

  def summation(n: Int): Int = {
    // is possible to rewrite it in recursive, but no(with the help of 
    // helper-function with accumulator)
    // something like factiorial, but via summ u know man yeee 
    if(n == 0 || n == 1) return n
    var it = 0
    var ans = 0
    do {
      ans += it
      it += 1
    
    } while(it != n)

    return ans + it
  }
}
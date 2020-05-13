// ref: https://www.codewars.com/kata/526571aae218b8ee490006f4

object Kata {

   def countBits(n: Int): Int = {
    if(n == 0) {
      return 0
    }
    var nn = n
    var counter = 0
    var str = ""
    while(nn >= 2) {
      str += (nn % 2).toString
      nn /= 2
    }
    // kek
    for(ch <- str) {
      if(ch == '1') {
        counter += 1
      }
    }
    // kek
    return counter + 1
  }
}
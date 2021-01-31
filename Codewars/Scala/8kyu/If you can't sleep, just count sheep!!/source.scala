// ref: https://www.codewars.com/kata/5b077ebdaf15be5c7f000077

object Kata {
  def countingSheep(num: Int): String = {
    var ans = "" 
    var it = 1
    while(it <= num) {
      ans += it.toString + " sheep..."
      it += 1
    }
    return ans
  }
}
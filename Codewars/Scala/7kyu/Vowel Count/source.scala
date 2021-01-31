// ref: https://www.codewars.com/kata/54ff3102c1bad923760001f3

object Sol {
  def getCount(str: String): Int = {
    var ans = 0
    str.foreach(x => if(x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u') ans += 1)
    return ans
  }
}